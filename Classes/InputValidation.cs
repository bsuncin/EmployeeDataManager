using System;
using System.Collections.Generic;

namespace EmployeeDataManager.Classes
{
    public static class InputValidation
    {
        private static readonly int NAMEMAX = 200;
        private static readonly int TITLEMAX = 100;
        private static readonly int NAMEMIN = 1;
        private static readonly int TITLEMIN = 1;
        private static readonly List<string> COMMANDS = new List<string> { "add", "update", "delete", "new", "exit", "help", "list", "save", "load" };

        // Checks for a valid name and returns it otherwise returns null.
        public static string CheckName(string name)
        {
            if (name.Length < NAMEMAX && name.Length > NAMEMIN)
            {
                return name;
            }
            else
            {
                return null;
            }
            
        }

        // Checks for a valid title and returns it otherwise returns null.
        public static string CheckTitle(string title)
        {
            if (title.Length < TITLEMAX && title.Length > TITLEMIN)
            {
                return title;
            }
            else
            {
                return null;
            }

        }

        // Takes string command with a potential command and checks it 
        // if the command exists. If the command doesn't exist return null.
        public static string CheckCommand(string command)
        {
            if (COMMANDS.Contains(command.ToLower()))
            {
                return command;
            }
            else
            {
                return null;
            }
        }

        // Checks input for a yes or no answer: returns 1 if yes,
        // return 0 if no, and -1 if there was no valid response.
        public static int CheckYN(string ans)
        {
            if (ans.ToLower().StartsWith("y"))
            {
                return 1;
            }
            else if(ans.ToLower().StartsWith("n"))
            {
                return 0;
            }
            return -1;
        }

        // Check if input is a number and greater than 0. If a valid number is found it
        // returns it as an int. If no number is found it returns -1. Takes in a string
        // with a possible number.
        public static int CheckForNum(string possNum)
        {
            int ans = -1;
            try
            {
                int potNum = Int32.Parse(possNum);
                if (potNum > 0)
                {
                    ans = potNum;
                }
            }
            catch
            {
                //"Value error in CheckForNum"
            }

            return ans;
        }

    }
}
