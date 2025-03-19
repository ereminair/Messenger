using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;

public class LectureDirector
{
    private readonly Lecture.LectureBuilder _builder;

    public LectureDirector(Lecture.LectureBuilder builder)
    {
        _builder = builder;
    }

    public Lecture ConstructLecture(
        string name,
        string description,
        string content,
        User authorId,
        Guid? parentLectureId)
    {
        return _builder
            .WithLectureName(name)
            .WithLectureDescription(description)
            .WithLectureContent(content)
            .WithAutorId(authorId)
            .WithParentLectureId(parentLectureId)
            .Build();
    }
}