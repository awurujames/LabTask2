namespace EmployeeTest
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Enployee(string firstname, string lastname, decimal salary)
        {
            FirstName = firstname;
            LastName = lastname;

            if
            (Salary < 0.0M)
            {
                salary = 0;
            }
            else
            {
                Salary = salary;
            }

        }
    }
}