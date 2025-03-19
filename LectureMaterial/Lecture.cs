using Itmo.ObjectOrientedProgramming.Lab2.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;

public class Lecture : IEntity
{
    private Lecture(
        string lectureName,
        string lectureDescription,
        string lectureContent,
        User? autorId,
        Guid? parentLectureId)
    {
        LectureId = Guid.NewGuid();
        LectureName = lectureName;
        LectureDescription = lectureDescription;
        LectureContent = lectureContent;
        AutorId = autorId;
        ParentLectureId = parentLectureId;
    }

    public static LectureBuilder Builder => new LectureBuilder();

    public Guid LectureId { get; }

    public string LectureName { get; }

    public string LectureDescription { get; }

    public string LectureContent { get; }

    public User? AutorId { get; }

    public Guid? ParentLectureId { get; }

    public Guid Id => LectureId;

    public Lecture Clone(User? newAutorId)
    {
        return new Lecture(
            LectureName,
            LectureDescription,
            LectureContent,
            newAutorId ?? AutorId,
            LectureId);
    }

    public class LectureBuilder
    {
        private string _lectureName = string.Empty;
        private string _lectureDescription = string.Empty;
        private string _lectureContent = string.Empty;
        private User? _autorId;
        private Guid? _parentLectureId;

        public LectureBuilder WithLectureName(string lectureName)
        {
            _lectureName = lectureName;
            return this;
        }

        public LectureBuilder WithLectureDescription(string lectureDescription)
        {
            _lectureDescription = lectureDescription;
            return this;
        }

        public LectureBuilder WithLectureContent(string lectureContent)
        {
            _lectureContent = lectureContent;
            return this;
        }

        public LectureBuilder WithAutorId(User? autorId)
        {
            _autorId = autorId;
            return this;
        }

        public LectureBuilder WithParentLectureId(Guid? parentLectureId)
        {
            _parentLectureId = parentLectureId;
            return this;
        }

        public Lecture Build()
        {
            return new Lecture(
                _lectureName,
                _lectureDescription,
                _lectureContent,
                _autorId,
                _parentLectureId);
        }
    }
}