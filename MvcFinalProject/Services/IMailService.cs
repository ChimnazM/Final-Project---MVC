using MvcFinalProject.Models;
using System.Threading.Tasks;

namespace EduHome.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
