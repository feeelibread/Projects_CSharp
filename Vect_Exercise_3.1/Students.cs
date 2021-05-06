namespace Vect_Exercise_3._1
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
