using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Pracownicy
{
    [Serializable()]
    public class Admin : Pracownik
    {
        private string Function;

        public Admin(string newName, string newSurname, int newPesel) : base(newSurname,newName,newPesel)
        {
            this.Function = "Administrator";
        }
    }
}
