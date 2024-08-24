using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson631
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            Console.ReadKey();  
        }
        static Department GetCurrentDepartment()
        {
            var department = new Department();

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
            return department;
        }
    }

}
