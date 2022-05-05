using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdyOpgave
{
    internal class AdressBook
    {
        private string _Owner;
        private ArrayList _Adresses = new ArrayList();

        public string owner 
        {
            get { return _Owner; }
            set { _Owner = value; }
        }

        public AdressBook()
        {
            List<string> adresses = new List<string>();
        }

        public AdressBook (string owner)
        {
            _Owner = owner;
        }

       public void AddAddress(object obj)
        {

            _Adresses.Add(obj);
        }

        public override string ToString()
        {
            return string.Format("\nOwner:{0,2}\nAdresses:\n{1,20}", owner, GetList());
        }

        public void RemoveAddress(int index)
        {
            _Adresses.RemoveAt(index);
        }

        public string GetList()
        {
            string str = string.Empty;
            foreach (Adress item in _Adresses)
            {
                str += item.ToString();
            }
                return str;
        }

    }
}
