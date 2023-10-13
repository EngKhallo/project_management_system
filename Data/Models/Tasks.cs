namespace ProjectMgtSystemApi.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime AssignedDate { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = "Initial";
        public int AssignedUserId { get; set; }
        public Users? AssignedUser { get; set; }
        public int ProjectId { get; set; }
        public Projects? Project { get; set; }

    }
}