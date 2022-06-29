
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1              //DO NOT change the namespace name
{
    public class BookUtil         //DO NOT change the class name 
    {
         
        LibraryContext context = new LibraryContext();
        public Book AddBook(Book book)    //DO NOT change the method Name and Signature
        {
            //Implement code to insert the book entity to database
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }


        public List<Book> GetBookByGenre(String Genre)   //DO NOT change the method Name and Signature
        {
            //Implement code to get the book entity from database based on Genre
            List<Book> books = context.Books.Where(b=>b.BookGenre.Equals(Genre)).ToList<Book>();
            return books;
        }
        public List<Book> GetBooksList() //DO NOT change the method Name and Signature
        {
             //Implement code to get the book list from database
             List<Book> books = context.Books.ToList<Book>();
            return books;
        
        }
        public Book UpdateBookPrice(int NewPrice,int Bookid)   //DO NOT change the method Name and Signature
        {
             //Implement code to update the book entity
              var books = context.Books.Where(b=>b.BookId==Bookid).First();
            books.BookPrice = NewPrice;
            return books;
        
        }

        public Book DeleteBook(int BookId)  //DO NOT change the method Name and Signature
        {
            //Implement code to delete the book entity by Id
             var books = context.Books.Where(b=>b.BookId==BookId).First();
            context.Books.Remove(books);
            context.SaveChanges();
            return books;
        }

    }
}
