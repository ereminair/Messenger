using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.ResultsType;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial.LectureMaterialChange;

public class LectureChange : ILectureChange
{
    private readonly IRepository<Lecture> _lectureRepository;

    public LectureChange(IRepository<Lecture> subjectRepository)
    {
        _lectureRepository = subjectRepository;
    }

    public ResultType Change(
        string newLectureName,
        string newLectureDescription,
        string newLectureContent,
        User currenAutorId,
        Guid newParentLectureId,
        Lecture lecture)
    {
        if (lecture.AutorId != currenAutorId)
        {
            return new ResultType.ChangeIsNotMadeByAuthor();
        }

        Lecture updateLecture = Lecture.Builder
            .WithAutorId(currenAutorId)
            .WithLectureContent(newLectureContent)
            .WithLectureDescription(newLectureDescription)
            .WithLectureName(newLectureName)
            .WithParentLectureId(newParentLectureId)
            .Build();
        _lectureRepository.Update(updateLecture);
        return new ResultType.Success();
    }
}