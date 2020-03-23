using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            TestManyToMany();
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

                Console.WriteLine("Nume artist: ");
                String nume = Console.ReadLine();
                Console.WriteLine("Prenume artist: ");
                String prenume = Console.ReadLine();
                Console.WriteLine("Album: ");
                String album = Console.ReadLine();
                Album b = new Album()
                {
                    AlbumName = album
                };
                context.Albums.Add(b);

                ICollection<Album> albume = new Collection<Album>();
                albume.Add(b);
                Artist a = new Artist()
                {
                    FirstName = nume,
                    LastName = prenume,
                    Albums = albume
                };

                context.Artists.Add(a);
                context.SaveChanges();

                var items = context.Artists;
                foreach (var x in items)
                {
                    Console.WriteLine("Artist: {0} {1}", x.FirstName, x.LastName);
                    foreach (var y in x.Albums)
                        Console.WriteLine("Album: {0}", y.AlbumName);
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