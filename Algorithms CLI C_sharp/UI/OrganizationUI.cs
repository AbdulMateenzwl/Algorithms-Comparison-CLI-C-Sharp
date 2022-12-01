using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_CLI_C_sharp.BL;
namespace Algorithms_CLI_C_sharp.UI
{
    public class OrganizationUI
    {
        public static void displayAllData(List<Org> vtr)
        {
            Console.Write("{0,-5}", "Index");
            Console.Write("{0,-20}", "Organization ID");
            Console.Write("{0,-35}", "Name");
            Console.Write("{0,-40}", "Name");
            Console.Write("{0,-45}", "Country");
            Console.Write("{0,-60}", "Discription");
            Console.Write("{0,-10}", "Founded");
            Console.Write("{0,-60}", "Industry");
            Console.Write("{0,-30}", "No. of Employees");
            Console.Write("{0,-30}", "\n");
            foreach (var record in vtr)
            {
                Console.Write("{0,-5}", record.index);
                Console.Write("{0,-20}", record.org_id);
                Console.Write("{0,-35}", record.name);
                Console.Write("{0,-40}", record.website);
                Console.Write("{0,-45}", record.country);
                Console.Write("{0,-60}", record.discription);
                Console.Write("{0,-10}", record.founded);
                Console.Write("{0,-60}", record.industry);
                Console.Write("{0,-30}", record.no_emp);
                Console.Write("{0,-30}", "\n");
            }
        }
        public static void displayNoEmpData(List<Org> vtr)
        {
            foreach (var record in vtr)
            {
                Console.WriteLine(record.no_emp);
            }
        }
        public static void displayIndexesData(List<Org> vtr)
        {
            foreach (var record in vtr)
            {
                Console.WriteLine(record.index);
            }
        }
        public static char mianMenu()
        {
            char ch;
            Console.Write("\n");
            Console.Write("1. Sort with Index");
            Console.Write("\n");
            Console.Write("2. Sort with No of Employees");
            Console.Write("\n");
            Console.Write("3. Load Data");
            Console.Write("\n");
            Console.Write("4. Display All Data");
            Console.Write("\n");
            Console.Write("5. Display Indexes");
            Console.Write("\n");
            Console.Write("6. Dispay No of Employees");
            Console.Write("\n");
            Console.Write("7. Store Data");
            Console.Write("\n");
            Console.Write("0. Exit");
            Console.Write("\n");
            ch = Console.ReadLine()[0];
            return ch;
        }
        public static int loadDataMenu()
        {
            int ch;
            Console.Write("1. Load 100 Records");
            Console.Write("\n");
            Console.Write("2. Load 1000 Records");
            Console.Write("\n");
            Console.Write("3. Load 10000 Records");
            Console.Write("\n");
            Console.Write("4. Load 100000 Records");
            Console.Write("\n");
            Console.Write("5. Load 500000 Records");
            Console.Write("\n");
            Console.Write("6. Load Previous Stored Data");
            Console.Write("\n");
            Console.Write("0. Back");
            Console.Write("\n");
            ch = int.Parse(Console.ReadLine());
            return ch;
        }
        public static char sortDataMenu()
        {
            char ch;
            Console.Write("1. Selection Sort");
            Console.Write("\n");
            Console.Write("2. Bubble Sort");
            Console.Write("\n");
            Console.Write("3. Insertion Sort");
            Console.Write("\n");
            Console.Write("4. Merge Sort");
            Console.Write("\n");
            Console.Write("5. Quick Sort");
            Console.Write("\n");
            Console.Write("6. Heap Sort");
            Console.Write("\n");
            Console.Write("7. Count Sort");
            Console.Write("\n");
            Console.Write("8. Radix Sort");
            Console.Write("\n");
            Console.Write("9. Bucket Sort");
            Console.Write("\n");
            Console.Write("0. Back");
            Console.Write("\n");
            ch = Console.ReadLine()[0];
            return ch;
        }
        public static char sortOptions()
        {
            char ch;
            Console.Write("1. Accending Sort");
            Console.Write("\n");
            Console.Write("2. Descending Sort");
            Console.Write("\n");
            Console.Write("3. Back");
            Console.Write("\n");
            ch = Console.ReadLine()[0];
            return ch;
        }
        public static void showtime(long time, string str)
        {
            Console.WriteLine("Time Taken for " + str + " : " + time + " ms ");
        }
    }
}
