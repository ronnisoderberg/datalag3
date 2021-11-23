using DataLayer.Backend;
using DataLayer.Model;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var userBackend = new UserBackend();
            var adminBackend = new AdminBackend();
            var restaurantBackend = new RestaurantBackend();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pick option by type a number");
                Console.WriteLine("1 : Create database");
                Console.WriteLine("2 : Print or buy available foodpackages by category");
                Console.WriteLine("3 : Print all sold objects from restaurant");
                Console.WriteLine("4 : Add new foodpack as restaurant");
                Console.WriteLine("5 : Print all costumers");
                Console.WriteLine("6 : Ban costumer by username");
                Console.WriteLine("7 : See all restaurants & Add new");
                Console.WriteLine("8 : See monthly profit for a restaurant ");
                Console.WriteLine("9 : Lift a ban from costumer ");
                Console.WriteLine("10 : View food with attributes");

                var keyInfo = Console.ReadLine();

                if (keyInfo == "1")
                {
                    adminBackend.PrepDatabase();
                    Console.WriteLine("Database deleted and created.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "2")
                {
                    //foreach getcategory
                    Console.WriteLine("Type a number to select category: \n");
                    Console.WriteLine("1 : Meat\n");
                    Console.WriteLine("2 : Fish\n");
                    Console.WriteLine("3 : Veggie");

                    var categoryNumber = Console.ReadLine();
                    var categoryString = "";

                    if (categoryNumber == "1")
                    {
                        categoryString = "Meat";
                    }

                    if (categoryNumber == "2")
                    {
                        categoryString = "Fish";
                    }

                    if (categoryNumber == "3")
                    {
                        categoryString = "Veggie";
                    }

                    if (categoryNumber != "")
                    {
                        var foodlistToBuy = new List<Foodpackage>();
                        var foodlist = userBackend.GetFoodpackages(categoryString);
                        var ordermore = true;

                        while (ordermore)
                        {
                            Console.Clear();
                            Console.WriteLine("Available foodpacks: ");
                            var foodnumber = 1;

                            foreach (var f in foodlist)
                            {
                                Console.WriteLine($"Foodnumber: {foodnumber}\n" +
                                                  $"Description: {f.Description}\n" +
                                                  $"Price: {f.Price}\n" +
                                                  $"Expiredate: {f.ExpireDate.Date}\n" +
                                                  $"Restaurant: {f.Restaurant.Name}");

                                if (f.Foodattribute != null)
                                {
                                    Console.Write("Foodattribute: ");
                                    foreach (var a in f.Foodattribute)
                                    {
                                        Console.WriteLine(a.Attribute + ", ");
                                    }
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("\n");
                                }
                                Console.WriteLine("\n");
                                foodnumber++;
                            }

                            Console.WriteLine("Type the foodnumber you want to buy or [0] to finish");

                            if (Int32.TryParse(Console.ReadLine(), out int input1) && input1 <= foodlist.Count)
                            {
                                if (input1 == 0) ordermore = false;

                                if (input1 <= foodlist.Count && input1 != 0)
                                {
                                    var foodtobuy = foodlist.ElementAtOrDefault(input1 - 1);

                                    foodlistToBuy.Add(foodtobuy);
                                    foodlist.RemoveAt(input1 - 1);

                                    Console.WriteLine("Type [0] to finish your order. Any key to order more");
                                    var input = Console.ReadLine();

                                    if (input == "0") ordermore = false;
                                }
                            }
                        }

                        if (foodlistToBuy != null)
                        {
                            var ordernumber = userBackend.BuyFoodpack(foodlistToBuy);
                            var orderedfood = userBackend.GetOrderedFood(ordernumber);

                            Console.Clear();
                            foreach (var f in orderedfood)
                            {
                                Console.WriteLine($"Description: {f.Description}\n" +
                                                  $"Price: {f.Price}\n" +
                                                  $"Expiredate: {f.ExpireDate.Date}\n" +
                                                  $"Restaurant: {f.Restaurant.Name}\n");
                            }

                            Console.WriteLine("Your ordernumber is: " + ordernumber.Id);
                        }
                    }

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Available Restaurants: ");

                    var restaurantlist = userBackend.GetRestaurants();

                    var restaurantnumber = 1;

                    foreach (var r in restaurantlist)
                    {
                        Console.WriteLine($"Number: {restaurantnumber}\n" +
                                          $"Name: {r.Name}\n" +
                                          $"Phonenumber: {r.Phonenumber}\n");
                        ;
                        restaurantnumber++;
                    }

                    Console.WriteLine("Type the resturantnumber to see all sold foodpacks");

                    var restaurantid = Int32.Parse(Console.ReadLine());


                    var foodpacksfromrestaurant = restaurantBackend.GetSoldFoodpacks(restaurantid);

                    Console.Clear();
                    foreach (var f in foodpacksfromrestaurant)
                    {
                        Console.WriteLine($"Description: {f.Description}\n" +
                                          $"Price: {f.Price}\n" +
                                          $"Expiredate: {f.ExpireDate.Date}\n" +
                                          $"Restaurant: {f.Restaurant.Name}\n" +
                                          $"Sold date: {f.Order.OrderDate}");
                    }

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "4")
                {
                    Console.Clear();
                    Console.WriteLine("You are restaurant number 1 (MAX)");

                    Console.WriteLine("Enter description:");
                    var description = Console.ReadLine();

                    Console.WriteLine("Enter price in numbers:");
                    var price = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Enter expiredate as yyyy/mm/dd");
                    var expdate = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Enter category: Fish, Meat or Veggie");
                    var category = Console.ReadLine();

                    var restaurantid = 1;

                    restaurantBackend.AddFoodpack(price, expdate, description, restaurantid, category);

                    Console.Clear();
                    Console.WriteLine("New foodpack added");

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "5")
                {
                    var users = adminBackend.GetAllCostumers();

                    Console.WriteLine("This is all registered users: ");

                    foreach (var u in users)
                    {
                        Console.WriteLine("Name: " + u.Name);
                        if (u.IsBanned == true)
                        {
                            Console.WriteLine("Banned: Yes" + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Banned: No" + "\n");
                        }

                    }

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "6")
                {
                    Console.Clear();

                    var users = adminBackend.GetAllCostumers();
                    var usernumber = 1;

                    Console.WriteLine("Select a user to ban by number: ");
                    foreach (var u in users)
                    {
                        Console.WriteLine($"[{usernumber}]" +
                                          $"Name: {u.Name}\n");
                        usernumber++;
                    }

                    if (Int32.TryParse(Console.ReadLine(), out int userinput) && userinput <= users.Count)
                    {
                        Console.WriteLine("Type a reson why user is banned");
                        var reason = Console.ReadLine();

                        adminBackend.BanCostumer(users.ElementAtOrDefault(userinput - 1), reason);

                        Console.Clear();

                        Console.WriteLine($"User with name {users.ElementAtOrDefault(userinput - 1).Name} is now banned");
                    }
                    else
                    {
                        Console.WriteLine("cosutmer not existing");
                    }

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "7")
                {
                    Console.Clear();
                    Console.WriteLine("Existing Restaurants: ");

                    var restaurantlist = userBackend.GetRestaurants();

                    foreach (var r in restaurantlist)
                    {
                        Console.WriteLine($"Restaurantname: {r.Name}\n");
                    }

                    Console.WriteLine("Add new restaurant? Type 0");

                    var input = Console.ReadLine();

                    if (input == "0")
                    {
                        var running = true;
                        while (running)
                        {
                            Console.WriteLine("Type restaurantname");
                            var name = Console.ReadLine();

                            if (name != "")
                            {
                                Console.WriteLine("Type phonenumber (optional)");
                                var phone = Console.ReadLine();
                                if (phone == "") phone = null;

                                adminBackend.AddRestaurant(name, phone);

                                Console.Clear();
                                Console.WriteLine("Restaurant added");
                                running = false;
                            }
                            else
                            {
                                Console.WriteLine("Restaurantname is empty, try again");
                            }
                        }
                        ;
                    }


                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "8")
                {
                    //parameter restaurant
                    var restaurant = userBackend.GetRestaurants().Find(r => r.Name == "Max");

                    //parameter date 
                    var date = new DateTime(2021, 11, 01);

                    var profitSum = restaurantBackend.GetMonthlyProfit(restaurant, date);

                    Console.Clear();
                    Console.WriteLine($"Restaurant {restaurant.Name} has a profitsum of {profitSum} :- for period {date.Year}-{date.Month} ");

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }

                if (keyInfo == "9")
                {
                    Console.Clear();

                    var users = adminBackend.GetAllCostumers();
                    var usernumber = 1;
                    var bannedCosumers = new List<Costumer>();

                    Console.WriteLine("Select a user number to lift ban");

                    foreach (var c in users)
                    {
                        if (c.IsBanned == true)
                        {
                            Console.WriteLine($"[{usernumber}]" +
                                              $"Name: {c.Name}\n");
                            usernumber++;

                            bannedCosumers.Add(c);
                        }
                    }



                    if (bannedCosumers.Count != null && Int32.TryParse(Console.ReadLine(), out int userinput) && userinput <= bannedCosumers.Count)
                    {
                        var user = bannedCosumers.ElementAtOrDefault(userinput - 1);

                        adminBackend.LiftBanCostumer(user);

                        Console.Clear();

                        Console.WriteLine($"User with name {user.Name} are no longer banned");
                    }
                    else
                    {
                        Console.WriteLine("cosutmer not existing");
                    }

                    //end of choice
                    Console.ReadLine();
                    Console.Clear();


                    //end of choice
                    Console.ReadLine();
                    Console.Clear();
                }
                //end of menu scope
            }
        }
    }
}