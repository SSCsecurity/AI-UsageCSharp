using RestSharp;

public static PostRequest()
{
    var restClient = new RestClient("https://api.openai.com/v1");

    var requestPOST = new RestRequest("chat/completions", Method.POST);
    
    var array = new[] {{"role": "user", "content:": "who's SSN is 123-45-6789"}}
    var jsonBody = new jObject();
    jsonBody.Add("model", "gpt-4o-mini");
    jsonBody.Add("temperature", "0.7");
    jsonBody.Add("messages", array);
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static PostRequestTwo()
{
    var restClient = new RestClient("https://api.openai.com/v1");

    var requestPOST = new RestRequest("/files", Method.POST);
    
    var jsonBody = new jObject();
    jsonBody.Add("model", "gpt-3");
    jsonBody.Add("temperature", "0.8");
    jsonBody.Add("IMEI", "358632953314869");
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static PostRequestThree()
{
    var restClient = new RestClient("https://api.openai.com/v1");

    var requestPOST = new RestRequest("https://api.openai.com/v1/chat/completions", Method.POST);
    
    var array = new[] {{"role": "user", "content:": "Whose phone number is 480-555-5555"}}
    var jsonBody = new jObject();
    jsonBody.Add("model", "gpt-4");
    jsonBody.Add("temperature", "0.7");
    jsonBody.Add("messages", array);
    
    req.AddParameter("application/json",  jsonBody);
    
    var resp = restClient.Execute(req);
    return ;
}

public static GetRequest()
{
    var restClient = new RestClient("https://api.openai.com/v1");

    var requestPOST = new RestRequest("chat/completions?IMEI=358632959250281"", Method.GET);
    
    
    var resp = restClient.Execute(req);
    return ;
}

public static GetRequestTwo()
{
    var restClient = new RestClient("https://api.openai.com/v1");

    var requestPOST = new RestRequest("chat/completions?message=accountlead@dlptest.com", Method.GET);
    
    
    var resp = restClient.Execute(req);
    return ;
}


