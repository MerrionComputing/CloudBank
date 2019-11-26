# CloudBank

CloudBank is a demo front end to show how to put a Blazor UI front end over Azure functions using Event Sourcing for the data storage

This client side web application sends commands to the Bank Account **event sourcing** demo application which uses Azure Tables as the storage mechanism for the event streams underlying each bank account.

You can try it out from any modern web browser at [this URL](https://retailbank.z6.web.core.windows.net/)

## Using the application

![Cloudbank front screen](initial_screen.jpg)

When the application is launched the front screen as above is shown, with the navigation bar down the left hand side.  This is pretty much an out of the box standard Blazor site template.

### Creating a new account

Click on the **User** menu to go to the form that allows you to create a new bank account.  You can either type your own choice of bank account number of select the *generate random account number* button to have the system create one.

![Create new bank account](new_account.jpg)

Once you have created a new account you can navigate to it with the *navigate to {accountnumber}* button.

### Getting the account balance

To get the account balance select the first section and it will open up and the button *get balance* can be used to trigger the Azure function that gets the balance for this bank account. 
![Get account balance](get_balance.jpg)

Because the backing store is event sourced it is just as easy to get the state as at some past date as it is to get the current state so you can enter an *as of* date and the system will return the account balance as at that date.
![Account balance retrieved](got_balance.jpg)

### Making a deposit

The second expandable section allows you to make a deposit.
![Make a deposit](make_deposit.jpg)
There are parameters to fill in for the deposit amount, deposit source and any commentary and then pressing the *submit* button will pass these to the Azure function to make the deposit.

![Deposit made](made_deposit.jpg)
When a the deposit is made a message will indicate this.

### Making a withdrawal

The third expandable section is for making a withdrawal.
![Make withdrawal](make_withdrawal.jpg)
This has parameters for ammount and for commentary and again pressing the *submit* button sends these parameters to the Azure function.

![Made Withdrawal](made_withdrawal.jpg)
Because the fuunction to make a withdrawal needs to run a projection that checks the current balance (to prevent the account being overdrawn beyond its limit) this function also returns information about the account balance.

### Setting an overdraft

The lowest of the expandable section allows for an overdraft to be set.
![Setting an overdraft](set_new_overdraft.jpg)
Pressing the *submit* button having filled in all the parameters will pass these to the Azure function to execute them.

![Overdraft set](overdraft_limit_set.jpg)
Again, because this Azure function has to get the existing overdraft and balance for its validation it can return this information to the front end.

For every Azure function executed the system will also return the total time it took to execute the function and if the function also runs any projections over the event stream it will also return the **sequence number** of the last event read.

## How it works

The back end of this application is running as Azure serverless functions which are backed by **event sourcing** with the event streams for each account held in an Azure table.  This is described in [this GitHub project](https://github.com/MerrionComputing/EventsSourcing-on-Azure-Functions/wiki/Worked-Example-:-Bank-Account)

On the front end the Razor pages inject the standard http client and a **RetailBankApi** class which is used for all comminication with the Azure functions:

```csharp
@using CloudBank.Services


@page "/myaccount"
@page "/myaccount/{accountnumber}"

@inject HttpClient Http
@inject IRetailBankApi retailBankApi
```

This **RetailBankApi** class is injected into every page by use of dependency injection in the Startup.cs
```csharp
        public void ConfigureServices(IServiceCollection services)
        {
            // Modal forms
            services.AddBlazoredModal();

            // Bank account API
            services.AddScoped <IRetailBankApi, RetailBankApiNoHttp>();
        }
```

Behind the scenes the **RetailBankApiNoHttp** class loads the set of Azure functions from a configuration file called **bank-api.json** (which allows the application to have its back end changed without impacting the deployed front end) - this is loaded in the **MainLayout.razor** file:

```csharp
@code
{

    [Parameter]
    public ApiCommand[] apiCommands { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (null == apiCommands)
        {
            apiCommands = await Http.GetJsonAsync<ApiCommand[]>("sample-data/bank-api.json");
            if (null != apiCommands)
            {
                // fix up the rertail bank api with them...
                retailBankApi.Initialise(apiCommands);
            }
        }
    }
}
```

```csharp
```

To call these from the account actions razore page we have action code wired up for the submit button like:

```csharp
<button @onclick="@(() => GetBalance())" class="btn btn-secondary">
       <span class="oi oi-cloud-download" aria-hidden="true"></span>
        Get Balance
 </button>
```

When triggered this calls the Azure function thus:
```csharp
    private async Task GetBalance()
    {
        LastFunctionMessage = $"Getting balance for {accountnumber} at {getbalancePayload.AsOfDate}  ";

        try
        {
            var result = await retailBankApi.GetAccountBalance(Http, accountnumber, getbalancePayload);
            LastFunctionMessage = result.Message;
            LastRunTime = result.ExecutionTime;
            LastSequenceNumber = result.SequenceNumber;
        }
        catch (Exception ex)
        {
            LastFunctionMessage = ex.Message;
        }

    }
```

This sends the command to the Azure function by http:
```csharp
        /// <summary>
        /// Get the current balance of an account 
        /// </summary>
        public async Task<ProjectionFunctionResponse> GetAccountBalance(HttpClient httpclient, string accountnumber,  GetBalanceData payload)
        {
            if (null != httpclient)
            {

                string key = "";
                key = _commands.FirstOrDefault(f => f.CommandName == "Get Balance")?.ApiKey;

                HttpRequestMessage message = new HttpRequestMessage()
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(RetailBankApi.GetBase(), RetailBankApi.GetBalance(accountnumber, payload.AsOfDate , key))
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
```

## Deployment

Because this Blazor front end runs entirely on the client it can be hosted on a static website - and the 
