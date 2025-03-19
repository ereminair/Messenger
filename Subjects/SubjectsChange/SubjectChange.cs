using Itmo.ObjectOrientedProgramming.Lab2.AssessmentType;
using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects.SubjectsChange;

public class SubjectChange : ISubjectChange
{
    private readonly IRepository<Subject> _subjectRepository;

    public SubjectChange(IRepository<Subject> subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }

    public ResultType Change(
        string newSubjectName,
        IReadOnlyCollection<Lecture> newLectures,
        IReadOnlyCollection<LabWork> newLabWorks,
        User currentAuthor,
        Guid newParentSubjectId,
        TypeExam newAssessmentType,
        decimal newCountPoint,
        Subject subject)
    {
        if (subject.Author != currentAuthor)
        {
            return new ResultType.ChangeIsNotMadeByAuthor();
        }

        Subject updateSubject = Subject.Builder
            .WithSubjectName(newSubjectName)
            .WithLectures(newLectures)
            .WithLabWorks(newLabWorks)
            .WithAuthor(currentAuthor)
            .WithParentSubjectId(newParentSubjectId)
            .WithAssessmentType(newAssessmentType)
            .WithCountPoint(newCountPoint)
            .Build();
        _subjectRepository.Update(updateSubject);
        return new ResultType.Success();
    }
}