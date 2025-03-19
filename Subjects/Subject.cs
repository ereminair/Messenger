using Itmo.ObjectOrientedProgramming.Lab2.AssessmentType;
using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects;

public class Subject : IEntity
{
    private Subject(
        string subjectName,
        IReadOnlyCollection<Lecture> lectures,
        IReadOnlyCollection<LabWork> labWorks,
        User? author,
        Guid? parentSubjectId,
        TypeExam? assessmentType,
        CountPoint countPoint)
    {
        SubjectId = Guid.NewGuid();
        SubjectName = subjectName;
        Lectures = lectures;
        LabWorks = labWorks;
        Author = author;
        ParentSubjectId = parentSubjectId;
        AssessmentType = assessmentType;
        CountPoint = countPoint;
    }

    public static SubjectBuilder Builder => new SubjectBuilder();

    public Guid SubjectId { get; }

    public string SubjectName { get; }

    public IReadOnlyCollection<Lecture> Lectures { get; }

    public IReadOnlyCollection<LabWork> LabWorks { get; }

    public User? Author { get; }

    public Guid? ParentSubjectId { get; }

    public TypeExam? AssessmentType { get; }

    public CountPoint CountPoint { get; }

    public Guid Id => SubjectId;

    public Subject Clone(User? newAuthor)
    {
        return new Subject(
            SubjectName,
            Lectures,
            LabWorks,
            newAuthor ?? Author,
            SubjectId,
            AssessmentType,
            CountPoint);
    }

    public class SubjectBuilder
    {
        private string _subjectName = string.Empty;
        private IReadOnlyCollection<Lecture> _lectures = new List<Lecture>();
        private IReadOnlyCollection<LabWork> _labWorks = new List<LabWork>();
        private User? _author;
        private Guid? _parentSubjectId;
        private TypeExam? _assessmentType;
        private CountPoint _countPoint;

        public SubjectBuilder WithSubjectName(string subjectName)
        {
            _subjectName = subjectName;
            return this;
        }

        public SubjectBuilder WithLectures(IReadOnlyCollection<Lecture> lectures)
        {
            _lectures = lectures;
            return this;
        }

        public SubjectBuilder WithLabWorks(IReadOnlyCollection<LabWork> labWorks)
        {
             _labWorks = labWorks;
             return this;
        }

        public SubjectBuilder WithAuthor(User? author)
        {
             _author = author;
             return this;
        }

        public SubjectBuilder WithParentSubjectId(Guid? parentSubjectId)
        {
            _parentSubjectId = parentSubjectId;
            return this;
        }

        public SubjectBuilder WithAssessmentType(TypeExam? assessmentType)
        {
            _assessmentType = assessmentType;
            return this;
        }

        public SubjectBuilder WithCountPoint(decimal countPoint)
        {
            _countPoint = new CountPoint(countPoint);
            return this;
        }

        public Subject Build()
        {
            return new Subject(
                _subjectName,
                _lectures,
                _labWorks,
                _author,
                _parentSubjectId,
                _assessmentType,
                _countPoint);
        }
    }
}