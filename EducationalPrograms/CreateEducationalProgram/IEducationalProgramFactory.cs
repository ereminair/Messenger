using Itmo.ObjectOrientedProgramming.Lab2.Semester;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.EducationalPrograms.CreateEducationalProgram;

public interface IEducationalProgramFactory
{
    public EducationalProgram Create(
        string programName,
        User programLeader,
        IReadOnlyCollection<SubjectWithSemester> subjects);
}