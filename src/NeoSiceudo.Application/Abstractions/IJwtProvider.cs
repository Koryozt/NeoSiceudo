using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Application.Abstractions;

public interface IJwtProvider
{
	string Generate(User user);
}
