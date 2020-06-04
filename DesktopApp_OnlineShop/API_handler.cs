using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp_OnlineShop
{
	public static class API_handler
	{
		struct API_response
		{
			public string StatusCode;
			public string Response;
		}


		static HttpClient client = new HttpClient();
		private static async void sender(string url, HttpMethod method, Dictionary<string, string> parameters)
		{
			try
			{
				using (var httpClient = client)
				{
					using (var request = new HttpRequestMessage(method, url))
					{
						request.Headers.TryAddWithoutValidation("accept", "*/*");
						string params_str = "{";
						foreach (KeyValuePair<string, string> keyValue in parameters)
						{
							Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
							params_str += " \"" + keyValue.Key + "\": \"" + keyValue.Value + "\",";
						}
						params_str = params_str.Remove(params_str.Length - 1);
						params_str += "}";

						request.Content = new StringContent(params_str);
						request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

						var response = await httpClient.SendAsync(request);

						var responseContent = await response.Content.ReadAsStringAsync();


						//Десериализация полученного json при помощи заранее созданного класса
						//var user = JsonConvert.DeserializeObject<User>(responseContent);



					}
				}


				//Outside.SelectedTab = mainTab;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
