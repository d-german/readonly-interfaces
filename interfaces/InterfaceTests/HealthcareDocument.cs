namespace InterfaceTests;

public class HealthcareDocument : IHealthcareDocument
{
    public long ID { get; init; }
    public DateTime? ClinicallyRelevantDate { get; init; }
    public DateTime? AttachedDate { get; init; }
    public string FacilityName { get; init; }
    public string DepartmentName { get; init; }
    public string Name { get; init; }
    public DateTime? StoredDate { get; init; }
    public string Description { get; init; }
    public bool IsRestricted { get; init; }
}
