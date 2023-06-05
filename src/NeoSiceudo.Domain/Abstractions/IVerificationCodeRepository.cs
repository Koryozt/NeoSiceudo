using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Domain.Abstractions;

public interface IVerificationCodeRepository
{
	Task<IEnumerable<VerificationCode>> GetAllVerificationCodesAsync(CancellationToken cancellationToken);
	Task<VerificationCode?> GetVerificationCodeByCombinationAsync(Combination combination, CancellationToken cancellationToken);
	Task<VerificationCode?> GetVerificationCodeByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<bool> IsCodeValidAsync(VerificationCode verificationCode, CancellationToken cancellationToken);
	Task AddAsync(VerificationCode verificationCode, CancellationToken cancellationToken);
	void Update(VerificationCode verificationCode);
}
