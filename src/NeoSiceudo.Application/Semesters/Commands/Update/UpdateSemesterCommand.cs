using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Semesters.Commands.Update;

public sealed record UpdateSemesterCommand(ICollection<int> CoursesSection) : ICommand;
