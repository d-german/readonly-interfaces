namespace InterfaceTests;

public interface IHealthcareDocument
{
    /// <summary>
    /// Primary Key
    /// </summary>
    long ID { get; init; }

    /// <summary>
    /// The Document's clinically relevant date
    /// </summary>
    DateTime? ClinicallyRelevantDate { get; init; }

    /// <summary>
    /// The Document's attached date
    /// </summary>
    DateTime? AttachedDate { get; init; }

    /// <summary>
    /// Name of the Facility the document is associated with
    /// </summary>
    string FacilityName { get; init; }

    /// <summary>
    /// Name of the Department the document is associated with
    /// </summary>
    string DepartmentName { get; init; }

    /// <summary>
    /// Auto Display Name for Document
    /// </summary>
    string Name { get; init; }

    /// <summary>
    /// The date/time this document was stored
    /// </summary>
    DateTime? StoredDate { get; init; }

    /// <summary>
    /// The description for this document
    /// </summary>
    string Description { get; init; }

    /// <summary>
    /// A flag determining if the document is restricted
    /// </summary>
    bool IsRestricted { get; init; }
}
