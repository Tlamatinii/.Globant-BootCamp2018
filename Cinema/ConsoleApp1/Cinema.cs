using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Cinema
    {
        public static void Main(string[] args)
        {
            beginning:

            //Creacion de querys.
            List<Seats> seatings = new List<Seats>()
        {
            new Seats {status="Available",
            columnPlace="Left",
            rowPlace="Front",
            ID=01,
            price=90},

            new Seats {status="Available",
            columnPlace="Center",
            rowPlace="Front",
            ID=02,
            price=90 },

            new Seats {status="Available",
            columnPlace="Right",
            rowPlace="Front",
            ID=03,
            price=100 },

            new Seats {status="Available",
            columnPlace="Left",
            rowPlace="Center",
            ID=04,
            price=110 },

            new Seats {status="Available",
            columnPlace="Center",
            rowPlace="Center",
            ID=05,
            price=120 },

            new Seats {status="Available",
            columnPlace="Right",
            rowPlace="Center",
            ID=06,
            price=110 },

            new Seats {status="Available",
            columnPlace="Left",
            rowPlace="Back",
            ID=07,
            price=100  },

            new Seats {status="Available",
            columnPlace="Center",
            rowPlace="Back",
            ID=08,
            price=110  },

            new Seats {status="Available",
            columnPlace="Right",
            rowPlace="Back",
            ID=09,
            price=100  },
        };

            List<Customer> data = new List<Customer>();

            List<Movie> movies = new List<Movie>(){
                new Movie {Name="Ganas de Matar",
                    Genre="Action",
                    Restr=18 },

                new Movie{ Name = "Detras",
                    Genre = "Suspense",
                    Restr = 18 },

                new Movie{Name = "Wiiii",
                    Genre = "Animated",
                    Restr = 7 },
            };

            //Primera parte

            Console.WriteLine("Press the button indicated below to continue: ");
            Console.WriteLine("A-See cinema listings");
            Console.WriteLine("B-Buy a ticket");
            Console.WriteLine("C-Help");
            Console.WriteLine("D-Exit");

            var seatsAvailable =
                (from Seats in seatings
                 where Seats.status == "Available"
                 select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price));

            var movieInformation =
                (from Movie in movies
                 select (Movie.Name, Movie.Genre, Movie.Restr));

            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);

 
            if (cki.Key == ConsoleKey.A)
            {
                foreach (var inf in movieInformation)
                {
                    Console.WriteLine(inf);                   
                }
                goto beginning;
            }

            if (cki.Key == ConsoleKey.B)
            {
                Console.WriteLine("How old are you? ");
                string UserInput = Console.ReadLine();
                int x = Convert.ToInt32(UserInput);
                
                if (x >= 18)
                {
                    x = 0;
                    Console.Clear();
                    Console.WriteLine("What movie you want to see?");
                    Console.WriteLine("1-Ganas de matar");
                    Console.WriteLine("2-Detras");
                    Console.WriteLine("3-Wiiii");
                    ConsoleKeyInfo cki2;
                    cki2 = Console.ReadKey(true);

                    if (cki2.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine("Available seats: ");

                        foreach (var sit in seatsAvailable)
                        {
                            Console.WriteLine(sit);
                        }

                        ConsoleKeyInfo cki3;
                        Console.WriteLine("Choose your seats:");
                        Console.WriteLine("Press O to order by price");
                        do
                        {
                            cki3 = Console.ReadKey(true);
                            if (cki3.Key == ConsoleKey.O)
                            {
                                Console.Clear();

                                var orderPrice =
                                    (from Seats in seatings
                                     where Seats.status == "Available"
                                     orderby Seats.price descending
                                     select (Seats.ID,Seats.columnPlace,Seats.rowPlace,Seats.price)
                                    );

                                foreach(var pri in orderPrice)
                                {
                                    Console.WriteLine(pri);                                  
                                }

                                Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                
                                do
                                {
                                    cki3 = Console.ReadKey(true);
                                    if (cki3.Key == ConsoleKey.NumPad1)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 01
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad2)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 02
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad3)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 03
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad4)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 04
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad5)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 05
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad6)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 06
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad7)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 07
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad8)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 08
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad9)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 09
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                } while (cki3.Key != ConsoleKey.Escape);
                            }
                            if (cki3.Key == ConsoleKey.NumPad1)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 01
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad2)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 02
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad3)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 03
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad4)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 04
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad5)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 05
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad6)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 06
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad7)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 07
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad8)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 08
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad9)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 09
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                        } while (cki3.Key != ConsoleKey.Escape);

                        Console.Clear();

                        var seatsOccupied =
                            from Seats in seatings
                             where Seats.status == "Occupied"
                             select (Seats.ID,Seats.columnPlace, Seats.rowPlace, Seats.price);

                        var prices =
                            from Seats in seatings
                            where Seats.status == "Occupied"
                            group Seats by Seats.status into prices3
                            select new
                            {
                               TotalPrice = prices3.Sum(x1 => x1.price),
                            };


                        foreach (var info in seatsOccupied)
                        {
                            Console.WriteLine(info);
                          
                        }

                        foreach (var pri in prices)
                        {
                            Console.WriteLine(pri);

                        }

                        
                        Console.WriteLine("Proceed? Y/N");
                        ConsoleKeyInfo ckiFinal;
                        ckiFinal = Console.ReadKey(true);

                        if (ckiFinal.Key == ConsoleKey.Y)
                        { 
                            Console.WriteLine("Thanks for your purchase, enjoy the movie");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }


                    }
                    if (cki2.Key == ConsoleKey.NumPad2)
                    {
                        Console.WriteLine("Available seats: ");
                        foreach (var sit in seatsAvailable)
                        {
                            Console.WriteLine(sit);
                        }

                            ConsoleKeyInfo cki3;
                            Console.WriteLine("Choose your seats:");
                            Console.WriteLine("Press O to order by price");
                            do
                            {
                                cki3 = Console.ReadKey(true);
                                if (cki3.Key == ConsoleKey.O)
                                {
                                    Console.Clear();

                                    var orderPrice =
                                        (from Seats in seatings
                                         where Seats.status == "Available"
                                         orderby Seats.price descending
                                         select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price)
                                        );

                                    foreach (var pri in orderPrice)
                                    {
                                        Console.WriteLine(pri);
                                    }

                                    Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");

                                    do
                                    {
                                        cki3 = Console.ReadKey(true);
                                        if (cki3.Key == ConsoleKey.NumPad1)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 01
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad2)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 02
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad3)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 03
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad4)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 04
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad5)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 05
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad6)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 06
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad7)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 07
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad8)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 08
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad9)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 09
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                    } while (cki3.Key != ConsoleKey.Escape);
                                }
                                if (cki3.Key == ConsoleKey.NumPad1)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 01
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad2)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 02
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad3)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 03
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad4)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 04
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad5)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 05
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad6)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 06
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad7)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 07
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad8)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 08
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad9)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 09
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                            } while (cki3.Key != ConsoleKey.Escape);
                        
                        Console.Clear();

                        var seatsOccupied =
                            (from Seats in seatings
                             where Seats.status == "Occupied"
                             select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price));

                        var prices =
                            from Seats in seatings
                            where Seats.status == "Occupied"
                            group Seats by Seats.status into prices3
                            select new
                            {
                                TotalPrice = prices3.Sum(x1 => x1.price),
                            };


                        foreach (var info in seatsOccupied)
                        {
                            Console.WriteLine(info);

                        }

                        foreach (var pri in prices)
                        {
                            Console.WriteLine(pri);

                        }

                        
                        Console.WriteLine("Proceed? Y/N");
                        ConsoleKeyInfo ckiFinal;
                        ckiFinal = Console.ReadKey(true);
                    }
                    if (cki2.Key == ConsoleKey.NumPad3)
                    {
                        Console.WriteLine("Available seats: ");
                        foreach (var sit in seatsAvailable)
                        {
                            Console.WriteLine(sit);
                        }

                            ConsoleKeyInfo cki3;
                            Console.WriteLine("Choose your seats:");
                            Console.WriteLine("Press O to order by price");
                            do
                            {
                                cki3 = Console.ReadKey(true);
                                if (cki3.Key == ConsoleKey.O)
                                {
                                    Console.Clear();

                                    var orderPrice =
                                        (from Seats in seatings
                                         where Seats.status == "Available"
                                         orderby Seats.price descending
                                         select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price)
                                        );

                                    foreach (var pri in orderPrice)
                                    {
                                        Console.WriteLine(pri);
                                    }

                                    Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");

                                    do
                                    {
                                        cki3 = Console.ReadKey(true);
                                        if (cki3.Key == ConsoleKey.NumPad1)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 01
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad2)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 02
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad3)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 03
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad4)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 04
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad5)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 05
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad6)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 06
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad7)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 07
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad8)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 08
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                        if (cki3.Key == ConsoleKey.NumPad9)
                                        {
                                            var seatsAvailable2 = (from Seats in seatings
                                                                   where Seats.ID == 09
                                                                   select (Seats.status = "Occupied"))
                                                           .ToList();
                                            Console.Clear();
                                            foreach (var pri in orderPrice)
                                            {
                                                Console.WriteLine(pri);
                                            }
                                            Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                        }
                                    } while (cki3.Key != ConsoleKey.Escape);
                                }
                                if (cki3.Key == ConsoleKey.NumPad1)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 01
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad2)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 02
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad3)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 03
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad4)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 04
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad5)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 05
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad6)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 06
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad7)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 07
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad8)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 08
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                                if (cki3.Key == ConsoleKey.NumPad9)
                                {
                                    Console.Clear();
                                    var seatsAvailable2 = (from Seats in seatings
                                                           where Seats.ID == 09
                                                           select (Seats.status = "Occupied"))
                                                           .ToList();

                                    foreach (var Place in seatsAvailable)
                                    {
                                        Console.WriteLine(Place);
                                        Console.WriteLine("Tap Escape to continue");
                                    }
                                }
                            } while (cki3.Key != ConsoleKey.Escape);
                        
                        Console.Clear();

                        var seatsOccupied =
                            (from Seats in seatings
                             where Seats.status == "Occupied"
                             select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price));

                        var prices =
                            from Seats in seatings
                            where Seats.status == "Occupied"
                            group Seats by Seats.status into prices3
                            select new
                            {
                                TotalPrice = prices3.Sum(x1 => x1.price),
                            };


                        foreach (var info in seatsOccupied)
                        {
                            Console.WriteLine(info);

                        }

                        foreach (var pri in prices)
                        {
                            Console.WriteLine(pri);
                        }

                       
                        Console.WriteLine("Proceed? Y/N");
                        ConsoleKeyInfo ckiFinal;
                        ckiFinal = Console.ReadKey(true);
                    }
                }
                else
                {
                    Console.WriteLine("1-Wiiii");
                    ConsoleKeyInfo cki2;
                    cki2 = Console.ReadKey(true);
                    if (cki2.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine("Available seats: ");
                        foreach (var sit in seatsAvailable)
                        {
                            Console.WriteLine(sit);
                        }
                        ConsoleKeyInfo cki3;
                        Console.WriteLine("Choose your seats:");
                        Console.WriteLine("Press O to order by price");
                        do
                        {
                            cki3 = Console.ReadKey(true);
                            if (cki3.Key == ConsoleKey.O)
                            {
                                Console.Clear();

                                var orderPrice =
                                    (from Seats in seatings
                                     where Seats.status == "Available"
                                     orderby Seats.price ascending
                                     select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price)
                                    );

                                foreach (var pri in orderPrice)
                                {
                                    Console.WriteLine(pri);
                                }

                                Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");

                                do
                                {
                                    cki3 = Console.ReadKey(true);
                                    if (cki3.Key == ConsoleKey.NumPad1)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 01
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad2)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 02
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad3)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 03
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad4)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 04
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad5)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 05
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad6)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 06
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad7)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 07
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad8)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 08
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                    if (cki3.Key == ConsoleKey.NumPad9)
                                    {
                                        var seatsAvailable2 = (from Seats in seatings
                                                               where Seats.ID == 09
                                                               select (Seats.status = "Occupied"))
                                                       .ToList();
                                        Console.Clear();
                                        foreach (var pri in orderPrice)
                                        {
                                            Console.WriteLine(pri);
                                        }
                                        Console.WriteLine("Choose your seats whit the numPad or tap Escape to continue");
                                    }
                                } while (cki3.Key != ConsoleKey.Escape);
                            }
                            if (cki3.Key == ConsoleKey.NumPad1)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 01
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad2)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 02
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad3)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 03
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad4)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 04
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad5)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 05
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad6)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 06
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad7)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 07
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad8)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 08
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                            if (cki3.Key == ConsoleKey.NumPad9)
                            {
                                Console.Clear();
                                var seatsAvailable2 = (from Seats in seatings
                                                       where Seats.ID == 09
                                                       select (Seats.status = "Occupied"))
                                                       .ToList();

                                foreach (var Place in seatsAvailable)
                                {
                                    Console.WriteLine(Place);
                                    Console.WriteLine("Tap Escape to continue");
                                }
                            }
                        } while (cki3.Key != ConsoleKey.Escape);

                        Console.Clear();

                        var seatsOccupied =
                            from Seats in seatings
                            where Seats.status == "Occupied"
                            select (Seats.ID, Seats.columnPlace, Seats.rowPlace, Seats.price);


                        var prices =
                        from Seats in seatings
                        where Seats.status == "Occupied"
                        group Seats by Seats.status into prices3
                        select new
                        {                           
                            TotalPrice = prices3.Sum(x1 => x1.price),
                        };

                        foreach (var info in seatsOccupied)
                        {
                            Console.WriteLine(info);

                        }

                        foreach (var pri in prices)
                        {
                            Console.WriteLine(pri);
                        }

                        Console.WriteLine("Proceed? Y/N");
                        ConsoleKeyInfo ckiFinal;
                        ckiFinal = Console.ReadKey(true);

                        if (ckiFinal.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("Thanks for your purchase, enjoy the movie");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }

                    }
                }
            }

            if (cki.Key == ConsoleKey.C)
            {            
                    Console.WriteLine("Help isn´t available in this moment");
                goto beginning;
            }

            if (cki.Key == ConsoleKey.D)
            {
                System.Environment.Exit(-1);

            }


           

        }
    }
}
