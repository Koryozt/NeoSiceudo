using NeoSiceudo.Domain.Entities;

namespace NeoSiceudo.Application.Abstractions;

public interface IJwtProvider
{
	string Generate(User user);
}
