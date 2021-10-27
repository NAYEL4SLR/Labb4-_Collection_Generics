namespace Labb4__Collection_Generics
{
    class Employee
    {
        protected string ID { get; set; } = "0000";
        protected string Name { get; set; }
        protected string Gender { get; set; }
        protected double Salary { get; set; }
        public Employee(string id, string name, string gender, int salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        public string ReturnID()
        {
            return ID;
        }
        public string ReturnGender()
        {
            return Gender;
        }

        public override string ToString()
        {
            return $"    ID: {ID} -- Full name: {Name}" +
                $" -- Gender: {Gender} -- Salary: {Salary}\n" +
                $"---------------------------------------------------------" +
                $"----------------------";
        }
    }
}
