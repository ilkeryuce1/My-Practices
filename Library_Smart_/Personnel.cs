using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Smart
{
    internal class Personnel
    {
        int ıd;
        string name, surname, mission;
        public int PersonnelId
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
        public string PersonnelName
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
        public string PersonnelSurName
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
        public string PersonnelMission
        {
            get
            {
                return mission;    
            }
            set
            {
                mission = value;
            }
        }
    }
}
