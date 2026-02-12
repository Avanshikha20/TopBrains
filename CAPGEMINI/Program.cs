// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static Stack<Order> Stack = new Stack<Order>();

//     public static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("1 Add Order");
//             Console.WriteLine("2 View Most Recent Order");
//             Console.WriteLine("3 View All Orders");
//             Console.WriteLine("4 Remove Most Recent Order");
//             Console.WriteLine("5 Exit");
//             Console.Write("Enter choice");

//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter Order Id: ");
//                     int orderId = Convert.ToInt32(Console.ReadLine());
//                     Console.Write("Enter Customer Name: ");
//                     string customerName = Console.ReadLine();
//                     Console.Write("Enter Item: ");
//                     string item = Console.ReadLine();
//                     Order.AddOrderDetails(orderId, customerName, item);
//                     Console.WriteLine("Order added successfully.");
//                     break;
//                 case 2:
//                     Console.WriteLine("Most Recent Order:");
//                     Console.WriteLine(Order.GetOrderDetails());
//                     break;

//                 case 3:
//                     Console.WriteLine("All Orders:");
//                     Order.ViewAllOrders();
//                     break;

//                 case 4:
//                     Order.RemoveOrderDetails();
//                     Console.WriteLine("Most recent order removed.");
//                     break;

//                 case 5:
//                     Console.WriteLine("Exiting");
//                     return;

//                 default:
//                     Console.WriteLine("Try again");
//                     break;
//             }
//         }
//     }
// }

// public class Order
// {
//     public int OrderId { get; set; }
//     public string CustomerName { get; set; }
//     public string Item { get; set; }

//     public static void AddOrderDetails(int orderId, string customerName, string item)
//     {
//         Order newOrder = new Order
//         {
//             OrderId = orderId,
//             CustomerName = customerName,
//             Item = item
//         };

//         Program.Stack.Push(newOrder);
//     }

//     public static string GetOrderDetails()
//     {
//         if (Program.Stack.Count > 0)
//         {
//             Order order = Program.Stack.Peek();
//             return $"{order.OrderId} {order.CustomerName} {order.Item}";
//         }
//         return "No orders available.";
//     }

//     public static void RemoveOrderDetails()
//     {
//         if (Program.Stack.Count > 0)
//         {
//             Program.Stack.Pop();
//         }
//         else
//         {
//             Console.WriteLine("No orders to remove.");
//         }
//     }

//     public static void ViewAllOrders()
//     {
//         if (Program.Stack.Count == 0)
//         {
//             Console.WriteLine("No orders available.");
//             return;
//         }

//         foreach (Order order in Program.Stack)
//         {
//             Console.WriteLine($"{order.OrderId} {order.CustomerName} {order.Item}");
//         }
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number of elements: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];

//         Console.WriteLine("Enter elements:");
//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         for (int i = 0; i < n; i++)
//         {
//             if (arr[i] == 0)
//             {
//                 for (int j = i + 1; j < n; j++)
//                 {
//                     if (arr[j] != 0)
//                     {
//                         int temp = arr[i];
//                         arr[i] = arr[j];
//                         arr[j] = temp;
//                         break;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("after moving zeros to end:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write(arr[i] + " ");
//         }
//     }
// }

// using System;
// class User
// {
//     public string Name{get;set;}
//     public string PhoneNumber{get;set;}
// }
// class InvalidPhoneNumber : Exception
// {
//     public InvalidPhoneNumber(string message) : base(message)
//     {
        
//     }
// }
// class Program
// {
//     public static void Main()
//     {
//         Program p=new Program();
//         System.Console.WriteLine("enter name");
//         string name=Console.ReadLine();
//         System.Console.WriteLine("enter PhoneNumber");
//         string number=Console.ReadLine();
//         p.ValidPhoneNumber(name,number);

//     }
//     public  User ValidPhoneNumber(string name,string number)
//     {
        
//         try
//         {
//             if (number.Length==10)
//             {
//                 User use=new User{
//                 Name=name,
//                 PhoneNumber=number
//                 };
//                 return use;
//             }
//             else
//             {
//                 throw new InvalidPhoneNumber("Invalid Phone Number");

//             }
//         }
//         catch(InvalidPhoneNumber ex)
//         {
//             System.Console.WriteLine(ex);
//             return null;
//         }


//     }


// }

// using System;
// class User
// {
//     public string Name{get;set;}
//     public string PhoneNumber{get;set;}
// }
// class InvalidPhoneNumber : Exception
// {
//     public InvalidPhoneNumber(string message) : base(message)
//     {
        
//     }
// }
// class Program
// {
//     public static void Main()
//     {
//         Program p=new Program();
//         System.Console.WriteLine("enter name");
//         string name=Console.ReadLine();
//         System.Console.WriteLine("enter PhoneNumber");
//         string number=Console.ReadLine();
//         try{
//         p.ValidPhoneNumber(name,number);
//         System.Console.WriteLine(name);
//         System.Console.WriteLine(number);
//         }catch(InvalidPhoneNumber ex)
//         {
//             System.Console.WriteLine(ex.Message);
//         }

//     }
//     public  User ValidPhoneNumber(string name,string number)
//     {
    
