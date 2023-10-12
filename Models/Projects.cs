namespace ProjectMgtSystemApi.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Initial";
        public int ProjectManagerId { get; set; }
        public Users? ProjectManager { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}