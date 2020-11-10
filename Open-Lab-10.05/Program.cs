using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("Creative name of book", -100, "encyclopedia", "Jaro", 2020);
            Book LOTR2 = new Book("Another creative name of book", 25);
            Book LOTR3 = new Book();
            Book HOBIT = new Book("HOBIT", 310, "fantasy", "Tolkien", 2020);
            LOTR.GetBook();
            LOTR2.GetBook();
            LOTR3.GetBook();
            HOBIT.GetBook();
            Console.ReadKey();
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public string Title
        {
            get => this.title;
            set
            {
                this.title = value;
            }
        }

        public int Pages
        {
            get => this.pages;
            set
            {
                this.pages = value;
                if (this.pages < 0)
                {
                    this.pages = 1;
                }
            }
        }

        public string Category
        {
            get => this.category;
            set
            {
                this.category = value;
            }
        }

        public string Author
        {
            get => this.author;
            set
            {
                this.author = value;
            }
        }

        public int ReleaseDate
        {
            get => this.releaseDate;
            set
            {
                this.releaseDate = value;
                if ((this.releaseDate > 2021) || (this.releaseDate < 1450))
                {
                    this.releaseDate = -1;
                }
            }
        }
        public void GetBook()
        {
            Console.WriteLine(String.Format($"{title} , {pages} , {category} , {author} , {releaseDate}"));
        }
    }
}