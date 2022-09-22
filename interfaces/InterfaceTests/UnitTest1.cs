namespace InterfaceTests;

public class Tests
{
    [Test]
    public void ToggleIsRestrictedTest()
    {
        IHealthcareDocument ToggleIsRestricted(IHealthcareDocument healthcareDocument)
        {
            return new HealthcareDocument
            {
                Description = healthcareDocument.Description,
                Name = healthcareDocument.Name,
                AttachedDate = healthcareDocument.AttachedDate,
                DepartmentName = healthcareDocument.DepartmentName,
                ID = healthcareDocument.ID,
                FacilityName = healthcareDocument.FacilityName,
                StoredDate = healthcareDocument.StoredDate,
                ClinicallyRelevantDate = healthcareDocument.ClinicallyRelevantDate,
                
                // this is the only updated property
                IsRestricted = !healthcareDocument.IsRestricted,
            };
        }

        var restrictedHealthcareDocument = new HealthcareDocument { IsRestricted = true };
        var healthcareDocument = ToggleIsRestricted(restrictedHealthcareDocument);

        Assert.That(healthcareDocument.IsRestricted, Is.False);
    }
}
