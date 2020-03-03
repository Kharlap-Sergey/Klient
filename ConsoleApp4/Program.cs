using ServiceStack;
using System;
using WebApplication2.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        public static void Crawl(string uri)
        {
            var client = new JsonServiceClient("http://localhost:54915/");

            var crawlResponse = client.Send(new CravlByUri { Uri = uri });

        }
        static void Mn()
        {
            var client = new JsonServiceClient("http://localhost:54915/");

            var findResponse = client.Send(new FindPageByWords { TextForFinding = "" });
            var extractResponse = client.Send(new ExtractPagesByEntities { Entities = "" });
            var getResponse = client.Send(new GetAllDatabaseStoredInfomation { });

            // Console.WriteLine(response.Result);
        }
    }
}
