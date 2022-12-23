using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Reposiries
{
        public interface IStudentRepository
        {
            bool DocumentExists(string document);
            bool EmailExists(string document);
            void CreateSubscription(Student student);
        }
}
