namespace InterfaceTests;

public class Tests
{
    [Test]
    public void LspOcpViolation()
    {
        IHealthcareDocument ToggleIsRestricted(IHealthcareDocument healthcareDocument)
        {
            if (healthcareDocument is HealthcareDocument restrictedHealthcareDocument)
            {
                restrictedHealthcareDocument.IsRestricted = !restrictedHealthcareDocument.IsRestricted;
            }

            return healthcareDocument;
        }

        var restrictedHealthcareDocument = new HealthcareDocument { IsRestricted = true };
        var healthcareDocument = ToggleIsRestricted(restrictedHealthcareDocument);

        Assert.That(healthcareDocument.IsRestricted, Is.False);
    }
}
