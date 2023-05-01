using RestWithASP_NET5.Model;
using RestWithASP_NET5.Controllers;

namespace RestWithASP_NET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindByAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
