using RestSharp;
using Tarefa3.Data.Rest.Repository;
using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;

namespace Tarefa3.Application.Services
{
    public class ViaCepService : IViaCepService
    {
        private readonly ViaCepRepository _viaCepRepository;
        private readonly List<Person> _people = new List<Person>
            {
                new Person { Id = 1, Name = "Leonardo Tristao", Age = 19, Cep = "13024-050" },
                new Person { Id = 2, Name = "Hyan Schibelsky", Age = 18, Cep = "11020-303"},
                new Person { Id = 3, Name = "Kairos Murilo", Age = 18, Cep = "" },
                new Person { Id = 4, Name = "Andre Barros", Age = 19},
                new Person { Id = 5, Name = "Felipe Coelho", Age = 19, Cep = "13024200"}
            };

        public ViaCepService(ViaCepRepository viaCepRepository)
        {
            _viaCepRepository = viaCepRepository;
        }

        public async Task<PersonAddress> GetAddressByPersonIdAsync(int personId)
        {
            var person = _people.FirstOrDefault(p => p.Id == personId);
            if (person == null)
                throw new Exception("Usuario não encontrado.");

            if (string.IsNullOrWhiteSpace(person.Cep))
                throw new Exception("CEP do usuario está vazio.");

            var address = await _viaCepRepository.GetAddressByPersonIdAsync(person.Cep);
            return new Domain.Models.PersonAddress
            {
                cep = address.cep,
                logradouro = address.logradouro,
                bairro = address.bairro,
                localidade = address.localidade,
                uf = address.uf,
                estado = address.estado
            };
        }
    }
}
