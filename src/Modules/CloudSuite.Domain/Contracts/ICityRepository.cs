using CloudSuite.Domain.Models;

namespace CloudSuite.Domain.Contracts
{
    public interface ICityRepository
    {
        Task<City> GetByCItyName(string GetByCItyName);

        Task<IEnumerable<City>> GetList();

        Task Add(City city);

        void Update(City city);

        void Remove(City city);
         
    }
}