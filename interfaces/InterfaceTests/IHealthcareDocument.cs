namespace InterfaceTests;

public interface IHealthcareDocument
{
    /// <summary>
    /// Primary Key
    /// </summary>
    long ID { get; set; }

    /// <summary>
    /// The Document's clinically relevant date
    /// </summary>
    DateTime? ClinicallyRelevantDate { get; set; }

    /// <summary>
    /// The Document's attached date
    /// </summary>
    DateTime? AttachedDate { get; set; }

    /// <summary>
    /// Name of the Facility the document is associated with
    /// </summary>
    string FacilityName { get; set; }

    /// <summary>
    /// Name of the Department the document is associated with
    /// </summary>
    string DepartmentName { get; set; }

    /// <summary>
    /// Auto Display Name for Document
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// The date/time this document was stored
    /// </summary>
    DateTime? StoredDate { get; set; }

    /// <summary>
    /// The description for this document
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// A flag determining if the document is restricted
    /// </summary>
    bool IsRestricted { get; set; }
}
