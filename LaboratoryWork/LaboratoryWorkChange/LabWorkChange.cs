using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork.LaboratoryWorkChange;

public class LabWorkChange : ILaboratoryWorkChange
{
    private readonly IRepository<LabWork> _labWorkRepository;

    public LabWorkChange(IRepository<LabWork> labWorkRepository)
    {
        _labWorkRepository = labWorkRepository;
    }

    public ResultType Change(
        User currentUser,
        LabWork labWork,
        string newLabName,
        string newLabDescription,
        int newLabEvaluationCriteria,
        int newLabCountPoint,
        Guid newParentLabWorkId)
    {
        if (labWork.AuthorId?.UserId != currentUser.UserId)
        {
            return new ResultType.ChangeIsNotMadeByAuthor();
        }

        LabWork updateLabWork = LabWork.Builder
            .WithLabName(newLabName)
            .WithLabDescription(newLabDescription)
            .WithLabEvaluationCriteria(newLabEvaluationCriteria)
            .WithLabCountPoint(newLabCountPoint)
            .WithAutorId(labWork.AuthorId)
            .WithBaseLabId(newParentLabWorkId)
            .Build();

        _labWorkRepository.Update(updateLabWork);
        return new ResultType.Success();
    }
}