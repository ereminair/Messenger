using Itmo.ObjectOrientedProgramming.Lab2.AssessmentType;
using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects.SubjectsChange;

public interface ISubjectChange
{
    public ResultType Change(
        string newSubjectName,
        IReadOnlyCollection<Lecture> newLectures,
        IReadOnlyCollection<LabWork> newLabWorks,
        User currentAuthor,
        Guid newParentSubjectId,
        TypeExam newAssessmentType,
        decimal newCountPoint,
        Subject subject);
}