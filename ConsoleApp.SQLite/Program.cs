using System;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StoreContext())
            {
                db.Stores.Add(new Store { Url = "http://williamdnapier.github.io"});
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to the database", count);

                Console.WriteLine();
                Console.WriteLine("All stores in database:");
                foreach(var store in db.Stores)
                {
                    Console.WriteLine(" - {0}", store.Url);
                }
            }
        }
    }
}
