using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalperpageview = 4;
            do
            { 
                Console.WriteLine("enter page number");

                if (int.TryParse(Console.ReadLine(), out int pagenumber))
                {
                    var ms = GetEmployees().Skip((pagenumber - 1) * totalperpageview).Take(totalperpageview);

                    foreach (var item in ms)
                    {
                        Console.WriteLine($"id = {item.Id}  and name = {item.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("enter valid page number");
                }
            } while (true);
        }
            public static List<employee> GetEmployees()
        {
            return new List<employee>()
            {
              new employee(){Id =1, Name = "bhushan"},
              new employee(){Id =2, Name = "vishal"},
              new employee(){Id =3, Name = "shubham"},
              new employee(){Id =4, Name = "nikhil"},
              new employee(){Id =5, Name = "gaurav"},
              new employee(){Id =6, Name = "aniket"},
              new employee(){Id =7, Name = "sunny"},
              new employee(){Id =8, Name = "kunal"},
              new employee(){Id =9, Name = "jayesh"},
              new employee(){Id =10, Name = "sanket"},
              new employee(){Id =11, Name = "rushi"},
              new employee(){Id =12, Name = "akshay"},
              new employee(){Id =13, Name = "rohit"},
              new employee(){Id =14, Name = "virat"},
              new employee(){Id =15, Name = "dhoni"},
              new employee(){Id =16, Name = "sharma"},
              new employee(){Id =17, Name = "kohali"},
              new employee(){Id =18, Name = "bumrah"},
              new employee(){Id =19, Name = "bhuneshwar"},
              new employee(){Id =20, Name = "raina"}
              
            };
        }
        
    }

    class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
