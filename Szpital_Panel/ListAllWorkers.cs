using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szpital_Pracownicy;
using System.Collections;

namespace Szpital_Panel
{
    public class ListAllWorkers
    {
        static WorkersList list = new WorkersList();
        static Program program = new Program();

        public ListAllWorkers()
        {
            FillList();
        }

        public static void FillList()
        {
            Console.Clear();
            string text;
            list = Program.Deserialize();
            ArrayList itemsList = new ArrayList();
            
            foreach (Pracownik record in list.ListOfWorkers)
            {
                
                text = $"{record.GetFunction()} | {record.GetWorkerData()} ";
                itemsList.Add(text);
            }

            foreach (var record in itemsList)
            {
                Console.WriteLine(record);
            }
            Menu();
        }

        public static void Menu()
        {
            int choice;
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Update worker data");
            Console.WriteLine("2. Remove worker");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("Invalid choice. Enter a number from 1 to 2: ");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter the worked ID to update");
                    string to_update = Console.ReadLine();
                    Update(to_update);
                    break;
                case 2:
                    Console.WriteLine("todo");
                    break;
                default:
                    break;
            }
        }

        public static void Update(string to_find)
        {
            string text;
            list = Program.Deserialize();
            ArrayList itemsList = new ArrayList();

            foreach (Pracownik record in list.ListOfWorkers)
            {

                text = $"{record.GetFunction()} | {record.GetWorkerData()} ";
                itemsList.Add(text);
            }
            

            foreach (var record in list.ListOfWorkers)
            {
                if (record.No_num.Equals(to_find))
                {
                    Console.WriteLine(record.GetWorkerData());

                    Console.WriteLine("Please enter new surname: ");
                    string temp_surname = Console.ReadLine();
                    Console.WriteLine("Please enter new name: ");
                    string temp_name = Console.ReadLine();
                    Console.WriteLine("Please enter new PESEL");
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

                    string temp_specialty = null;
                    int temp_pwz = 0;
                    string temp_password = null;
                    if (record.Function == "Doctor")
                    {
                        int choice_specialty;
                        
                        Console.WriteLine("Choose a new specialty (type a number and press Enter):\n 1 - cardiologist, 2 - urologist, 3 - neurologist, 4 - laryngologist");
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

                        Console.WriteLine("Please enter new doctor PWZ number");
                        
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
                        temp_password = Console.ReadLine();
                    
                        record.Surname = temp_surname;
                        record.Name = temp_name;
                        record.Pesel = temp_pesel;
                        //record.Specialty = temp_specialty;
                        Console.WriteLine("Doctor data updated");
                        //Console.WriteLine(p.GetWorkerData());
                        Program.Serialize(list);
                    }

                }
                break;
            }
            
        }
    }
 }

