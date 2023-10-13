using ProjectMgtSystemApi.Models;

namespace ProjectMgtSystemApi.Data.Dto.Projects
{
    public class GetProjectsDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Initial";
        public int ProjectManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}