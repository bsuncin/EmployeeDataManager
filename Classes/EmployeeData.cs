using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDataManager.Classes
{
    class EmployeeData
    {
        // List of Employees that is sorted
        private List<Employee> EmployeeList;
        public int Amount = 0;

        // FindEmployee(name) finds the first instance of employee
        // with Name name and returns their position or -1 if no
        // employee was found.
        private int FindEmployee(string name)
        {
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if (EmployeeList[i].GetName() == name)
                {
                    return i;
                }
            }
            return -1;

        }

        public Employee GetEmployeeAtPos(int pos)
        {
            return EmployeeList.ElementAt(pos);
        }


        // GetEmployees() returns the EmployeeList as a list.
        public List<Employee> GetEmployees() => EmployeeList;

        // A helper function that inserts person into EmployeeList. 
        private void AddEmployeeAtPos(int pos, Employee person)
        {
            EmployeeList.Insert(pos, person);
        }

        // AddEmployee(person) will add Employee person into the sorted
        // EmpolyeeList at the proper position.
        public void AddEmployee(Employee person)
        {
            if(EmployeeList.Count == 0)
            {
                EmployeeList.Add(person);
                Amount++;
            }
            else
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (person.GetName().CompareTo(EmployeeList[i].GetName()) < 1)
                    {
                        AddEmployeeAtPos(i, person);
                        Amount++;
                        return;
                    }
                }

                EmployeeList.Add(person);
                Amount++;
            }
        }

        // AddEmployee(name, title) will add Employee with Name name and Title title
        // into the sorted EmpolyeeList at the proper position.
        public void AddEmployee(string name, string title)
        {
            Employee person = new Employee(name, title);
            if (EmployeeList.Count == 0)
            {
                EmployeeList.Add(person);
                Amount++;
            }
            else
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (person.GetName().CompareTo(EmployeeList[i].GetName()) < 1)
                    {
                        AddEmployeeAtPos(i, person);
                        Amount++;
                        return;
                    }
                }

                EmployeeList.Add(person);
                Amount++;
            }
        }


        // DeleteEmployee(person) will delete a Employee person if they exist.
        public void DeleteEmployee(string person)
        {
            int pos = FindEmployee(person);
            if (pos >= 0)
            {
                DeleteEmployeeAtPos(pos);
                Amount--;
            }
            else
            {
                Console.Error.WriteLine($"Sorry employee {person} does not exist.");
            }
        }

        // DeleteEmployee(pos) will attempt to delete an employee at position
        // pos in EmployeeList.
        public void DeleteEmployeeAtPos(int pos)
        {
            if(pos >= 0 && pos < EmployeeList.Count)
            {
                EmployeeList.RemoveAt(pos);
                Amount--;
            }
            else
            {
                Console.Error.WriteLine("Sorry there is not an employee at that position.");
            }
        }
        public void UpdateEmployeeNameAtPos(int pos, string newName) => EmployeeList[pos].SetName(newName);

        // UpdateEmployeeName(person, newName) takes an employee person and a name newName
        // and replaces person name with newName if person exists.
        public void UpdateEmployeeName(string person, string newName)
        {
            int pos = FindEmployee(person);
            if(pos >= 0)
            {
                UpdateEmployeeNameAtPos(pos, newName);
            }
            else
            {
                Console.Error.WriteLine($"Sorry Employee {person} does not exist.");
            }
            
        }
        public void UpdateEmployeeTitle(string person, string newTitle)
        {
            int pos = FindEmployee(person);
            if (pos >= 0)
            {
                UpdateEmployeeTitleAtPos(pos, newTitle);
            }
            else
            {
                Console.Error.WriteLine($"Sorry Employee {person} does not exist.");
            }
        }

        public void UpdateEmployeeTitleAtPos(int pos, string newTitle) => EmployeeList[pos].SetTitle(newTitle);

        public override string ToString()
        {
            string result = "";
            int counter = 1;
            if (EmployeeList.Count == 0)
            {
                result = "  There are no employees.";
            }
            else
            {
                foreach (Employee employee in EmployeeList)
                {
                    result += $"  {counter}. {employee}\n";
                    counter++;
                }
            }

            result += "\n";
            return result;
        }

        // EmployeeData() creates an empty EmployeeList.
        public EmployeeData()
        {
            EmployeeList = new List<Employee> { };
        }

        // EmployeeData(person) creates an EmployeeList that contains person in the list.
        public EmployeeData(Employee person)
        {
            EmployeeList = new List<Employee> { person };
            Amount++;
        }
    }
}
