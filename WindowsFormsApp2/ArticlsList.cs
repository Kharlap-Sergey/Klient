using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace WindowsFormsApp2
{
    public static class ArticlsList
    {
        public static List<string> Articls = new List<string>();
        public static int Position;

        public static void Update()
        {
            Articls = OP.GetArticls();
            Position = 0;
        }
    }
}
