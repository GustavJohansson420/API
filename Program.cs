using Newtonsoft.Json;
using RestSharp;

var client = new RestClient("http://adressen");
            var request = new RestRequest("/", Method.Get);
            RestResponse response = client.Execute(request);
            String content = response.Content;
Root menu = JsonConvert.DeserializeObject<Root>(content); // Byt ut till er eget huvudobjekt
public class Geometry
    {
        public string type { get; set; }
        public List<List<double>> coordinates { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string levelType { get; set; }
        public int level { get; set; }
        public string unit { get; set; }
        public List<double> values { get; set; }
    }

    public class Root
    {
        public DateTime approvedTime { get; set; }
        public DateTime referenceTime { get; set; }
        public Geometry geometry { get; set; }
        public List<TimeSeries> timeSeries { get; set; }
    }

    public class TimeSeries
    {
        public DateTime validTime { get; set; }
        public List<Parameter> parameters { get; set; }
    }

