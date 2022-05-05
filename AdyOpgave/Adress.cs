using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdyOpgave
{
    internal class Adress
    {
        private string _Name;
        private string _StreetName;
        private string _Telephone;

        public string Name 
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string StreetName 
        {
            get { return _StreetName; }
            set { _StreetName = value; }
        }

        public string Telephone 
        { 
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        public Adress() { }

        public Adress(string name, string streetname, string telephone)
        {
            _Name = name;
            _StreetName = streetname;
            _Telephone = telephone;
        }

        public override string ToString()
        {
            return string.Format("Navn: {0,10}\nStreet: {1,10}\nPhone: {2,10}\n", Name, StreetName, Telephone);
        }
    }
}
