using Tarefa3.Domain.Models;

namespace Tarefa3.Domain.Interfaces.Service
{
    public interface IViaCepService
    {
        Task<PersonAddress> GetAddressByPersonIdAsync(int personId);
    }
}
