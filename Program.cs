using System;
using EmployeeDataManager.Classes;
using System.Collections.Generic;

namespace EmployeeDataManager
{
    class Program
    {   
        private static EmployeeData employees = new EmployeeData();

        // Exits progam
        public static void Exit()
        {
            
            while (true)
            {
                CommonDisplays.ExitPrompt();
                string ans = Console.ReadLine().ToLower();
                int ansVal = InputValidation.CheckYN(ans);

                if (ansVal == 1)
                {
                    Environment.Exit(0);
                }
                else if (ansVal == -1)
                {
                    CommonDisplays.InvalidYN();
                }
                else
                {
                    return;
                }
            }
            
        }
        
        // Gets a valid employee name
        public static string GetName()
        {
            while (true)
            {
                CommonDisplays.NamePrompt();
                string name = Console.ReadLine();
                name = InputValidation.CheckName(name);

                if (name != null)
                {
                    return name;
                }
                
                CommonDisplays.InvalidName();
            }
        }

        // Gets valid employee title returns null if invalid
        public static string GetTitle()
        {
            while (true)
            {
                CommonDisplays.TitlePrompt();
                string title = Console.ReadLine();
                title = InputValidation.CheckTitle(title);

                if (title != null)
                {
                    return title;
                }

                CommonDisplays.InvalidTitle();
            }
        }

        // Gets a valid position and returns it.
        // If stop command is found returns -2.
        public static int GetPos()
        {
            while (true)
            {
                CommonDisplays.DeletePositionPrompt();
                string sAns = Console.ReadLine();

                if (GetStop(sAns))
                {
                    return -2;
                }
                else
                {
                    int iAns = InputValidation.CheckForNum(sAns);
                    if (iAns > 0 && iAns <= employees.Amount)
                    {
                        return iAns;
                    }
                }

                CommonDisplays.DeleteInvalidPosition(employees.Amount);
            }
        }

        //checks for stop condition
        public static bool GetStop(string command)
        {
            if (command.ToLower() == "stop")
            {
                return true;
            }
            return false;
          
        }

        // Adds employee to employee list
        public static void AddEmployee()
        {
            CommonDisplays.AddEmployeePrompt();
            while (true)
            {
                string name = GetName();
                if (GetStop(name))
                {
                    CommonDisplays.AddEmployeeStop();
                    break;
                }
                else if ( name != null)
                {
                    string title = GetTitle();
                    if (GetStop(title))
                    {
                        CommonDisplays.AddEmployeeStop();
                        break;
                    }
                    else if ( title != null)
                    {
                        CommonDisplays.AddEmployeeCheckPrompt(name, title);
                        string ans = Console.ReadLine().ToLower();
                        int validAns = InputValidation.CheckYN(ans);
                        if (GetStop(ans))
                        {
                            CommonDisplays.AddEmployeeStop();
                            break;
                        }
                        else if (validAns == 1)
                        {
                            employees.AddEmployee(name, title);
                            CommonDisplays.AddEmployeeSucess(name, title);
                            break;
                        }
                        else
                        {
                            CommonDisplays.AddEmployeeRetryPrompt();
                            ans = Console.ReadLine().ToLower();
                            validAns = InputValidation.CheckYN(ans);

                            if (validAns != 1)
                            {
                                CommonDisplays.AddEmployeeStop();
                                break;
                            }
                        }
                    }
                }
            }
        }

        // Overwrite employee database with new database.
        public static void NewData()
        {
            CommonDisplays.NewDataPrompt();
            string ans = Console.ReadLine().ToLower();

            if (InputValidation.CheckYN(ans) == 1)
            {
                employees = new EmployeeData();
                CommonDisplays.NewDataSucess();
                return;
            }
            CommonDisplays.NewDataFailure();
        }

        // Delete Employee from database
        public static void Delete()
        {
            if (employees.Amount == 0)
            {
                CommonDisplays.DeleteEmployeeInvalidAmount();
            }
            else
            {
                int pos;
                CommonDisplays.EmployeeListTitle();
                Console.WriteLine(employees);
                CommonDisplays.DeleteEmployeePrompt();
                while (true)
                {
                    pos = GetPos();
                    if(pos == -2)
                    {
                        CommonDisplays.DeleteEmployeeStop();
                        return;
                    }
                    else
                    {
                        Employee person = employees.GetEmployeeAtPos(pos - 1);
                        CommonDisplays.DeleteEmployeeCheckPrompt(person.GetName(), person.GetTitle(), pos);
                        string ans = Console.ReadLine().ToLower();
                        int validAns = InputValidation.CheckYN(ans);
                        if (GetStop(ans))
                        {
                            CommonDisplays.DeleteEmployeeStop();
                            break;
                        }
                        else if (validAns == 1)
                        {
                            employees.DeleteEmployeeAtPos(pos - 1);
                            CommonDisplays.DeleteEmployeeSucess(person.GetName(), person.GetTitle(), pos);
                            break;
                        }

                    }
                    CommonDisplays.DeleteRetry();
                }
            }
        }

        public static void Update()
        {
            CommonDisplays.UpdateEmployeePrompt();
        }

        // Saves employees to a file
        public static void Save()
        {
            //FileOperations.Save(employees, "save1");
        }

        // Loads employees from a file
        public static void Load()
        {

        }
        static void Main(string[] args)
        {
            

            CommonDisplays.PrintTitle();
            CommonDisplays.WelcomeMessage();

            while (true)
            {
                Console.WriteLine(employees.Amount);
                CommonDisplays.CommandPrompt();
                string command = InputValidation.CheckCommand(Console.ReadLine().ToLower());
                if (command == null)
                {
                    CommonDisplays.InvalidCommand();
                }
                else if (command == "help")
                {
                    CommonDisplays.Help();
                }
                else if (command == "exit")
                {
                    Exit();
                }
                else if (command == "add")
                {
                    AddEmployee();
                }
                else if (command == "list")
                {
                    CommonDisplays.EmployeeListTitle();
                    Console.WriteLine(employees);
                }
                else if (command == "delete")
                {
                    Delete();
                }
                else if(command == "new")
                {
                    NewData();
                }
                else if (command == "update")
                {
                    Update();
                }
                else if (command == "save")
                {
                    Save();
                }
                else if (command == "load")
                {
                    Load();
                }
                CommonDisplays.ContinuePrompt();
                Console.ReadKey();
                Console.Clear();
                CommonDisplays.PrintTitle();
                CommonDisplays.PrintCommands();
            }
        }
    }
}
