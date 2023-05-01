using RestWithASP_NET5.Model;
using RestWithASP_NET5.Controllers;

namespace RestWithASP_NET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
