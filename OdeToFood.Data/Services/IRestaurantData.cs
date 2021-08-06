using System.Collections.Generic;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}