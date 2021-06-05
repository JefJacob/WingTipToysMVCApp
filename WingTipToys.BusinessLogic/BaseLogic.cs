using AutoMapper;
using System;
using WingTipToys.Entities;
using WingTipToys.Repo.Interfaces;
using WingTipToys.Repo.Models;

namespace WingTipToys.BusinessLogic
{
    public class BaseLogic<TEntity, TDTO> : ILogic<TDTO> where TEntity : class, IEntity
    {
        protected IRepo<TEntity> _repo;
        protected IMapper _mapConfig;

        public BaseLogic()
        {
            _mapConfig = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<TEntity, TDTO>();
                    cfg.CreateMap<TDTO, TEntity>();
                }).CreateMapper();
            _repo = new BaseRepo<TEntity>();
        }

        public void Create(TDTO item)
        {
            TEntity entity = _mapConfig.Map<TEntity>(item);
            _repo.Create(entity);
        }

        public void Delete(object Id)
        {
            _repo.Delete(Id);
        }

        public TDTO Read(object Id)
        {
            return _mapConfig.Map<TDTO>(_repo.Read(Id));
        }

        public void Update(TDTO item)
        {
            TEntity entity = _mapConfig.Map<TEntity>(item);
            _repo.Update(entity);
        }
    }
}
