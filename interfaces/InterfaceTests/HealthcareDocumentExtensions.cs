namespace InterfaceTests;

public static class HealthcareDocumentExtensions
{
    public static HealthcareDocument ToggleIsRestricted(this HealthcareDocument healthcareDocument)
    {
        return healthcareDocument with { IsRestricted = !healthcareDocument.IsRestricted };
    }
}
