namespace List_Exercise_2
{
    public class Employee
    {
        public int Id { get; private set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _name = value;
                }
            }
        }

        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percent)
        {
            Salary += percent / 100 * Salary;
        }


    }
}
