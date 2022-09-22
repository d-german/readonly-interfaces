namespace InterfaceTests;

public class HealthcareDocument : IHealthcareDocument
{
    public long ID { get; set; }
    public DateTime? ClinicallyRelevantDate { get; set; }
    public DateTime? AttachedDate { get; set; }
    public string FacilityName { get; set; }
    public string DepartmentName { get; set; }
    public string Name { get; set; }
    public DateTime? StoredDate { get; set; }
    public string Description { get; set; }
    public bool IsRestricted { get; set; }
}