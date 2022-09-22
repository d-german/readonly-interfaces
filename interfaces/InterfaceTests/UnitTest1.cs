namespace InterfaceTests;

public class Tests
{
    [Test]
    public void ToggleIsRestrictedTest()
    {
        IHealthcareDocument ToggleIsRestricted(IHealthcareDocument healthcareDocument)
        {
            healthcareDocument.IsRestricted = !healthcareDocument.IsRestricted;

            return healthcareDocument;
        }

        var restrictedHealthcareDocument = new HealthcareDocument { IsRestricted = true };
        var healthcareDocument = ToggleIsRestricted(restrictedHealthcareDocument);

        Assert.That(healthcareDocument.IsRestricted, Is.False);
    }
}
