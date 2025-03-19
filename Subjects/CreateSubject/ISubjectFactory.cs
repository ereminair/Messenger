using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects.CreateSubject;

public interface ISubjectFactory
{
    public Subject Create(
        string subjectName,
        User author,
        IReadOnlyCollection<Lecture> lectures,
        IReadOnlyCollection<LabWork> labWorks,
        Guid parentSubjectId,
        decimal countPoint);
}