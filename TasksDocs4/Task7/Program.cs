/*
Task 7: Fitness Tracker System
Task: Create a class WorkoutSession with:
    1) Fields: exerciseType and durationInMinutes.
    2) Add a method ShowWorkoutDetails().
    3) In Main(), create and display different workout sessions.
*/

using System.Threading.Tasks.Dataflow;

class WorkoutSession
{
    string? _workoutExerciseType;
    string? _workoutDurationInMinutes;
    public string ExerciseType
    {
        get => _workoutExerciseType!;
    }
    public string DurationInMinutes
    {
        get => _workoutDurationInMinutes!;
    }
    public WorkoutSession(string? workoutExerciseType,string? durationInMinutes)
    {
        this._workoutExerciseType = workoutExerciseType;
        this._workoutDurationInMinutes = durationInMinutes; 
    }
    public void ShowWorkoutDetails()
    {
        Console.WriteLine($"ExerciseType: {_workoutExerciseType}\nDurationInMinutes: {_workoutDurationInMinutes}");
    }
    public static WorkoutSession CreateSession()
    {
        Console.Write("Enter exercise type: ");
        string? workoutExerciseType = Console.ReadLine();
        Console.Write("Enter duration in minutes: ");
        string? workoutDurationInMinutes = Console.ReadLine();
        WorkoutSession newSession = new WorkoutSession(workoutExerciseType, workoutDurationInMinutes);

        return newSession;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        WorkoutSession[] mySessions = new WorkoutSession[3];
        for (int i=0; i<mySessions.Length; ++i)
        {
            Console.WriteLine($"Enter information about WorkoutSession {i+1}:");
            mySessions[i] = WorkoutSession.CreateSession();
        }
        Console.WriteLine();
        for (int i=0; i<mySessions.Length; ++i)
        {
            Console.WriteLine("Workout Sessions:");
            mySessions[i].ShowWorkoutDetails();
        }
    }
}