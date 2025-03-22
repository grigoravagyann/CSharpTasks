using CourseN;
using GroupN;

namespace CourseGroupModule
{
    static class Methods
    {
        public static void WebStudentsCount(Group[] groups)
        {
            int webStudents = 0;
            foreach (Group group in groups)
            {
                foreach (Course course in group.Courses)
                {
                    if (course is Web)
                    {
                        webStudents += group.StudentsNumber;
                        break;
                    }
                }
            }
            Console.WriteLine($"Number of students studying Web: {webStudents}");
        }
        public static void GameDevUnrealSavings(Group[] groups)
        {
            double savings = 0;
            foreach (Group group in groups)
            {
                foreach (Course course in group.Courses)
                {
                    if (course is Game game && game.Engine.ToLower() == "unreal")
                    {
                        savings += group.StudentsNumber * game.MonthlyFee;
                        break;
                    }
                }
            }
            Console.WriteLine($"Savings from Game Dev Unreal students: {savings}");
        }
        public static void MostPopularCourse(Group[] groups)
        {
            int web = 0;
            int game = 0;
            int ai = 0;
            foreach (Group group in groups)
            {
                foreach (Course course in group.Courses)
                {
                    if (course is Web)
                    {
                        web += group.StudentsNumber;
                    }
                    else if (course is Game)
                    {
                        game += group.StudentsNumber;
                    }
                    else if (course is AI)
                    {
                        ai += group.StudentsNumber;
                    }
                }
            }
            string mostPopularCourse = web > game ? (web > ai ? "Web" : "AI") : (game > ai ? "Game" : "AI");
            Console.WriteLine($"Most popular course is: {mostPopularCourse}");
        }
    }
}
