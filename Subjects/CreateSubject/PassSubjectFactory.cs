﻿using Itmo.ObjectOrientedProgramming.Lab2.AssessmentType;
using Itmo.ObjectOrientedProgramming.Lab2.LaboratoryWork;
using Itmo.ObjectOrientedProgramming.Lab2.LectureMaterial;
using Itmo.ObjectOrientedProgramming.Lab2.Users;

namespace Itmo.ObjectOrientedProgramming.Lab2.Subjects.CreateSubject;

public class PassSubjectFactory : ISubjectFactory
{
    private readonly TypeExam _assessmentType;

    public PassSubjectFactory(TypeExam assessmentType)
    {
        _assessmentType = assessmentType;
    }

    public Subject Create(
        string subjectName,
        User author,
        IReadOnlyCollection<Lecture> lectures,
        IReadOnlyCollection<LabWork> labWorks,
        Guid parentSubjectId,
        decimal countPoint)
    {
        return Subject.Builder
            .WithSubjectName(subjectName)
            .WithAuthor(author)
            .WithLectures(lectures)
            .WithLabWorks(labWorks)
            .WithParentSubjectId(parentSubjectId)
            .WithAssessmentType(_assessmentType)
            .WithCountPoint(countPoint)
            .Build();
    }
}