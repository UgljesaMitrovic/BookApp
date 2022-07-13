using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;


namespace BookApp
{
    class Program
    {

        static async Task Main(string[] args)
        {
            var service = new Service();

            var root = await service.GetData("https://api.actionnetwork.com/web/v1/books");


            var q = from book in root.Books
                    where book.ParentName != null && book.Meta.States.Exists(el => el == "CO" || el == "NJ")
                    group book by book.ParentName into g
                    orderby g.Key.Substring(0, 1)
                    select g;


            using (StreamWriter writer = new StreamWriter("books.txt", false))
            {
                foreach (var group in q)
                {
                    writer.WriteLine(group.Key);
                    foreach (Book i in group)
                    {
                        writer.Write(i.DisplayName);
                        foreach (string state in i.Meta.States)
                            writer.Write(", " + state);
                        writer.Write("\n");
                    }
                    writer.Write("\n");
                }
            }
        }
    }
}
