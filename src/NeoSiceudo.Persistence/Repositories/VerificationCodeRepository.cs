using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.VerificationCode;

namespace NeoSiceudo.Persistence.Repositories;

public class VerificationCodeRepository : IVerificationCodeRepository
{
	private readonly ApplicationDbContext _context;

	public VerificationCodeRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(VerificationCode verificationCode, CancellationToken cancellationToken) =>
		await _context
			.Set<VerificationCode>()
			.AddAsync(verificationCode, cancellationToken);

	public async Task<IEnumerable<VerificationCode>> GetAllVerificationCodesAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<VerificationCode>()
			.ToListAsync(cancellationToken);

	public async Task<VerificationCode?> GetVerificationCodeByCombinationAsync(
		Combination combination,
		CancellationToken cancellationToken) =>
		await _context
			.Set<VerificationCode>()
			.Where(v => v.Combination == combination)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<VerificationCode?> GetVerificationCodeByIdAsync(
		Guid id,
		CancellationToken cancellationToken) =>
		await _context
			.Set<VerificationCode>()
			.Where(v => v.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public void Update(VerificationCode verificationCode) =>
		_context
			.Set<VerificationCode>()
			.Update(verificationCode);
}
