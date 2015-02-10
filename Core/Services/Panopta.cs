using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Panappta.Debug;

namespace Panappta.Core.Services {
    /// <summary>
    /// Downloads and parses out JSON for Panopta using the API Key. 
    /// </summary>
    public class Panopta {
        const string ApiKey = "APIKEYGOESHERE";
        const string Url = "https://api2.panopta.com/v2/outage/active?limit=0&offset=0&api_key=";
        public RootObject ParsePanopta() {
            string data = GetData; // Downloads and returns the json data 
            RootObject o = JsonConvert.DeserializeObject<RootObject>(data); // Deserialize the data  

            return o;
        }

        string GetData {
            get {
                string oData;

                Log.Add("PanoptaJSON", "GetData", "Downloading string from {0}{1}...", Url, "812....");

                try {
                    oData = new System.Net.WebClient().DownloadString(Url + ApiKey);
                } catch (Exception e) {
                    Console.WriteLine("Error: {0}", e.Message);
                    Log.Add("PanoptaJSON", "GetData", "Error Occurred: ", e.Message);
                    oData = string.Empty;
                }

                return oData;
            }
        }

    }

    /// <summary>
    /// Json parsed data
    /// </summary>
    public class NetworkServiceTypeList {
        public object end_time { get; set; }
        public bool exclude_from_availability { get; set; }
        public string metadata { get; set; }
        public string network_service { get; set; }
        public string service_type { get; set; }
        public string start_time { get; set; }
        public string status { get; set; }
    }

    public class OutageList {
        public object compound_service { get; set; }
        public object end_time { get; set; }
        public bool exclude_from_availability { get; set; }
        public string hash { get; set; }
        public List<NetworkServiceTypeList> network_service_type_list { get; set; }
        public string server { get; set; }
        public string server_fqdn { get; set; }
        public string server_name { get; set; }
        public string start_time { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class RootObject {
        [JsonProperty("outage_list")]
        public List<OutageList> outage_list { get; set; }
    }
}
