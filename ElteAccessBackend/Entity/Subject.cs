using System.ComponentModel.DataAnnotations;

namespace ElteAccessBackend.Entity;

public class Subject
{
    [Key] public required string SubjectCode{ get; set; }
    public required int Credits { get; set; }
    public string SubjectName { get; set; }
}