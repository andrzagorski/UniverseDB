﻿using Universe.Models;
using Universe.Models.spaceobject;

namespace BLL
{
    public interface IEntityService<T> where T : DbEntity
    {
        Task<T> GetSpaceObjectByIdAsync(int? id);
        Task AddSpaceObjectAsync(T obj);
        Task UpdateSpaceObjectAsync(T obj);
        Task RemoveSpaceObjectAsync(int id);
        bool SpaceObjectExists(int id);
        IQueryable<T> GetAllSpaceObjects();
    }
    public class EntityService<T> : IEntityService<T> where T : DbEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        public EntityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<T> GetAllSpaceObjects()
        {
            return _unitOfWork.GetRepository<T>().GetList();
        }
        public async Task<T> GetSpaceObjectByIdAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _unitOfWork.GetRepository<T>().FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task AddSpaceObjectAsync(T obj)
        {
            await _unitOfWork.GetRepository<T>().InsertAsync(obj);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateSpaceObjectAsync(T obj)
        {
            _unitOfWork.GetRepository<T>().Update(obj);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task RemoveSpaceObjectAsync(int id)
        {
            //var obj = await _unitOfWork.GetRepository<T>().GetByIDAsync(id);
            _unitOfWork.GetRepository<T>().Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public bool SpaceObjectExists(int id)
        {
            return _unitOfWork.GetRepository<T>().Any(e => e.Id == id);
        }
    }
}
