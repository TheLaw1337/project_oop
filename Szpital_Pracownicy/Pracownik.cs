using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Pracownicy
{
    [Serializable()]
    public class Pracownik
    {
        public string Surname;
        public string Name;
        public long Pesel;
        public string Username;
        public string Password;

        public Pracownik(string newSurname, string newName, long newPesel, string newPassword)
        {
            Surname = newSurname;
            Name = newName;
            Pesel = newPesel;
            Username = newSurname.Substring(0, 1).ToLower() + "." + newName.ToLower();
            Password = "password";
        }


    }
}
