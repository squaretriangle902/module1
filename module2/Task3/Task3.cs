namespace Module2.Task3
{
    internal static class Task3
    {
        internal static void Run()
        {
            User[] users = { new User("Denis", "Kolomiets", "Vyacheslavovich", new DateTime(2000, 10, 22)),
                             /*new User("Denis", "Kolomiets", "Vyacheslavovich", new DateTime(2024, 10, 22))*/};
            foreach (User user in users)
            {
                Console.WriteLine("{0} {1} {2}, age: {3}", user.Name, user.Surname, user.Patronymic, user.Age.ToString());
            }
        }
    }
}
