using NeoSiceudo.Domain.Entities;
using NeoSiceudo.Domain.Primitives;

namespace NeoSiceudo.Application.Abstractions;

public interface IEmailService
{
	Task SendRegistrationEmailAsync(User user, CancellationToken cancellationToken);
	Task SendGeneratedVerificationCodeEmailAsync(User user, VerificationCode verificationCode, CancellationToken cancellationToken);
	Task SendInscriptionReminderEmailAsync(User user, CancellationToken cancellationToken);
	Task SendInscriptionInformationEmailAsync(User user, Semester semester, CancellationToken cancellationToken);
	Task SendResponseEmailAsync(User user, string message, CancellationToken cancellationToken);
	Task SendImportantNewsEmailAsync(User user, CancellationToken cancellationToken);
}
