using Itmo.ObjectOrientedProgramming.Lab2.Semester;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.EducationalPrograms;

public class EducationalProgramDirector
{
    private readonly EducationalProgram.EducationalProgramBuilder _builder;

    public EducationalProgramDirector(EducationalProgram.EducationalProgramBuilder builder)
    {
        _builder = builder;
    }

    public EducationalProgram ConstructEducationalProgram(
        string programName,
        User programLeader,
        IReadOnlyCollection<SubjectWithSemester> subjects)
    {
        return _builder
            .WithProgramName(programName)
            .WithProgramLeader(programLeader)
            .WithSubjects(subjects)
            .Build();
    }
}