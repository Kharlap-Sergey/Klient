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
        public static string Crawl(string uri, int amointPages)
        {
            var client = new JsonServiceClient(ClientConect);

            var crawlResponse = client.Send(new CravlByUri { Uri = uri, DeapValue = amointPages});
            //client.SendOneWay(new CravlByUri { Uri = uri, DeapValue = 100});
            return crawlResponse.Result;
        }

        public static void ExtractEntities()
        {
            var client = new JsonServiceClient(ClientConect);

            var Response = client.Send(new ExtractEntities { });
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
        static void Main()
        {
            Console.WriteLine("doing");
            //Console.WriteLine(Crawl("https://belaruspartisan.by/politic/491685/"));
            Console.ReadLine();
        }
    }
}
