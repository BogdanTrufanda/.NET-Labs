using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModelCodeFirst.Model.Model1;

namespace ModelCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var database = new AlbumsContext())
            {
                var albums = new Album { AlbumName = "Album nou" };
                database.Albums.Add(albums);
                database.SaveChanges();

                var qry = from x in database.Albums
                            select x;
                Console.WriteLine("Database albums");
                foreach (var x in qry)
                {
                    Console.WriteLine(x.AlbumName);
                }
                Console.WriteLine("Press to exit..");
                Console.ReadKey();
            }
        }
    }


}