namespace EmployeeDataManager.Classes
{
    class Employee
    {
        private string Name;
        private string Title;

        public void SetName(string name) => Name = name;

        public void SetTitle(string title) => Title = title;

        //GetName() returns the Employee Name as a string value.
        public string GetName() => Name;

        // GetTitle() returns Employees Title as a string value.
        public string GetTitle() => Title;

        public override string ToString()
        {
            return $"{Name}, {Title}";
        }
        public Employee(string name, string title)
        {
            Name = name;
            Title = title;
        }
    }
}
