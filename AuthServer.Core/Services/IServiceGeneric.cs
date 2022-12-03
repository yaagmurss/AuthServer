using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IServiceGeneric<TEntity, TDto> where TDto : class where TEntity : class
    {
        Task<ResponseDto<TDto>> GetByIdAsync(int id);
        Task<ResponseDto<IEnumerable<TDto>>> GetAllAsync();
        Task<ResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> perdicate);
        Task<ResponseDto<TDto>> AddAsync(TDto entity);
        Task<ResponseDto<NoDataDto>> Remove(int id);
        Task<ResponseDto<NoDataDto>> Update(TDto entity, int id);

    }
}
