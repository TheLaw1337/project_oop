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
        

        public Admin(string newName, string newSurname, long newPesel, string newPassword) : base(newSurname,newName,newPesel,newPassword)
        {
            this.Function = "Administrator";
            
        }
    }
}
