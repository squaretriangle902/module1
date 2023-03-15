using Module2.Task3;

namespace Module2.Task5
{
    internal class Employee : User
    {
        private int workExperienceInYears;
        private string post;

        internal Employee(string name, string surname, string patronymic, string post, int workExperienceInYears,
            DateTime birthDate)
            : base(name, surname, patronymic, birthDate)
        {
            Post = post;
            WorkExperienceInYears = workExperienceInYears;
        }

        internal int WorkExperienceInYears
        {
            get { return workExperienceInYears; }
            set
            {
                if (value > Age.year)
                {
                    throw new ArgumentException("Work experience cannot be greater than age");
                }
                workExperienceInYears = value;
            }
        }

        internal string Post { get { return post; } set { post = value; } }
    }
}
