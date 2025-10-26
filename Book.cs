using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBookUPR
{
    public class Book
    {
        
            private string title;
            private string author;
            private decimal price;

            public string Title
            {
                get { return title; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    {
                        throw new ArgumentException("Заглавието трябва да е поне 3 символа.");
                    }
                    title = value;
                }
            }

            public string Author
            {
                get { return author; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Името на автора не може да е празно.");
                    }
                    author = value;
                }
            }

            public decimal Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Цената не може да бъде отрицателна.");
                    }
                    price = value;
                }
            }

            public Book(string title, string author, decimal price)
            {
                Title = title;
                Author = author;
                Price = price;
            }

        
    }
}
