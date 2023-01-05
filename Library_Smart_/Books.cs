using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Smart
{
    internal class Books
    {
        int ıd;
        string name;
        string type;
        public int BookId { get
            {
                return ıd;
            } set
            {
                ıd =value;
            }
                 }
        public string BookName
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
        public string BookType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

    }
}
