using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_7._1
{
    class Book:IComparable<Book>
    {
        private int id;
        public string title;
        private string author;
        public string publisher;
        public int year;
        private double price;
        public Book(int id,string title,string author,string publisher,int year,double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.price = price;
        }
        public int CompareTo(Book other)
        {
            return this.price.CompareTo(other.price);
        }
        public void Display()
        {
            Console.WriteLine("Info:" + id + " " + title + " " + author 
                + " " + publisher + " " + year + " " + price);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            List<Book> book = new List<Book>();
            for(int i=0;i<number; i++)
            {
                Console.WriteLine("Enter id:");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter title:");
                var title = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter author");
                var author= Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter publisher");
                var publisher = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter year");
                var year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter price");
                var price = Convert.ToDouble(Console.ReadLine());
                book.Add(new Book(id, title, author, publisher, year, price));
            }
            book.Sort();
            foreach(var a in book)
            {
                a.Display();
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = i+1; j < number; i++)
                {
                    if (book[i].title == book[j].title)
                    {
                        Console.WriteLine("2 cuon sach trung title la:");
                        book[i].Display();
                        book[j].Display();
                    }
                }
            }
            for (int i = 0; i < number; i++)
            {
                if (book[i].year == 2014) 
                { 
                    Console.WriteLine("Cuon sach xuat ban nam 2014 la:");
                    book[i].Display();
                }
            }
            for (int i = 0; i < number; i++)
            {
                if (book[i].title == "Nhi Dong")
                    book[i]= null;
            }
            }
    }
}
