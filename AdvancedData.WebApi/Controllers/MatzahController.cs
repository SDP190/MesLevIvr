using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedData.Data;
using AdvancedData.Data.Misc;
using AdvancedData.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using Microsoft.EntityFrameworkCore;
using AdvancedData.Data.Helpers;
using AdvancedData.Data.Entities;

namespace AdvancedData.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatzahController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<MatzahController> _logger;
        private AdvancedDataRepository _ad_repository;

        private bool validatePhoneNumber(string phonenumber, out string validated)
        {
            validated = phonenumber;
            if (phonenumber.Length == 11 && phonenumber[0] == '1')
            {
                validated = phonenumber.Substring(0, 10);
            }

            if (validated.Length > 10 || validated.Length < 10)
            {
                //phone number is bad format
                validated = null;
                return false;                    
            }            
            return true;
        }

        public MatzahController(ILogger<MatzahController> logger, AdvancedDataRepository ad_repository)
        {
            _logger = logger;
            _ad_repository = ad_repository;
        }

        //Branch 44 (Yiddish), 515 (English)
        [HttpPost("inquireCustomerStatus")]
        public async Task<ActionResult<TelegroundResponse>> InquireCustomerStatus([FromBody] TelegroundRequest request)
        {
            
            //get language
            LanguagesEnum language = LanguagesEnum.Yiddish;
            var branchData = request.BranchData.Last();

            if(branchData.Branch == 550)
            {
                language = LanguagesEnum.English;
            }

            //get variable $homephone
            string phoneNumber = null; // request.Variables.TryGetValue("$homephone",out phoneNumber);

            int? goTo = null;
            
            if ((!request.Variables.TryGetValue(TGCustomVariables.PHONENUMBER, out phoneNumber)) || (string.IsNullOrEmpty(phoneNumber)) )
            {
                return this.BadRequest("phone number variable not exists");
            }

            //validate usa-canada phone number format
            string validatedPhoneNum;
            if(!validatePhoneNumber(phoneNumber,out validatedPhoneNum))
            {
                return BadRequest("phone number invalid format");
            }

            var receiver = await _ad_repository.GetReceiversByPhone(phoneNumber).FirstOrDefaultAsync();
            
            if (receiver != null)
            {
                //if the Receiver is in the db it will check if they have already ordered
                bool hasOrders = await this._ad_repository.ReceiverHasOrdersAsync(receiver.ReceiverId);
                if (hasOrders)
                {
                    switch (language)
                    {
                        case LanguagesEnum.English:
                            goTo = 1053;
                            break;
                        case LanguagesEnum.Yiddish:
                            goTo = 1043;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (language)
                    {
                        case LanguagesEnum.English:
                            goTo = 515;
                            break;
                        case LanguagesEnum.Yiddish:
                            goTo = 44;
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                //Not registered yet! so lets register him!
                _logger.LogInformation("Starting new custumer registration.");

                //try to get name
                //request.cname not implemented yet                

                receiver = await _ad_repository.AddNewReceiverAsync("BLANK", "BLANK", validatedPhoneNum);

                switch (language)
                {
                    case LanguagesEnum.English:
                        goTo = 515;
                        break;
                    case LanguagesEnum.Yiddish:
                        goTo = 44;
                        break;
                    default:
                        break;
                }
            }

            //We should add custom vars to response with first and last name!  

            string firstName = receiver.FirstName;
            string lastName = receiver.LastName;

            var response = new TelegroundResponse
            {
                Goto = goTo
            };


            response.Variables = (request.Variables != null) ? (new Dictionary<string, string>(request.Variables)) : new Dictionary<string, string>();
            response.Variables[TGCustomVariables.LANGUAGE] = (language == LanguagesEnum.English) ? "EN":"YI";
            response.Variables[TGCustomVariables.FIRSTNAME] = firstName;
            response.Variables[TGCustomVariables.LASTNAME] = lastName;
            response.Variables[TGCustomVariables.RECEIVERID] = receiver.ReceiverId.ToString();
            return response;
        }

        //Branch 48 (Yiddish), 548 (English)
        [HttpPost("branch48en548")]
        public async Task<ActionResult<TelegroundResponse>> Branch48en548([FromBody] TelegroundRequest request)
        {
            //get language
            LanguagesEnum language = LanguagesEnum.Yiddish;
            try
            {
                if (request.Variables[TGCustomVariables.LANGUAGE] == "EN")
                {
                    language = LanguagesEnum.English;
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"variable {TGCustomVariables.LANGUAGE} not found.");
            }

            int? goTo = null;

            string matzohType = null;

            //example
            matzohType = MatzahTypeInputs.CHABIRA_REG;

            decimal matzohTypeId = MatzosHelper.GetIdForMatzahTypeInput(matzohType);

            //get item info
            MLItemView itemInfo = await this._ad_repository.GetMatzahTypeItemInfoAsync(matzohTypeId);

            var response = new TelegroundResponse();
            response.Variables = new Dictionary<string, string>(request.Variables);

            //check if type exists
            if (itemInfo == null)
            {
                _logger.LogInformation("MatzahItemType specified was not found.");
                goTo = (language == LanguagesEnum.Yiddish) ? 1000 : 1060;
            }
            else
            {

                //check if in stock
                if (itemInfo.Quantity < 1)
                {
                    goTo = (language == LanguagesEnum.Yiddish) ? 1000 : 1060;
                }
                else
                {
                    response.Variables[TGCustomVariables.MATZAHTYPEID] = matzohTypeId.ToString();
                    response.Variables[TGCustomVariables.MATZAHTYPEQUANTITY] = itemInfo.Quantity?.ToString();
                    response.Variables[TGCustomVariables.MATZAHTYPEPRICE] = itemInfo.Price.ToString();

                    goTo = (language == LanguagesEnum.Yiddish) ? 50 : 518;
                }
            }

            response.Goto = goTo;
            
            return response;


        }

        [HttpPost]
        public IActionResult DoSomething()   //<IEnumerable<WeatherForecast>
        // https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1
        {
            var response = new TelegroundResponse
            {
                Goto = 5
                //, todo
            };

            return Ok(response);


            //var rng = new Random();
            //return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55)
            //    //Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray());
        }
    }
}
