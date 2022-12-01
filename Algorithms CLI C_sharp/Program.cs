using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_CLI_C_sharp.BL;
using Algorithms_CLI_C_sharp.DL;
using Algorithms_CLI_C_sharp.UI;
namespace Algorithms_CLI_C_sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<string> filenames = new List<string>() { "", "organizations-100.csv", "organizations-1000.csv", "organizations-10000.csv", "organizations-100000.csv", "organizations-500000.csv", "temp.csv" };
			List<string> sortType = new List<string>() { "", "Selection Sort ", "Bubble Sort ", "Insertion Sort ", "Merge Sort ", "Quick Sort", "Heap Sort", "Counting Sort", "Radix Sort", "Bucket Sort" };
			List<string> sortBy = new List<string>() { "", "by Index", "by No of Employees" };
			Data organizations = new Data();
			organizations.set_Data(OrganizationDl.load_data(filenames[6]));
			while (true)
			{
				char ch = OrganizationUI.mianMenu();
				if (ch == '1') // Sort by Index
				{
					char ch2 = OrganizationUI.sortDataMenu();
					if (ch2 == '0')
					{
						continue;
					}
					else
					{
						var watch = new System.Diagnostics.Stopwatch();
						watch.Start();
						List<Org> vtr = organizations.sortData(ch2-48, ch-48, organizations.get_Data());
						watch.Stop();
						OrganizationUI.showtime(watch.ElapsedMilliseconds, sortType[ch2 - 48] + sortBy[ch - 48]);
						OrganizationDl.storetime(watch.ElapsedMilliseconds, sortType[ch2 - 48] + sortBy[ch - 48]);
						organizations.set_Data(vtr);
					}
				}
				else if (ch == '2') // Sort by no of employees
				{
					char ch2 = OrganizationUI.sortDataMenu();
					if (ch2 == '0')
					{
						continue;
					}
					else
					{
						var watch = new System.Diagnostics.Stopwatch();
						watch.Start();
						List<Org> vtr = organizations.sortData(ch2-48, ch-48, organizations.get_Data());
						watch.Stop();
						OrganizationUI.showtime(watch.ElapsedMilliseconds, sortType[ch2 - 48] + sortBy[ch - 48]);
						OrganizationDl.storetime(watch.ElapsedMilliseconds, sortType[ch2 - 48] + sortBy[ch - 48]);
						organizations.set_Data(vtr);
					}
				}
				else if (ch == '3') // Load Data from file
				{
					int op = OrganizationUI.loadDataMenu();
					if (op == 7)
					{
						continue;
					}
					var watch = new System.Diagnostics.Stopwatch();
					watch.Start();
					List<Org> vtr = OrganizationDl.load_data(filenames[op]);
					watch.Stop();
					OrganizationUI.showtime(watch.ElapsedMilliseconds, "Load Data " + filenames[op]);
					OrganizationDl.storetime(watch.ElapsedMilliseconds, "Load Data " + filenames[op]);
					organizations.set_Data(vtr);
				}
				else if (ch == '4') // Display All Data
				{
					OrganizationUI.displayAllData(organizations.get_Data());
				}
				else if (ch == '5') // Display Indexes
				{
					OrganizationUI.displayIndexesData(organizations.get_Data());
				}
				else if (ch == '6') // Display No of Employees
				{
					OrganizationUI.displayNoEmpData(organizations.get_Data());
				}
				else if (ch == '7') // StoreData
				{
					OrganizationDl.storeData(organizations.get_Data());
				}
				else
				{
					break;
				}
			}
		}
    }
}
