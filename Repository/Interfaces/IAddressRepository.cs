using System;
using Project_Bier.Models;

namespace Project_Bier.Repository
{
    /// <summary>
    /// Interface that describes what kind of methods a Order Repository class
    /// should have.
    /// 
    /// Depency injection is used for the repository pattern. Where we need the product repository
    /// we have a inject an instance of the concrete class: OrderRepository
    /// </summary>
    public interface IAddressRepository
    {
        ShippingAddress GetByGuid(Guid guid);
        void DeleteAddress(Guid guid);
    }
}