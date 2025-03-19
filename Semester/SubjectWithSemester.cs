using Itmo.ObjectOrientedProgramming.Lab2.Subjects;

namespace Itmo.ObjectOrientedProgramming.Lab2.Semester;

public class SubjectWithSemester
{
    public Subject Subject { get; }

    public int Semester { get; }

    public SubjectWithSemester(Subject subject, int semester)
    {
        Subject = subject;
        Semester = semester;
    }
}
