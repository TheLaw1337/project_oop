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

        public ListAllWorkers()
        {
            FillList();
        }

        public static void FillList()
        {
            Console.Clear();
            string text = null;
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
        }
    }
}
