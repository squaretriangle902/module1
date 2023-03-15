namespace Module2.Task5
{
    internal static class Task5
    {
        internal static void Run()
        {
            Employee[] employees =
            {
                new Employee("Denis", "Kolomiets", "Vyacheslavovich", "Boss of this gym",
                             workExperienceInYears: 22, new DateTime(2000, 10, 22)),
                //new Employee("Denis", "Kolomiets", "Vyacheslavovich", "Boss of this gym",
                //             workExperienceInYears: 24, new DateTime(2000, 10, 22)),
            };

            foreach (Employee empolyee in employees)
            {
                Console.WriteLine("{0} {1} {2}, post: {3}, age: {4}, work experience: {5} years",
                                  empolyee.Name, empolyee.Surname, empolyee.Patronymic, empolyee.Post,
                                  empolyee.Age.ToString(), empolyee.WorkExperienceInYears.ToString());
            }
        }
    }
}
