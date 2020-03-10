using OrmLite.ServiceInterface;
using OrmLite.ServiceModel;
using ServiceStack;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
 
    public class OP
    {
        static string ClientConect = "http://localhost:50357/";
        public static void Crawl(string uri, int amountPages)
        {
            var client = new JsonServiceClient(ClientConect);
            client.SendAsync(new CravlByUri { Uri = uri, DeapValue = amountPages });

            while (!client.Send(new IsCrawlCompleted {PagesAmount = amountPages}))
            {
                System.Threading.Thread.Sleep(5000);
            }
            //client.SendOneWay(new CravlByUri { Uri = uri, DeapValue = 100});
        }

        public static void ExtractEntities()
        {
            var client = new JsonServiceClient(ClientConect);

            client.SendAsync(new ExtractEntities { });
            while (!client.Send(new IsExtractEntitiesCompleted {}))
            {
                System.Threading.Thread.Sleep(5000);
            }
        }

        public static List<string> FindByWord(string word)
        {
            var client = new JsonServiceClient(ClientConect);
            var Response = client.Send(new FindByWord { Word = word});
            return Response.Result; 
        }

        public static List<string> FindByEntity(string entity)
        {
            var client = new JsonServiceClient(ClientConect);
            var Response = client.Send(new FindByEntity { Entity = entity });
            return Response.Result;
        }
        public static void DeleteTabels()
        {
            var client = new JsonServiceClient(ClientConect);
            var Response = client.Send(new DeleteAllTable {});
        }

        public static List<string> GetArticls()
        {
            var client = new JsonServiceClient(ClientConect);
            var Response = client.Send(new GetArticls { });

            return Response.Result;
        }

        static void Main()
        {
            Console.WriteLine("doing");
            //Console.WriteLine(Crawl("https://belaruspartisan.by/politic/491685/"));
            Console.ReadLine();
        }
    }
}