//             if (number.Length==10)
//             {
//                 User use=new User{
//                 Name=name,
//                 PhoneNumber=number
//                 };
//                 return use;
//             }
//             else
//             {
//                 throw new InvalidPhoneNumber("Invalid Phone Number");

//             }
//         }


//     }

// using System;
// class EcommerceShop
// {
//     public string UserName{get;set;}
//     public double WalletBalance{get;set;}
//     public double TotalPurchaseAmount{get;set;}



// }
// class InsufficientBalance : Exception
// {
//     public InsufficientBalance(String msg) : base(msg)
//     {
        
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         Program p=new Program();
//         System.Console.WriteLine("enter name");
//         string name=Console.ReadLine();
//         System.Console.WriteLine("eneter wallet balance");
//         int Balance=Convert.ToInt32(Console.ReadLine());
//         System.Console.WriteLine("enter purchase amount");
//         int Purchase=Convert.ToInt32(Console.ReadLine());
//         try
//         {
//             EcommerceShop e = p.MakePayment(name,Balance,Purchase);
//             System.Console.WriteLine($"{e.UserName}  {e.WalletBalance} {e.TotalPurchaseAmount}");
//         }
//         catch(InsufficientBalance ex)
//         {
//             System.Console.WriteLine(ex.Message);
//         }
//     }
//     public EcommerceShop MakePayment(string name,double wallet,double amount)
//     {
//         if (wallet < amount)
//         {
//             throw new InsufficientBalance("INSUFFICIENT BALANCE");
//         }
//         else
//         {
//             EcommerceShop es=new EcommerceShop
//             {
//                 UserName=name,
//                 WalletBalance=wallet,
//                 TotalPurchaseAmount=amount
//             };
//             return es;
//         }
//     }
// }

// using System;
// using System.Diagnostics;
// using System.Collections.Generic;
// using System.Linq;
// class Movie
// {
//     public string Title{get;set;}
//     public string Artist{get;set;}
//     public string Genre{get;set;}
//     public int Ratings{get;set;}
// }
// class Program
// {
//     public static List<Movie> MovieList=new List<Movie>();
    
//     public void AddMovie(string MovieDetails)
//     {
//         string[] st=MovieDetails.Split(" ");
//         Movie mv=new Movie
//         {
//             Title=st[0],
//             Artist=st[1],
//             Genre=st[2],
//             Ratings=Convert.ToInt32(st[3])

//         };
//         MovieList.Add(mv);
//     }
//     public List<Movie> ViewMoviesByGenre(String genre)
//     {
//         List<Movie> result = new List<Movie>();
//         foreach(var m in MovieList)
//         {
//             if (m.Genre == genre)
//             {
//                 result.Add(m);
//             }
//         }
//         return result;
//     }
//     public List<Movie> ViewByRatings()
//     {
//         List<Movie> mv=MovieList;
//         var sort=mv.OrderBy(e=>e.Ratings).ToList();
//         return sort;
        
//     }

//     public static void Main()
//     {
//         Program p=new Program();
        
//         while(true){
//         System.Console.WriteLine("1.Add 2.SEARCH 3.RAting ");
//         int choice=Convert.ToInt32(Console.ReadLine());
//         switch(choice){
//             case 1:
//             System.Console.WriteLine("Enter Details");
//             string Moviedetails=Console.ReadLine();
//             p.AddMovie(Moviedetails);
//             break;
//             case 2:
//             string genre=Console.ReadLine();
//         List<Movie> movies= p.ViewMoviesByGenre(genre);
//         if (movies.Count == 0)
//         {
//             System.Console.WriteLine("no movies found");
//         }
//         else
//         {
//              foreach(var m in movies)
//             {
//                 System.Console.WriteLine(m.Title+" "+m.Artist);
//             }
//         } 
//         break;
//         case 3:
//         List<Movie> sort=p.ViewByRatings();
//         foreach(var v in sort)
//         {
//             System.Console.WriteLine(v.Title+" "+v.Ratings);
//         }
//         break;
//         default :
//         break;

        
// }
//         }
//     }
// }

using System;
using System.Linq;
public class UniversitySystem
{
    public Dictionary<string, Course> AvailableCourses { get; set; }
    public Dictionary<string, Student> Students { get; set; }
    public List<Student> ActiveStudents { get; set; }
    public UniversitySystem()
    {
        AvailableCourses=Dictionary<string, Course>();
        Students=Dictionary<string, Student>();
        ActiveStudents = new List<Student>();


    }
    public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
    {
        if (AvailableCourses.ContainsKey(code))
        {
            throw new ArgumentException("Course not found");
        }
        AvailableCourses[code]=new Course(code,name,credits,maxCapacity,prerequisites);
    }

    public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
    {
        if (Students.ContainsKey(id))
        {
            throw new ArgumentException("id already exists");
        }
        Student s = new Student(id, name, major, maxCredits, completedCourses);
        Students[id] = s;
        ActiveStudents.Add(s);
    }
    public bool RegisterStudentForCourse(string studentId, string courseCode)
    {
        if(!Students.ContainsKey(studentId)|| !AvailableCourses.ContainsKey(courseCode))
        {
            return false;
        }
        Student s = Students[studentId];
        Course c = AvailableCourses[courseCode];

    }

}
    