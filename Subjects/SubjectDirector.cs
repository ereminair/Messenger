using Itmo.ObjectOrientedProgramming.Lab2.AssessmentType;
using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects;

public class SubjectDirector
{
    private readonly Subject.SubjectBuilder _builder;

    public SubjectDirector(Subject.SubjectBuilder builder)
    {
        _builder = builder;
    }

    public Subject ConstructSubject(
        Guid subjectId,
        string subjectName,
        IReadOnlyCollection<Lecture> lectures,
        IReadOnlyCollection<LabWork> labWorks,
        User? author,
        Guid? parentSubjectId,
        TypeExam? assessmentType,
        CountPoint countPoint)
    {
        return _builder
            .WithSubjectName(subjectName)
            .WithLectures(lectures)
            .WithLabWorks(labWorks)
            .WithAuthor(author)
            .WithParentSubjectId(parentSubjectId)
            .WithAssessmentType(assessmentType)
            .WithCountPoint(countPoint.Value)
            .Build();
    }
}