/*
 Create, Course, Group, Module classes where:
    Course - contains information about the course (name, monthly fee, modules).
    Module - contains information about a separate part of the course (title, duration).
    Group - Represents group data (name, number of students, course).
    Web, Game, AI classes are inherited from the Course class whereas Web also has a type field,
    which can be frontend, backend, fullstack.
    Game has an engine field, which can be unity, unreal.
    The relationship between Course,Module and Group, Course is has a, and Course=>Web,Game,Ai is a.

 Methods:
    1) Find the number of students studying web.
    2) Find how much money will be saved in a month from the amount paid by students studying Game Dev within the Unreal engine.
    3) Find the most popular course (by number of students).
 */

using CourseN;
using ModuleN;
using GroupN;
using CourseGroupModule;
class Program
{
    static void Main()
    {
        Course[] courses = new Course[]
        {
            new Web("Frontend Development", 500000, "frontend", new Module[]
            {
                new Module("HTML & CSS", 2), new Module("JavaScript", 3)
            }),
            new Web("Fullstack Development", 60000, "fullstack", new Module[]
            {
                new Module("Node.js", 4), new Module("React", 5)
            }),
            new AI("Machine Learning", 80000, new Module[]
            {
                new Module("Python for AI", 6), new Module("Deep Learning", 8)
            }),
            new Game("Game Development", 72000, "Unity", new Module[]
            {
                new Module("C# for Unity", 5), new Module("Physics in Games", 4)
            }),
            new Game("Game Dev Advanced", 42000, "Unreal", new Module[]
            {
                new Module("Blueprints", 6), new Module("C++ for Unreal", 7)
            })
        };
        Group[] groups = new Group[]
        {
            new Group("Frontend Group 1", 15, courses[0]),   // Frontend Development
            new Group("Fullstack Group 1", 12, courses[1]),  // Fullstack Development
            new Group("AI Group 1", 10, courses[2]),         // Machine Learning
            new Group("Game Dev Group 1", 20, courses[3]),   // Unity Game Development
            new Group("Game Dev Group 2", 18, courses[4])    // Unreal Game Development
        };

        Methods.WebStudentsCount(groups); // 1)
        Methods.GameDevUnrealSavings(groups); // 2)
        Methods.MostPopularCourse(groups); // 3) 

        Console.ReadKey();
    }
}