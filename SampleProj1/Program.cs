using System;
using System.Net;
using Newtonsoft.Json.Linq;

using (WebClient wc = new WebClient())
{
    var json = wc.DownloadString("https://api.coindesk.com/v1/bpi/currentprice.json");

    Console.WriteLine(json);

    JObject parsed = JObject.Parse(json);

    Console.WriteLine("Current rate of " + Convert.ToString(parsed["chartName"]) + " in " + Convert.ToString(parsed["bpi"]["EUR"]["code"]) + " is " + Convert.ToString(parsed["bpi"]["EUR"]["rate"]));
}


