namespace InterfaceTests;

public interface IHealthcareDocument
{
    /// <summary>
    /// Primary Key
    /// </summary>
    long ID { get; }

    /// <summary>
    /// The Document's clinically relevant date
    /// </summary>
    DateTime? ClinicallyRelevantDate { get; }

    /// <summary>
    /// The Document's attached date
    /// </summary>
    DateTime? AttachedDate { get; }

    /// <summary>
    /// Name of the Facility the document is associated with
    /// </summary>
    string FacilityName { get; }

    /// <summary>
    /// Name of the Department the document is associated with
    /// </summary>
    string DepartmentName { get; }

    /// <summary>
    /// Auto Display Name for Document
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The date/time this document was stored
    /// </summary>
    DateTime? StoredDate { get; }

    /// <summary>
    /// The description for this document
    /// </summary>
    string Description { get; }

    /// <summary>
    /// A flag determining if the document is restricted
    /// </summary>
    bool IsRestricted { get; }
}
