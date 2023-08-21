namespace ProjectsAPI.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public ProjectGroup[] Groups { get; set; }
    }
}
