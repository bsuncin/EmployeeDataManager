using System;
using System.Collections.Generic;

namespace EmployeeDataManager.Classes
{
    static class CommonDisplays
    {
        private static readonly List<string> COMMANDS = new List<string> { "Add", "Update", "Delete", "List", "New", "Help", "Exit" };

        // prints full command list
        public static void PrintCommands()
        {
            Console.WriteLine("  ---------------------");
            Console.WriteLine("     Commands List");
            Console.WriteLine("  ---------------------");

            foreach (string command in COMMANDS)
            {
                Console.WriteLine($"  {command}");
            }
            Console.WriteLine("\n");
        }

        //Prints app title
        public static void PrintTitle()
        {
            Console.WriteLine("  -------------------------");
            Console.WriteLine("    Employee Data Manager");
            Console.WriteLine("  -------------------------\n");
        }

        // Prints program welcome message
        public static void WelcomeMessage()
        {
            Console.WriteLine("  Welcome below you will find a list of valid commands.\n");
            Console.WriteLine("  You can type stop at any point to end the current command process.\n");
            PrintCommands();
        }

        // Prints invalid command message
        public static void InvalidCommand()
        {
            Console.WriteLine("  Sorry please input a valid command.");

        }

        // Prints commands descriptions
        public static void Help()
        {
            Console.WriteLine("\n\n  Add: Adds an employee to the current employee database.\n");
            Console.WriteLine("  Delete: removes an employee from the current employee database.\n");
            Console.WriteLine("  Update: Changes the name or title for a current employee in the employee database.\n");
            Console.WriteLine("  List: Show all employees in the current database.\n");
            Console.WriteLine("  Exit: Closes the program.\n");
            Console.WriteLine("  Stop: Ends the currently running process.\n");
        }

        // prints user command prompt
        public static void CommandPrompt()
        {
            Console.Write("  Input command: ");
        }

        // prints exit confirmation
        public static void ExitPrompt()
        {
            Console.Write("  Are you sure you want to exit y/n?: ");
        }

        public static void InvalidName()
        {
            Console.WriteLine("  Sorry please input a valid name.\n");
        }

        public static void NamePrompt()
        {
            Console.Write("  Input employee name: ");
        }

        public static void TitlePrompt()
        {
            Console.Write("  Input employee title: ");
        }

        public static void InvalidTitle()
        {
            Console.WriteLine("  Sorry please input a valid employee title.\n");
        }

        public static void ContinuePrompt()
        {
            Console.WriteLine("  Press any key to continue....");
        }

        public static void InvalidYN()
        {
            Console.WriteLine("  Sorry please input a y or n. \n");
        }

        public static void EmployeeListTitle()
        {
            Console.Write("\n  ---------------------\n");
            Console.Write("      Employee List\n");
            Console.Write("  ---------------------\n");
        }
        public static void PositionPrompt()
        {
            Console.Write("  Position: ");
        }


        // AddEmployee ------------------------------------------------------------------------------------------------------------------

        public static void AddEmployeeSucess(string name, string title)
        {
            Console.WriteLine($"  Employee {name} with the title {title} added Sucessfully.");
        }
        public static void AddEmployeeStop()
        {
            Console.WriteLine("  Stopped adding an employee.");
        }

        public static void AddEmployeeFail()
        {
            Console.WriteLine("  Sorry that is an invalid input.");
        }

        public static void AddEmployeeCheckPrompt(string name, string title)
        {
            Console.WriteLine($"  Name: {name}");
            Console.WriteLine($"  Title: {title}");
            Console.Write("  Is this employee information correct y/n?: ");

        }
        public static void AddEmployeePrompt()
        {
            Console.WriteLine("  Adding an Employee\n " +
                " Type stop at any point to end the operation.\n");
        }
        public static void AddEmployeeRetryPrompt()
        {
            Console.Write("  Do you want to retry inputing the employee data y/n?: ");
        }


        // UpdateEmployee ---------------------------------------------------------------------------------------------------------

        public static void UpdateNameConfirmation(string name, string newName)
        {
            Console.WriteLine($"  Employee {name}'s name has been updated to {newName}.\n");
        }

        public static void UpdateNameConfirmationCheck(string name, string newName)
        {
            Console.WriteLine($"  Are you sure you want to update employee {name}'s name to {newName} as the value?");
            Console.Write("  y/n: ");
        }

