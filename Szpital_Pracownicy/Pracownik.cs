﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Szpital_Pracownicy
{
    [Serializable()]
    public class Pracownik : IWorker
    {
        public string Surname;
        public string Name;
        public long Pesel;
        public string Username;
        public string Password;
        public int Number;
        public string No_num;
        public string Function;

        public Pracownik(string newSurname, string newName, long newPesel, string newPassword)
        {
            Surname = newSurname;
            Name = newName;
            Pesel = newPesel;
            Username = newSurname.Substring(0, 1).ToLower() + "." + newName.ToLower();
            Password = "password";
        }

        public Pracownik()
        {

        }

        public virtual string GetWorkerData()
        {
            return $"{this.Surname}, {this.Name}, {this.Pesel}, {this.Username}";
        }

        public string GetFunction()
        {
            return $"{this.Function}";
        }

    }
}
