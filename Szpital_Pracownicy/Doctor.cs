﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Pracownicy
{
    [Serializable()]
    public class Doctor : Pracownik
    {
        private string Specialty;
        private int PWZnumber;
        private string Function;
        private static int Number;
        private string No_num; // No. - liczba porządkowa
        private int Shifts;

        public Doctor(string newSurname, string newName, int newPesel, string newSpecialty, int newPWZnumber) : base(newSurname, newName, newPesel)
        {
            this.No_num = $"Doc. {Number.ToString()}";
            this.Specialty = newSpecialty;
            this.PWZnumber = newPWZnumber;
            this.Function = "Doctor";
            Number++;
        }
    }
}