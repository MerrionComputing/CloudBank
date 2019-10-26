using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Web;
using System.Linq;

namespace CloudBank.RetailBank
{
    public class RetailBankApiNoHttp
        : IRetailBankApi
    {

        private ApiCommand[] _commands;
        /// <summary>
        /// Inistialise the API connection that will be used to perform the bank account functions
        /// </summary>
        public void Initialise(ApiCommand[] commands)
        {
            _commands = commands;
        }

        /// <summary>
        /// Get the current balance of an account 
        /// </summary>
        public async Task<ProjectionFunctionResponse> GetAccountBalance(HttpClient httpclient, string accountnumber)
        {
            if (null != httpclient)
            {

                string key = "";
                key = _commands.FirstOrDefault(f => f.CommandName == "Get Balance")?.ApiKey;

                HttpRequestMessage message = new HttpRequestMessage()
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(RetailBankApi.GetBase(), RetailBankApi.GetBalance(accountnumber, key))
                };


                var response = await httpclient.SendAsync(message);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString= await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ProjectionFunctionResponse>(jsonString); 
                }
                else
                {
                    return new ProjectionFunctionResponse() { Message = $"Unable to get balance - {response.StatusCode}", InError = true };
                }
            }

            return new ProjectionFunctionResponse() { Message = $"Not connected to retail bank API", InError = true };
        }

        /// <summary>
        /// Open a new account
        /// </summary>
        public async Task<FunctionResponse> OpenAccount(HttpClient httpClient,
            string accountnumber,
            AccountOpeningData payload)
        {
            if (null != httpClient)
            {

                string key = "";

                key = _commands.FirstOrDefault(f => f.CommandName == "Open Account")?.ApiKey;

                Uri postTarget = new Uri(RetailBankApi.GetBase(), RetailBankApi.OpenAccount(accountnumber, key));

                string jsonContent = JsonConvert.SerializeObject(payload);
                // Turn the payload into a JSON 
                // var content = new StringContent()); ;
                var content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(jsonContent));
                content.Headers.ContentType = new MediaTypeHeaderValue(RetailBankApi.PAYLOAD_TYPE);

                var response = await httpClient.PostAsync(postTarget, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<FunctionResponse>(jsonString);
                }
                else
                {
                    return new FunctionResponse() { Message = $"Unable to open an account - {response.StatusCode}", InError = true };
                }
            }

            return new FunctionResponse() { Message = $"Not connected to retail bank API", InError = true };
        }

        public async Task<FunctionResponse> DepositMoney(HttpClient httpClient, string accountnumber, MoneyDepositData payload)
        {
            if (null != httpClient)
            {

                string key = "";

                key = _commands.FirstOrDefault(f => f.CommandName == "Deposit Money")?.ApiKey;

                Uri postTarget = new Uri(RetailBankApi.GetBase(), RetailBankApi.DepositMoney (accountnumber, key));

                string jsonContent = JsonConvert.SerializeObject(payload);
                // Turn the payload into a JSON 
                var content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(jsonContent));
                content.Headers.ContentType = new MediaTypeHeaderValue(RetailBankApi.PAYLOAD_TYPE);

                var response = await httpClient.PostAsync(postTarget, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<FunctionResponse>(jsonString);
                }
                else
                {
                    return new FunctionResponse() { Message = $"Unable to deposit money - {response.StatusCode}", InError = true };
                }
            }

            return new FunctionResponse() { Message = $"Not connected to retail bank API", InError = true };
        }

        public async Task<ProjectionFunctionResponse> WithdrawMoney(HttpClient httpClient, string accountnumber, MoneyWithdrawnData payload)
        {
            if (null != httpClient)
            {

                string key = "";

                key = _commands.FirstOrDefault(f => f.CommandName == "Withdraw Money")?.ApiKey;

                Uri postTarget = new Uri(RetailBankApi.GetBase(), RetailBankApi.WithdrawMoney(accountnumber, key));

                string jsonContent = JsonConvert.SerializeObject(payload);
                // Turn the payload into a JSON 
                var content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(jsonContent));
                content.Headers.ContentType = new MediaTypeHeaderValue(RetailBankApi.PAYLOAD_TYPE);

                var response = await httpClient.PostAsync(postTarget, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ProjectionFunctionResponse>(jsonString);
                }
                else
                {
                    return new ProjectionFunctionResponse() { Message = $"Unable to withdraw money - {response.StatusCode}", InError = true };
                }
            }

            return new ProjectionFunctionResponse() { Message = $"Not connected to retail bank API", InError = true };
        }

        public async Task<FunctionResponse> SetOverdraft(HttpClient httpClient, string accountnumber, OverdraftSetData payload)
        {
            if (null != httpClient)
            {

                string key = "";

                key = _commands.FirstOrDefault(f => f.CommandName == "Set Overdraft")?.ApiKey;

                Uri postTarget = new Uri(RetailBankApi.GetBase(), RetailBankApi.SetOverdraft(accountnumber, key));

                string jsonContent = JsonConvert.SerializeObject(payload);
                // Turn the payload into a JSON 
                var content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(jsonContent));
                content.Headers.ContentType = new MediaTypeHeaderValue(RetailBankApi.PAYLOAD_TYPE);

                var response = await httpClient.PostAsync(postTarget, content);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<FunctionResponse>(jsonString);
                }
                else
                {
                    return new FunctionResponse() { Message = $"Unable to set overdraft - {response.StatusCode}", InError = true };
                }
            }

            return new FunctionResponse() { Message = $"Not connected to retail bank API", InError = true };
        }
    }
}
