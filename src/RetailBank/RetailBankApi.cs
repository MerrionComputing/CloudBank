using System;
using System.Net.Http;
using System.Threading.Tasks; 

namespace CloudBank.RetailBank
{
    public  class RetailBankApi
    {

        public const string URI_BASE = @"https://retailbankazurefunctionapp.azurewebsites.net/api/";

        public const string ROUTE_COMMAND_OPENACCOUNT = @"OpenAccount/{accountnumber}";
        public const string ROUTE_QUERY_GETBLANCE = @"GetBalance/{accountnumber}";
        public const string ROUTE_COMMAND_DEPOSITMONEY = @"DepositMoney/{accountnumber}";
        public const string ROUTE_COMMAND_WITHDRAWMONEY = @"WithdrawMoney/{accountnumber}";
        public const string ROUTE_COMMAND_SETOVERDRAFT = @"SetOverdraftLimit/{accountnumber}";
        public const string ROUTE_COMMAND_SETOWNER = @"SetBeneficialOwner/{accountnumber}/{ownername}";

        
        public const string PAYLOAD_TYPE = @"application/json";

        public static Uri GetBase()
        {
            return new Uri(URI_BASE);
        }

        public static Uri GetBalance(string accountNumber, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_QUERY_GETBLANCE.Replace("{accountnumber}", accountNumber) + $"?code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_QUERY_GETBLANCE.Replace("{accountnumber}", accountNumber) , UriKind.Relative);
            }
        }

        public static Uri OpenAccount(string accountNumber, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_COMMAND_OPENACCOUNT.Replace("{accountnumber}", accountNumber) + $"?code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_COMMAND_OPENACCOUNT.Replace("{accountnumber}", accountNumber) , UriKind.Relative);
            }
        }

        public static Uri DepositMoney(string accountNumber, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_COMMAND_DEPOSITMONEY.Replace("{accountnumber}", accountNumber) + $"?code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_COMMAND_DEPOSITMONEY.Replace("{accountnumber}", accountNumber) , UriKind.Relative);
            }
        }

        public static Uri WithdrawMoney(string accountNumber, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_COMMAND_WITHDRAWMONEY.Replace("{accountnumber}", accountNumber) + $"?code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_COMMAND_WITHDRAWMONEY.Replace("{accountnumber}", accountNumber) , UriKind.Relative);
            }
        }

        public static Uri SetOverdraft(string accountNumber, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_COMMAND_SETOVERDRAFT.Replace("{accountnumber}", accountNumber) + $"?code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_COMMAND_SETOVERDRAFT.Replace("{accountnumber}", accountNumber) , UriKind.Relative);
            }
        }

        public static Uri SetOwner(string accountNumber, string ownerName, string apikey)
        {
            if (!string.IsNullOrEmpty(apikey))
            {
                return new Uri(ROUTE_COMMAND_WITHDRAWMONEY.Replace("{accountnumber}", accountNumber).Replace("{ownername}", ownerName) + $" ? code={apikey}", UriKind.Relative);
            }
            else
            {
                return new Uri(ROUTE_COMMAND_WITHDRAWMONEY.Replace("{accountnumber}", accountNumber).Replace("{ownername}", ownerName), UriKind.Relative);
            }
        }
    }

    public class RetailBankApiMock
    : IRetailBankApi
    {
        // Queries : 
        public Task<ProjectionFunctionResponse> GetAccountBalance(HttpClient http, string accountnumber)
        {
            return Task<ProjectionFunctionResponse>.FromResult(new ProjectionFunctionResponse() { 
                Message= "This is a mock account balance", 
                InError =false  
            });  
        }

        private ApiCommand[] _commands;
        public void Initialise(ApiCommand[] commands)
        {
            _commands = commands;
        }

        public Task<FunctionResponse> OpenAccount(HttpClient httpClient, string accountnumber, AccountOpeningData payload)
        {
            return Task<FunctionResponse>.FromResult(new FunctionResponse()
            {
                Message = "This is a mock account opening",
                InError = false
            });
        }

        public Task<FunctionResponse> DepositMoney(HttpClient httpClient, string accountnumber, MoneyDepositData payload)
        {
            return Task<FunctionResponse>.FromResult(new FunctionResponse()
            {
                Message = "This is a mock deposit",
                InError = false
            });
        }

        public Task<ProjectionFunctionResponse> WithdrawMoney(HttpClient httpClient, string accountnumber, MoneyWithdrawnData payload)
        {
            return Task<ProjectionFunctionResponse>.FromResult(new ProjectionFunctionResponse()
            {
                Message = "This is a mock withdrawal",
                InError = false
            });
        }

        public Task<FunctionResponse> SetOverdraft(HttpClient httpClient, string accountnumber, OverdraftSetData payload)
        {
            return Task<FunctionResponse>.FromResult(new FunctionResponse()
            {
                Message = "This is a mock overdraft",
                InError = false
            });
        }
    }
}
