using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            //TestPerson();
            //TestOneToMany();
           // TestManyToMany();
        }
        static void TestManyToMany()
        {
            Console.WriteLine("Many to many");
            using (Model1Container context = new Model1Container())
            {
                Console.WriteLine("Artist Nume");
                String FName = Console.ReadLine();
                Console.WriteLine("Artist Prenume");
                String LName = Console.ReadLine();
                Artist x = new Artist()
                {
                    FirstName = FName,
                    LastName = LName
                };
                Console.WriteLine("Album = ");
                String AName = Console.ReadLine();

                Album a = new Album()
                {
                    AlbumName = AName
                };

                context.Artists.Add(x);
                context.Albums.Add(a);

                context.SaveChanges();

                var items = context.Albums;
                foreach (var ox in items)
                {
                    Console.WriteLine("\tAlbums: {0}, {1}", ox.AlbumId, ox.AlbumName);
                }

                var items2 = context.Artists;

                foreach (var ox in items2)
                {
                    Console.WriteLine("\tArtists: {0}, {1}", ox.FirstName, ox.LastName);
                }


            }
        }
            static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                for (; ; )
                {
                    Console.Write("First Name:\t");
                    string first = Console.ReadLine();
                    Console.Write("Middle Name:\t");
                    string middle = Console.ReadLine();
                    Console.Write("Last Name:\t");
                    string last = Console.ReadLine();
                    Console.Write("Phone number:\t");
                    string phone = Console.ReadLine();

                    Person p = new Person()
                    {
                        FirstName = first,
                        LastName = last,
                        MiddleName = middle,
                        TelephoneNumber = phone
                    };
                    context.People.Add(p);
                    context.SaveChanges();
                    var items = context.People;
                    foreach (var x in items)
                        Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                }
            }
        }
        static void TestOneToMany()
        {
            Console.WriteLine("OneToMany");
            using (Model1Container context = new Model1Container())
            {
                for (; ; )
                {
                    Console.Write("Customer Name:\t");
                    string name = Console.ReadLine();
                    Console.Write("City:\t");
                    string city = Console.ReadLine();

                    Customer c = new Customer()
                    {
                        Name = name,
                        City = city
                    };
                    Order o1 = new Order()
                    {
                        TotalValue = 200,
                        Date = DateTime.Now,
                        Customer = c
                    };
                    Order o2 = new Order()
                    {
                        TotalValue = 300,
                        Date = DateTime.Now,
                        Customer = c
                    };
                    context.Customers.Add(c);
                    context.Orders.Add(o1);
                    context.Orders.Add(o2);
                    context.SaveChanges();

                    var items = context.Customers;

                    foreach (var x in items)
                    {
                        Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                        foreach (var ox in x.Orders)
                        {
                            Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue);
                        }
                    }

                }

            }

        }
















    }
}