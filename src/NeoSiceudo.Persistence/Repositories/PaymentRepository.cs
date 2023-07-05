using Microsoft.EntityFrameworkCore;
using NeoSiceudo.Domain.Abstractions;
using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;
using NeoSiceudo.Domain.ValueObjects.Payment;

namespace NeoSiceudo.Persistence.Repositories;

public class PaymentRepository : IPaymentRepository
{
	private readonly ApplicationDbContext _context;

	public PaymentRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task AddAsync(Payment payment, CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.AddAsync(payment, cancellationToken);

	public async Task<IEnumerable<Payment>> GetAllPaymentsAsync(CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.ToListAsync(cancellationToken);

	public async Task<Payment?> GetPaymentByIdAsync(Guid id, CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.Where(p => p.Id == id)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<Payment?> GetPaymentByReferenceAsync(Reference reference, CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.Where(p => p.Reference == reference)
			.FirstOrDefaultAsync(cancellationToken);

	public async Task<IEnumerable<Payment>> GetPaymentsByDate(DateTime date, CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.Where(c => c.PerformedOn == date)
			.ToListAsync(cancellationToken);

	public async Task<IEnumerable<Payment>> GetPaymentsByStudentAsync(Student student, CancellationToken cancellationToken) =>
		await _context
			.Set<Payment>()
			.Where(p => p.PaymentStudent == student)
			.ToListAsync(cancellationToken);
}
