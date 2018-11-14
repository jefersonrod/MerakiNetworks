using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestSharp;

namespace MerakiNetwork
{
	class GetMerakiNetworks
	{

		public static void Main()
		{
			//Console.WriteLine("Hello");
			//MessageBox.Show("Hello");
			//Console.ReadKey();

            var client = new RestClient("https://api.meraki.com/api/v0/organizations/630040/networks");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "3e3ad583-140b-7cf8-ffcd-5f73b7d9f945");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-cisco-meraki-api-key", "27908cdce0c4a377ce4ae03b4e9fa4bf196f5e83");
            IRestResponse response = client.Execute(request);
		}	
	}
}