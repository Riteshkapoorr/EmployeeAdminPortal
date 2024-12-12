namespace EmployeeAdminPortal.Model.Entities
{
    public class Task
    {
        public required Label Label { get; set; }
        public required string Name { get; set; }

        public string? Desc { get; set; }
        public required DateTime DateAdded { get; set; }
    }
}
