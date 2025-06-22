using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Person;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IPersonService : IGenericService<PersonVM, Person>
    {
        Task<PersonVM> GetPersonByEmailAsync(string email);
        Task<IEnumerable<PersonVM>> GetPersonsByRoleAsync(string role); // Yeni eklendi
    }
}
