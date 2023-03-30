using Newtonsoft.Json;
using RestSharp;

var client = new RestClient("https://www.boredapi.com/api/activity");
            var request = new RestRequest("/", Method.Get);
            RestResponse response = client.Execute(request);
            String content = response.Content;
Root menu = JsonConvert.DeserializeObject<Root>(content); // Byt ut till er eget huvudobjekt

Console.WriteLine(menu.activity);

    public class Root
    {
        public string activity { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public float price { get; set; }
        public string link { get; set; }
        public string key { get; set; }
        public double accessibility { get; set; }
    }

