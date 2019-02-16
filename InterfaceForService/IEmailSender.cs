using System.Threading.Tasks;

namespace EducateMeForums.InterfaceForService
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
