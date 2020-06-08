using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace ORArequester
{
    public class Response
    {
        public int count { get; set; }
        public List<string> items { get; set; }
    }
    public class RootObject
    {
        public Response response { get; set; }
    }
    class Program
    {
        static readonly string token = "&access_token=eddd8bfec93129b8b45d8f388a4b716b469c085a9e37d0a0779d6b0d6ec55b6773e88987fe57c25d2667e";
        static readonly string groupWithRequests = "?group_id=169786518";
        static readonly string originalGroup = "?group_id=101489525";
        static readonly string address = "https://api.vk.com/method/groups.";
        static readonly string ver = "&v=5.103";


        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            while (true)
            {
                try
                {
                    System.Threading.Thread.Sleep(334);
                    WebRequest request = WebRequest.Create(address + "getRequests" + groupWithRequests + token + ver);
                    WebResponse response = request.GetResponse();
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    RootObject requests = JsonConvert.DeserializeObject<RootObject>(readStream.ReadToEnd());
                    response.Close();



                    if (requests.response.items[0] != "")
                    {
                        List<string> hbaids = new List<string>();

                        RootObject members;
                        do
                        {
                            System.Threading.Thread.Sleep(334);
                            request = WebRequest.Create(address + "getMembers" + originalGroup + "&sort=id_asc&offset=" + Convert.ToString(hbaids.Count) + token + ver);
                            response = request.GetResponse();

                            receiveStream = response.GetResponseStream();
                            readStream = new StreamReader(receiveStream, Encoding.UTF8);
                            members = JsonConvert.DeserializeObject<RootObject>(readStream.ReadToEnd());

                            hbaids.AddRange(members.response.items);

                            response.Close();
                        }
                        while (hbaids.Count < members.response.count);
        
                        for (int i = 0; i < requests.response.items.Count; i++)
                        {
                            for (int j = 0; j < hbaids.Count; j++)
                            {
                                if (requests.response.items[i] == hbaids[j])
                                {
                                    System.Threading.Thread.Sleep(334);
                                    Console.WriteLine("normas");
                                    request = WebRequest.Create(address + "approveRequest" + groupWithRequests + "&user_id=" + requests.response.items[i] + token + ver);
                                    response = request.GetResponse();
                                    response.Close();
                                    break;
                                }
                                if (j == hbaids.Count - 1)
                                {
                                    Console.WriteLine("ne normas");
                                    request = WebRequest.Create(address + "removeUser" + groupWithRequests + "&user_id=" + requests.response.items[i] + token + ver);
                                    response = request.GetResponse();
                                    response.Close();
                                }
                            }
                        }
                    }
                }
                catch { continue; }
            }
        }
    }
}