using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Library_Smart
{
    internal class Customer
    {
        int ıd, bookıd;
        string name, surname, job, adres;
        public int CustomerId
        {
            get
            {
                return ıd;
            }
            set
            {
                ıd = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string CustomerSurName
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int BoughtBookId
        {
            get
            {
                return bookıd;
            }
            set
            {
                bookıd = value;
            }
        }
        public string CustomerJob
        {
            get
            {
                return job;
            }
            set
            {
                job = value;
            }
        }
        public string CustomerAdress
        {
            get
            {
                return adres;
            }
            set
            {
                adres = value;
            }
        }

    }
}
