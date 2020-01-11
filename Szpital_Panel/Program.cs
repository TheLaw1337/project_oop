using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szpital_Pracownicy;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Szpital_Panel
{
    [Serializable()]
    public class Program
    {
        public static int choice;
        public List<Pracownik> workers = new List<Pracownik>();
        public static WorkersList workersList = Deserialize();

        public static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome****************");
            Console.WriteLine("Menu:\n");
            Console.WriteLine("Add user:");
            Console.WriteLine("1. Doctor");
            Console.WriteLine("2. Nurse");
            Console.WriteLine("3. Administrator\n");
            Console.WriteLine("4. Shifts");
            Console.WriteLine("5. Show workers");
            Console.WriteLine("Choice? ");

            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Enter a number from 1 to 5: ");
            }
            switch (choice)
            {
                case 1:
                    NewDoctor.AddDoctor();
                    break;
                case 2:
                    NewNurse.AddNurse();
                    break;
                case 3:
                    NewAdmin.AddAdmin();
                    break;
                case 4:
                    Console.WriteLine("TODO");
                    break;
                case 5:
                    Console.WriteLine("TODO");
                    break;
                default:
                    break;
            }
        }

        public static WorkersList Deserialize()
        {
            WorkersList list = new WorkersList();
            BinaryFormatter binary = new BinaryFormatter();

            if (File.Exists("hospital_data.dat")){
                using (Stream fstream = new FileStream("hospital_data.dat", FileMode.Open, FileAccess.Read))
                {
                    list = (WorkersList)binary.Deserialize(fstream);
                    Console.WriteLine("Deserialization complete");
                }
            }
            else
            {
                List<Pracownik> newList = new List<Pracownik>();
                list.ListOfWorkers = newList;
                Console.WriteLine("List not found - new list created, will be saved during exit");
            }
            return list;
        }

        public void Serialize(WorkersList l)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream fStream = new FileStream("hospital_data.dat", FileMode.Create, FileAccess.Write))
            {
                binaryFormatter.Serialize(fStream, l);
            }
        }

        public void Add(Pracownik pracownik)
        {
            workersList.ListOfWorkers.Add(pracownik);
            Serialize(workersList);
        }
    }

}
