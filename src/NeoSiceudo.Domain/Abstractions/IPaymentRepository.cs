using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.ValueObjects.Payment;

namespace NeoSiceudo.Domain.Abstractions;

public interface IPaymentRepository
{
	Task<IEnumerable<Payment>> GetAllPaymentsAsync(CancellationToken cancellationToken);
	Task<IEnumerable<Payment>> GetPaymentsByUserAsync(User user, CancellationToken cancellationToken);
	Task<IEnumerable<Payment>> GetPaymentsByDate(DateTime date, CancellationToken cancellationToken);
	Task<Payment?> GetPaymentByIdAsync(Guid id, CancellationToken cancellationToken);
	Task<Payment?> GetPaymentByReferenceAsync(Reference reference, CancellationToken cancellationToken);
	Task AddAsync(Payment payment, CancellationToken cancellationToken);
	void Update(Payment payment);
}
