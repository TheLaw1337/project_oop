using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szpital_Pracownicy;

namespace Szpital_Panel
{
    public class NewDoctor  
    {
        public static void AddDoctor()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("Please enter doctor surname: ");
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
            int choice_specialty;
            string temp_specialty = null;
            Console.WriteLine("Choose a specialty (type a number and press Enter):\n 1 - cardiologist, 2 - urologist, 3 - neurologist, 4 - laryngologist");
            while (!int.TryParse(Console.ReadLine(), out choice_specialty) || choice_specialty < 1 || choice_specialty > 4)
            {
                Console.WriteLine("Invalid choice. Enter a number from 1 to 5: ");
            }
            switch (choice_specialty)
            {
                case 1:
                    temp_specialty = "cardiologist";
                    break;
                case 2:
                    temp_specialty = "urologist";
                    break;
                case 3:
                    temp_specialty = "neurologist";
                    break;
                case 4:
                    temp_specialty = "laryngologist";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Please enter doctor PWZ number");
            int temp_pwz;
            while (true)
            {
                string pwz_string = Console.ReadLine();
                if (pwz_string.Length != 7)
                    Console.WriteLine("Invalid PWZ. Enter the correct number (7 digits)");
                else if (!int.TryParse(pwz_string, out temp_pwz))
                    Console.WriteLine("Entered text is string, not a number");
                else
                    break;
            }

            Console.WriteLine("Enter the new password:");
            string temp_password = Console.ReadLine();

            Pracownik p = new Doctor(temp_surname, temp_name, temp_pesel, temp_specialty, temp_pwz, temp_password);
            Console.WriteLine("Doctor added:");
            Console.WriteLine(p.GetWorkerData());
            program.Add(p);
        }
    }
}
