using quotingdojo.Models;
using System.Collections.Generic;
namespace quotingdojo.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}