
namespace CourseGroupModule
{
    class Course
    {
        public string Name { get; protected set; }
        public double MonthlyFee { get; protected set; }
        public Module[] Modules { get; protected set; }
        object courseType;
        public Course() { }
        public Course(string Name, double MonthlyFee, Module[] Modules)
        {
            this.Name = Name;
            this.MonthlyFee = MonthlyFee;
            this.Modules = Modules;
        }
        public Course(Web web)
        {
            this.Name = web.Name;
            this.MonthlyFee = web.MonthlyFee;
            this.Modules = web.Modules;
            courseType = (Web)courseType;
        }
        public Course(Game game)
        {
            this.Name = game.Name;
            this.MonthlyFee = game.MonthlyFee;
            this.Modules = game.Modules;
            courseType = (Game)courseType;
        }
        public Course(AI ai)
        {
            this.Name = ai.Name;
            this.MonthlyFee = ai.MonthlyFee;
            this.Modules = ai.Modules;
            courseType = (AI)courseType;
        }

    }
    class Web : Course
    {
        public string Type { get; private set; }
        public Web(string Name, double MonthlyFee, string Type, params Module[] Modules) : base(Name, MonthlyFee, Modules)
        {
            this.Type = Type;

        }
    }
    class Game : Course
    {
        public string Engine { get; private set; }
        public Game(string Name, double MonthlyFee, string Engine, Module[] Modules) : base(Name, MonthlyFee, Modules)
        {
            this.Engine = Engine;
        }
    }
    class AI : Course
    {
        public AI(string Name, double MonthlyFee, Module[] Modules) : base(Name, MonthlyFee, Modules) { }
    }
}
