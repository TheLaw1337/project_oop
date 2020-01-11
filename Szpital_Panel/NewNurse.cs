using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szpital_Pracownicy;

namespace Szpital_Panel
{
    public class NewNurse
    {
        static Nurse nur = new Nurse();
        static ID_Operations id_ops = new ID_Operations("NR_Nur.txt");
        static string path = "NR_Nur.txt";
        public NewNurse()
        {
            id_ops.GetID(path);
        }
        public static void AddNurse()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("Please enter nurse surname: ");
            string temp_surname = Console.ReadLine();
            Console.WriteLine("Please enter doctor name: ");
            string temp_name = Console.ReadLine();
            Console.WriteLine("Please enter doctor PESEL");
            long temp_pesel;
            while (true)
            {
                string pesel_string = Console.ReadLine();
                if (pesel_string.Length != 11)
                    Console.WriteLine("Invalid PESEL. Enter the correct number (11 digits)");
                else if (!long.TryParse(pesel_string, out temp_pesel))
                    Console.WriteLine("Entered text is string, not a number");
                else
                    break;
            }
            

            Console.WriteLine("Enter the new password:");
            string temp_password = Console.ReadLine();

            Pracownik p = new Nurse(temp_surname, temp_name, temp_pesel, temp_password);
            Console.WriteLine("Nurse added:");
            p.Number = id_ops.NextID(path);
            p.No_num = $"Nur. {p.Number.ToString()}";
            Console.WriteLine(p.GetWorkerData());
            Console.WriteLine(p.Number);
            program.Add(p);
        }
    }
}
