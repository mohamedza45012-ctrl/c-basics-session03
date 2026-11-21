using System;
using System.Text;

namespace Assignment_Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string titile = "Clean Code"; 
           string upperTitile = titile.ToUpper();
           Console.WriteLine($"Titile: {titile}");
           Console.WriteLine($"upperTitile: {upperTitile}");

           string str1 = "Clean Code";
           string str2 = "Clean Code";
           Console.WriteLine( ReferenceEquals(str1,str2));

           StringBuilder sb = new StringBuilder();
           sb.Append("Book List");
           sb.Append(" - Updated");
           Console.WriteLine(sb);
           Console.WriteLine(sb.Replace("Book List","Library"));
           
           int pages = 464;
           bool isAvailable = true;
           Console.WriteLine("Book: " + titile + ", Pages: " + pages);
           Console.WriteLine($"Book: {titile}, Pages: {pages}");
           Console.WriteLine(string.Format("Book: {0}, Pages: {1}",titile, pages));
           
           if(pages > 300)
             Console.WriteLine("Long Book");
           else 
             Console.WriteLine("Short Book");

           if(pages > 300 && isAvailable == true )
             Console.WriteLine("You can borrow this book");
            
            string newTitile = "Refactoring";
            switch (newTitile)
            {
                case "Clean Code":
                 Console.WriteLine("Great choice!");
                 break;
                case "Refactoring":
                 Console.WriteLine("Nice pik!");
                 break;
                default:
                 Console.WriteLine("Never heard of it");
                 break;
            }
             string sizeLable = pages > 300 ? "Long Book" : "Short Book";
             Console.WriteLine($"SizeLable: {sizeLable}");

             string[] books = {"Clean Code","The Pragmatic Programmer","Refactoring"};
              PrintFirstBook(books);
             for(int i = 0 ; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}. {books[i]}");
            }
            int x = 0;
            while(x < books.Length)
            {
             Console.WriteLine($" {x+1}. {books[x]}");
                x++;
            }
               x = 0;
            do
            {
               Console.WriteLine("Checking book..."); 
                 x++;
            }
             while(x<3);

            foreach(string book in books)
            {
                Console.WriteLine(book);
            }
             for(int y=0; y < books.Length; y++)
            {
                if(books[y] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[y]);
            }
            for(int z=0; z<books.Length; z++)
            {
                if(books[z] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(books[z]);
            }
        }
          public static void PrintFirstBook(string[] myBooks)
          {
            if(myBooks.Length == 0)
              return;

            Console.WriteLine(myBooks[0]);
          }
    }
}