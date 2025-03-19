using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;

public class LabWorkDirector
{
    private readonly LabWork.LabWorkBuilder _builder;

    public LabWorkDirector(LabWork.LabWorkBuilder builder)
    {
        _builder = builder;
    }

    public LabWork ConstructLabWork(
        string name,
        string description,
        int evaluationCriteria,
        int maxPoints,
        User authorId,
        Guid parentLaboratoryWorkId)
    {
        return _builder
            .WithLabName(name)
            .WithLabDescription(description)
            .WithLabEvaluationCriteria(evaluationCriteria)
            .WithLabCountPoint(maxPoints)
            .WithAutorId(authorId)
            .WithBaseLabId(parentLaboratoryWorkId)
            .Build();
    }
}