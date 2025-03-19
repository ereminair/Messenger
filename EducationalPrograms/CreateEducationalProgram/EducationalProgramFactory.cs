using Itmo.ObjectOrientedProgramming.Lab2.Semester;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.EducationalPrograms.CreateEducationalProgram;

public class EducationalProgramFactory
{
    public EducationalProgram Create(
        string programName,
        User programLeader,
        IReadOnlyCollection<SubjectWithSemester> subjects)
    {
        return EducationalProgram.Builder
            .WithProgramName(programName)
            .WithProgramLeader(programLeader)
            .WithSubjects(subjects)
            .Build();
    }
}