namespace InterfaceTests;

public class Tests
{
    [Test]
    public void ToggleIsRestrictedTest()
    {
        HealthcareDocument ToggleIsRestricted(HealthcareDocument healthcareDocument)
        {
            return healthcareDocument with { IsRestricted = !healthcareDocument.IsRestricted };
        }

        var restrictedHealthcareDocument = new HealthcareDocument { IsRestricted = true };
        var healthcareDocument = ToggleIsRestricted(restrictedHealthcareDocument);

        Assert.That(healthcareDocument.IsRestricted, Is.False);
    }
}
