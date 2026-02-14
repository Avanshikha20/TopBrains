using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            String s = Console.ReadLine();
            string[] st = s.Split(" ");


            Book book = new Book
            {
                Id = st[0],
                Title = st[1],
                Price = Convert.ToInt32(st[2]),
                Stock = Convert.ToInt32(st[3])

            };


            BookUtility utility = new BookUtility(book);

            while (true)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit
                Console.WriteLine(@"1.Display book details
                                    2.Display
                                    3.update book stock
                                    4.Exit");
                while (true) {

                    int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                    {
                        case 1:
                            utility.GetBookDetails();
                            break;

                        case 2:
                            // TODO:
                            // Read new price
                            int newPrice = Convert.ToInt32(Console.ReadLine());
                            utility.UpdateBookPrice(newPrice);
                            // Call UpdateBookPrice()
                            break;

                        case 3:
                            // TODO:
                            // Read new stock
                            int stock = Convert.ToInt32(Console.ReadLine());
                            // Call UpdateBookStock()
                            utility.UpdateBookStock(stock);
                        break;

                        case 4:
                            Console.WriteLine("Thank You");
                            return;

                        default:
                            // TODO: Handle invalid choice
                            break;
                    }
                }
            }
        }
    }
}
