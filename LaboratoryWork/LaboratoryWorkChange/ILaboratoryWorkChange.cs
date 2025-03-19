using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork.LaboratoryWorkChange;

public interface ILaboratoryWorkChange
{
    public ResultType Change(
        User currentUser,
        LabWork labWork,
        string newLabName,
        string newLabDescription,
        int newLabEvaluationCriteria,
        int newLabCountPoint,
        Guid newParentLabWorkId);
}