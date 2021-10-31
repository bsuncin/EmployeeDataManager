using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace EmployeeDataManager.Classes
{
    class FileOperations
    {
        public static void Save(EmployeeData employees, string fileName)
        {
            string path = @"\Saves\" + fileName + ".txt";
            string curDir = Directory.GetCurrentDirectory();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    for (int i = 0; i < employees.Amount; i++)
                    {
                        Employee person = employees.GetEmployeeAtPos(i);
                        string txtString = $"{person.GetName()} {person.GetTitle()}";
                        sw.WriteLine(txtString);
                        Console.WriteLine(txtString);
                    }
                }
            }
            else
            {
                Console.WriteLine(curDir + path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    for (int i = 0; i < employees.Amount; i++)
                    {
                        Employee person = employees.GetEmployeeAtPos(i);
                        string txtString = $"{person.GetName()} {person.GetTitle()}";
                        sw.WriteLine(txtString);
                        Console.WriteLine(txtString);
                    }
                }
            }
        }
    }
}
