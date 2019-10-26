using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudBank.RetailBank
{

    public interface IRetailBankApi
    {

        // Initialise from a configuration source
        void Initialise(ApiCommand[] commands);

        // Queries : 1 - Get Account Balance
        Task<ProjectionFunctionResponse> GetAccountBalance(HttpClient httpclient, string accountnumber);

        // Commands : 
        // 1 - Open Account
        Task<FunctionResponse> OpenAccount(HttpClient httpClient, string accountnumber, AccountOpeningData payload);

        // 2 - Deposit Money
        Task<FunctionResponse> DepositMoney(HttpClient httpClient, string accountnumber, MoneyDepositData  payload);

        // 3 - Withdraw money
        Task<ProjectionFunctionResponse> WithdrawMoney(HttpClient httpClient, string accountnumber, MoneyWithdrawnData  payload);

        // 4 - Set new overdraft
        Task<FunctionResponse> SetOverdraft(HttpClient httpClient, string accountnumber, OverdraftSetData  payload);
    }
}
