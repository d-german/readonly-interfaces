namespace InterfaceTests;

public class Tests
{
    [Test]
    public void ToggleIsRestrictedTest()
    {
        var restrictedHealthcareDocument = new HealthcareDocument { IsRestricted = true };
        var healthcareDocument = restrictedHealthcareDocument.ToggleIsRestricted();

        Assert.That(healthcareDocument.IsRestricted, Is.False);
    }
}
