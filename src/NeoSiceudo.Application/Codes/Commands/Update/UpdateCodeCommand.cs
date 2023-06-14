using NeoSiceudo.Application.Abstractions.Messaging;

namespace NeoSiceudo.Application.Codes.Commands.Update;

public sealed record UpdateCodeCommand(bool Taken) : ICommand;