
namespace CourseGroupModule
{
    class Module : Course
    {
        public string Title { get; private set; }
        public int Duration { get; private set; }
        public Module(string Title, int Duration) : base()
        {
            this.Title = Title;
            this.Duration = Duration;
        }
    }
}
