using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;

public class LabWork : IEntity
{
    private LabWork(
        string name,
        string description,
        int evaluationCriteria,
        int maxPoints,
        User? authorId,
        Guid parentLaboratoryWorkId)
    {
        LabId = Guid.NewGuid();
        LabName = name;
        LabDescription = description;
        LabEvaluationCriteria = evaluationCriteria;
        LabCountPoint = maxPoints;
        AuthorId = authorId;
        ParentLaboratoryWorkId = parentLaboratoryWorkId;
    }

    public static LabWorkBuilder Builder => new LabWorkBuilder();

    public Guid LabId { get; }

    public string LabName { get; }

    public string LabDescription { get; }

    public int LabEvaluationCriteria { get; }

    public int LabCountPoint { get; }

    public User? AuthorId { get; }

    public Guid? ParentLaboratoryWorkId { get; }

    public Guid Id => LabId;

    public LabWork Clone(User? newAuthorId)
    {
        return new LabWork(
            LabName,
            LabDescription,
            LabEvaluationCriteria,
            LabCountPoint,
            newAuthorId ?? AuthorId,
            LabId);
    }

    public class LabWorkBuilder
    {
        private string _labName = string.Empty;
        private string _labDescription = string.Empty;
        private int _labEvaluationCriteria;
        private int _labCountPoint;
        private User? _autorId;
        private Guid _parentLaboratoryWorkId;

        public LabWorkBuilder WithLabName(string labName)
        {
            _labName = labName;
            return this;
        }

        public LabWorkBuilder WithLabDescription(string labDescription)
        {
            _labDescription = labDescription;
            return this;
        }

        public LabWorkBuilder WithLabCountPoint(int labCountPoint)
        {
            _labCountPoint = labCountPoint;
            return this;
        }

        public LabWorkBuilder WithLabEvaluationCriteria(int labEvaluationCriteria)
        {
            _labEvaluationCriteria = labEvaluationCriteria;
            return this;
        }

        public LabWorkBuilder WithAutorId(User autorId)
        {
            _autorId = autorId;
            return this;
        }

        public LabWorkBuilder WithBaseLabId(Guid parentLaboratoryWorkId)
        {
            _parentLaboratoryWorkId = parentLaboratoryWorkId;
            return this;
        }

        public LabWork Build()
        {
            return new LabWork(
                _labName,
                _labDescription,
                _labEvaluationCriteria,
                _labCountPoint,
                _autorId,
                _parentLaboratoryWorkId);
        }
    }
}