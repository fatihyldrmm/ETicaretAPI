using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(); // Hepsini Getir.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method); // Şarta uygun olanları getir.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method); // Şarta uygun olan ilkini getir.
        Task<T> GetByIdAsync(string id); // İstenilen Id değerine sahip olanı getir.
    }
}
