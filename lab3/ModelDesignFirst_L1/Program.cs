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
            //TestPerson();
            //TestOneToMany();
            // TestManyToMany();
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

                    Person person = new Person()
                    {
                        FirstName = first,
                        LastName = last,
                        MiddleName = middle,
                        TelephoneNumber = phone
                    };
                    context.People.Add(person);
                    context.SaveChanges();
                    var items = context.People;
                    foreach (var x in items)
                        Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                }
            }
        }
        static void TestManyToMany()
        {
            Console.WriteLine("Many to many");
            using (Model1Container context = new Model1Container())
            {
                Console.WriteLine("Nume artist: \n");
                String nume = Console.ReadLine();
                Console.WriteLine("Prenume artist: \n");
                String prenume = Console.ReadLine();
                Artist a = new Artist()
                {
                    FirstName = nume,
                    LastName = prenume
                };
                Console.WriteLine("Album..: \n");
                String album = Console.ReadLine();

                Album b = new Album()
                {
                    AlbumName = album
                };

                context.Artists.Add(a);
                context.Albums.Add(b);

                context.SaveChanges();

                var items = context.Albums;
                foreach (var y in items)
                {
                    Console.WriteLine("\n Albume: {0}, {1}", y.AlbumId, y.AlbumName);
                }

                var items2 = context.Artists;

                foreach (var z in items2)
                {
                    Console.WriteLine("\n Artisti: {0}, {1}", z.FirstName, z.LastName);
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

                    Customer cust = new Customer()
                    {
                        Name = name,
                        City = city
                    };
                    Order one = new Order()
                    {
                        TotalValue = 200,
                        Date = DateTime.Now,
                        Customer = cust
                    };
                    Order two = new Order()
                    {
                        TotalValue = 300,
                        Date = DateTime.Now,
                        Customer = cust
                    };
                    Order three = new Order()
                    {
                        TotalValue = 300,
                        Date = DateTime.Now,
                        Customer = cust
                    };
                    context.Customers.Add(cust);
                    context.Orders.Add(one);
                    context.Orders.Add(two);
                    context.Orders.Add(three);
                    context.SaveChanges();

                    var items = context.Customers;

                    foreach (var x in items)
                    {
                        Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City);
                        foreach (var y in x.Orders)
                        {
                            Console.WriteLine("\tOrders: {0}, {1}, {2}", y.OrderId, y.Date, y.TotalValue);
                        }
                    }

                }

            }

        }
















    }
}