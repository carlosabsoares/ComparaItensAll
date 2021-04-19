using BlazorAppBuscaItens.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Infra.Interface
{
    public interface IManufacturerRepository
    {
        Task<IList<Manufacturer>> GetAll();

        Task<Manufacturer> GetById();

        Task<bool> Add(Manufacturer manufacturer);
    }
}