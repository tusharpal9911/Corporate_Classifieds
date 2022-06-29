using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1   //DO NOT change the namespace name
{
    public class Program   //DO NOT change the class name
    {
        static void Main(string[] args)      //DO NOT change the 'Main' method signature
        {
            //Implement code here
            Book b = new Book();
            Console.WriteLine("Enter Book Name");
            b.BookName = Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            b.BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            b.BookGenre = Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            b.BookPrice = Convert.ToDouble(Console.ReadLine());
        }
    }
}