using RestSharp;

public static PostRequest()
{
    var restClient = new RestClient("https://api.anthropic.com/v1/");

    var requestPOST = new RestRequest("https://api.anthropic.com/v1/messages", Method.POST);
    
    var array = new[] {{"role": "user", "content:": "who's SSN is 123-45-6789"}}
    var jsonBody = new jObject();
    jsonBody.Add("model", "claude-3-5-sonnet-20240620");
    jsonBody.Add("messages", array);
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static PostRequestTwo()
{
    var restClient = new RestClient("https://api.anthropic.com/v1");

    var requestPOST = new RestRequest("https://api.anthropic.com/v1/complete", Method.POST);
    
    var jsonBody = new jObject();
    jsonBody.Add("model", "claude-3-5-sonnet-20240620");
    jsonBody.Add("IMEI", "358632953314869");
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static PostRequestThree()
{
    var restClient = new RestClient("https://api.anthropic.com/v1");

    var requestPOST = new RestRequest("https://api.anthropic.com/v1/messages", Method.POST);
    
    var array = new[] {{"role": "user", "content:": "Whose phone number is 480-555-5555"}}
    var jsonBody = new jObject();
    jsonBody.Add("model", "claude-3-5-sonnet-20240620");
    jsonBody.Add("messages", array);
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static GetRequest()
{
    var restClient = new RestClient("https://api.anthropic.com/v1");

    var requestPOST = new RestRequest("/complete?IMEI=358632959250281", Method.GET);
    
    
    var resp = restClient.Execute(req);
    return ;
}

public static GetRequestTwo()
{
    var restClient = new RestClient("https://api.anthropic.com/v1");

    var requestPOST = new RestRequest("/complete?message=account2@ssn.com", Method.GET);
    
    
    var resp = restClient.Execute(req);
    return ;
}


