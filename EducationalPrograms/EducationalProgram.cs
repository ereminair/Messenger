using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Semester;
using Itmo.ObjectOrientedProgramming.Lab2.Subjects;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.EducationalPrograms;

public class EducationalProgram : IEntity
{
    private EducationalProgram(
        string programName,
        User? programLeader,
        IReadOnlyCollection<SubjectWithSemester> subjects)
    {
        ProgramId = Guid.NewGuid();
        ProgramName = programName;
        ProgramLeader = programLeader;
        Subjects = subjects ?? new List<SubjectWithSemester>();
    }

    public static EducationalProgramBuilder Builder => new EducationalProgramBuilder();

    public Guid ProgramId { get; }

    public string ProgramName { get; }

    public User? ProgramLeader { get; }

    public IReadOnlyCollection<SubjectWithSemester> Subjects { get; }

    public Guid Id => ProgramId;

    public EducationalProgram Clone(
        EducationalProgram educationalProgram,
        User? newProgramLeader)
    {
        return new EducationalProgram(
            educationalProgram.ProgramName,
            newProgramLeader ?? educationalProgram.ProgramLeader,
            educationalProgram.Subjects);
    }

    public class EducationalProgramBuilder
    {
        private string _programName = string.Empty;
        private User? _programLeader;
        private List<SubjectWithSemester> _subjects = new List<SubjectWithSemester>();

        public EducationalProgramBuilder WithProgramName(string programName)
        {
            _programName = programName;
            return this;
        }

        public EducationalProgramBuilder WithProgramLeader(User? programLeader)
        {
            _programLeader = programLeader;
            return this;
        }

        public EducationalProgramBuilder WithSubjects(IReadOnlyCollection<SubjectWithSemester> subjects)
        {
            _subjects = subjects.ToList();
            return this;
        }

        public EducationalProgramBuilder AddSubject(Subject subject, int semester)
        {
            _subjects.Add(new SubjectWithSemester(subject, semester));
            return this;
        }

        public EducationalProgram Build()
        {
            return new EducationalProgram(
                _programName,
                _programLeader,
                _subjects);
        }
    }
}
