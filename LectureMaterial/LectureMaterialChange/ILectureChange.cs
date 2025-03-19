using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial.LectureMaterialChange;

public interface ILectureChange
{
    public ResultType Change(
        string newLectureName,
        string newLectureDescription,
        string newLectureContent,
        User currenAutorId,
        Guid newParentLectureId,
        Lecture lecture);
}