        public static void UpdateTitleConfirmationCheck(string name, string newTitle)
        {
            Console.WriteLine($"  Are you sure you want to update employee {name}'s title to {newTitle} as the value?");
            Console.Write("  y/n: ");
        }
        public static void UpdateTitleConfirmation(string name, string newTitle)
        {
            Console.WriteLine($"  Employee {name}'s title has been updated to {newTitle}.\n");
        }


        public static void UpdateEmployeeStop()
        {
            Console.WriteLine("  Stopped update employee process.");
        }

        public static void UpdateEmployeePrompt()
        {
            Console.WriteLine("  Please input the position of the employee to update.");
        }

        public static void UpdateEmployeeInvalidAmount()
        {
            Console.WriteLine($"  Sorry there are no employees to update.");
        }

        public static void UpdateEmployeeRetry()
        {
            Console.WriteLine("  Retrying update operation.");
        }

        public static void UpdateEmployeeRetry(int pos)
        {
            Console.WriteLine($"  Retrying update operation for employee at pos {pos}.");
        }

        public static void UpdateEmployeeNamePrompt()
        {
            Console.WriteLine("  Press enter to skip updating the employee name.");
            Console.Write("  New name:  ");
        }
        public static void UpdateEmployeeTitlePrompt()
        {
            Console.WriteLine("  Press enter to skip updating the employee title.");
            Console.Write("  New title:  ");
        }

        public static void UpdateEmployeeSkipName()
        {
            Console.WriteLine("  Skipping name update.");
        }

        public static void UpdateEmployeeSkipTitle()
        {
            Console.WriteLine("  Skipping title update.");
        }

        public static void UpdateEmployeeSkip()
        {
            Console.WriteLine("  All update operations skipped.");
        }

        public static void UpdateEmployeeFullConfirmation(string name, string newName, string title, string newTitle, int pos)
        {
            Console.WriteLine($"  Are you sure you want to update the employee at position {pos} with these values\n" +
                $"  Original Name: {name},  Original Title: {title}\n" +
                $"  New Name: {newName},  New Title: {newTitle}");
            Console.Write("  y/n: ");
        }

        public static void UpdateEmployeeFull(string name, string newName, string title, string newTitle, int pos)
        {
            Console.WriteLine($"  Updated employee at position {pos} with these values\n" +
                $"  Original Name: {name},  Original Title: {title}\n" +
                $"  New Name: {newName},  New Title: {newTitle}\n" +
                $"  Be advised the Employee maybe in a new position to maintain order.");
        }

        // DeleteEmployee ------------------------------------------------------------------------------------------------------------

        public static void DeleteEmployeePrompt()
        {
            Console.WriteLine("  Input the position number of the employee you want to delete. ");
        }
        public static void DeleteEmployeeInvalidPosition(int max, int min)
        {
            Console.WriteLine($"  Sorry that is an invalid position please input a number from {min} to {max}");
        }
        public static void DeleteEmployeeInvalidAmount()
        {
            Console.WriteLine($"  Sorry there are no employees to delete.");
        }

        public static void DeleteInvalidPosition(int max)
        {
            Console.WriteLine($"  Sorry that is an invalid position.\n  Please input a position between 1 and {max}");
        }

        public static void DeleteEmployeeStop()
        {
            Console.WriteLine("  Stopped deleting employee process.");
        }

        public static void DeleteEmployeeCheckPrompt(string name, string title, int pos)
        {
            Console.WriteLine("  Are you sure you want to delete employee");
            Console.WriteLine($"  {name}, with the title {title} at position {pos}.");
            Console.Write("  y/n?: ");
        }

        public static void DeleteEmployeeSucess(string name, string title, int pos)
        {
            Console.WriteLine("  Sucessfully deleted employee " +
                $"{name}, with the title {title} at position {pos}.");
        }

        public static void DeleteRetry()
        {
            Console.WriteLine("  Retrying delete operation.");
        }

        // Newdata ------------------------------------------------------------------------------------------------------------------------

        public static void NewDataPrompt()
        {
            Console.Write("  Are you sure you want to start over y/n?: ");

        }

        public static void NewDataSucess()
        {
            Console.WriteLine("  Sucessfully created new employee database.");

        }

        public static void NewDataFailure()
        {
            Console.WriteLine("  Stopped creating new employee database.");

        }

    }
}
