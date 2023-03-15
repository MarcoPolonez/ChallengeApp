using ChallengeApp;

Employee user1 = new Employee("Marek", "Baran", 30);
Employee user2 = new Employee("Paulina", "Glowa", 39);
Employee user3 = new Employee("Grazyna", "Sprzata", 44);

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(7);
user1.AddScore(9);
user1.AddScore(10);

user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(8);
user2.AddScore(9);

user3.AddScore(10);
user3.AddScore(10);
user3.AddScore(7);
user3.AddScore(9);
user3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    user1,user2,user3
};

int maxResult = -1;
Employee withMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        withMaxResult = employee;
    }
}

Console.WriteLine("Imie:" + withMaxResult.Name);
Console.WriteLine("Nazwisko:" + withMaxResult.Surname);
Console.WriteLine("Wiek:" + withMaxResult.Age);
Console.WriteLine("Punkty:" + withMaxResult.Result);
