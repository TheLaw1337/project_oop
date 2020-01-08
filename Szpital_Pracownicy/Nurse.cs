﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Pracownicy
{
    [Serializable()]
    public class Nurse : Pracownik
    {
        private string Function;
        private static int Number;
        private string No_num; // No. - liczba porządkowa
        private int Shifts;

        public Nurse(string newSurname, string newName, int newPesel) : base(newSurname, newName, newPesel)
        {
            this.No_num = $"Nur. {Number.ToString()}";
            this.Function = "Nurse";
            Number++;
        }
    }
}