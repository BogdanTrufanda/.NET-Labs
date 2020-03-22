using EF_StudiiDeCaz.Model;
using System.Linq;
using System;
using ConsoleApp1.Model;

namespace EF_StudiiDeCaz
{
    class Program
    {
        public static void P1()
        {
            using (var databasecon = new ModelSelfReferences())
            {
                var name = new Model.SelfReference { Name = "Robert" };
                databasecon.SelfReferences.Add(name);
                databasecon.SaveChanges();
                Console.WriteLine("\n");
                var qry = from element in databasecon.SelfReferences
                          select element;
                Console.WriteLine("Database has: \n");

                foreach (var x in qry)
                {
                    Console.WriteLine(x.Name);
                }
                Console.WriteLine("\nPress Key to exit...");
                Console.ReadKey();
            }

        }

        public static void P2Create()
        {
            using (var context = new ProductContext())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product { SKU = 178, Description = "Rugged Ranger Duffel Bag", Price = 39.97M, ImageURL = "/pack178.jpg" };
                context.Products.Add(product);
                product = new Product { SKU = 186, Description = "Range Field Pack", Price = 98.97M, ImageURL = "/noimage.jp" };
                context.Products.Add(product);
                product = new Product { SKU = 202, Description = "Small Deployment Back Pack", Price = 29.97M, ImageURL = "/pack202.jpg" };
                context.Products.Add(product);
                context.SaveChanges();
            }



        }
        public static void P2()
        {
            using (var context = new ProductContext())
            {
                foreach (var x in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", x.SKU, x.Description, x.Price.ToString("C"), x.ImageURL);
                }
            }
        }






        static void Main(string[] args)
        {
            //P2();

            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new PhotographFullImage())
            {
                var photo = new Photograph { Title = "My Dog", ThumbnailBits = thumbBits };
                varfullImage = new PhotographFullImage { HighResolutionBits = fullBits };
                photo.PhotographFullImage = fullImage; context.Photographs.Add(photo);
                context.SaveChanges();
            }

            using (var context = new ...Context()){
                foreach (var photo in context.Photographs)
                {
                    Console.WriteLine("Photo: {0}, ThumbnailSize {1} bytes",
                photo.Title, photo.ThumbnailBits.Length);// explicitly load the "expensive" entity,context.Entry(photo).Reference(p => p.PhotographFullImage).Load();Console.WriteLine("Full Image Size: {0} bytes",photo.PhotographFullImage.HighResolutionBits.Length);}}




                }
            }
        }