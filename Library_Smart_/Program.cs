using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Smart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Books books = new Books();
            Personnel personnel = new Personnel();

            books.BookId = 1;
            books.BookName = "Alice...";
            books.BookType = "Novel";

            customer.CustomerId = 14;
            customer.CustomerName = "İlker";
            customer.CustomerSurName = "Yüce";
            customer.BoughtBookId = 1;
            customer.CustomerJob = "Öğrenci";
            customer.CustomerAdress = "Aadasd";

            personnel.PersonnelId = 1;
            personnel.PersonnelName = "Ali";
            personnel.PersonnelSurName = "ADSASD";
            personnel.PersonnelMission = "Teknisyen";



            Console.WriteLine(personnel.PersonnelMission);
            Console.ReadLine();

        }
    }
}
