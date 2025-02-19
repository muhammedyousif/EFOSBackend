using ElteAccessBackend.Dtos;
using ElteAccessBackend.Dtos.Objects;
using ElteAccessBackend.Entity;

namespace ElteAccessBackend.Mapping;

public static class SubjectMapping
{
    public static SubjectsDto ToDto(this Subject subject)
    {
        SubjectsDto newSubject = new SubjectsDto(subject.SubjectCode,subject.Credits,subject.SubjectName);
        return newSubject;
    }
}