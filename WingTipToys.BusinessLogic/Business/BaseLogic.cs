using AutoMapper;
using System;
using WingTipToys.BusinessLogic.Interfaces;
using WingTipToys.Entities;
using WingTipToys.Repo.Interfaces;
using WingTipToys.Repo.Models;

namespace WingTipToys.BusinessLogic.Business
{
    public class BaseLogic<TEntity, TDTO> : ILogic<TDTO> where TEntity : class, IEntity
    {
        protected IRepo<TEntity> _repo;
        protected IMapper _mapConfig;

        public BaseLogic()
        {
           
        }

        public BaseLogic(IRepo<TEntity> repo)
        {
            _repo = repo;
            _mapConfig  = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<TEntity, TDTO>();
                    cfg.CreateMap<TDTO, TEntity>();
                }).CreateMapper();
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
