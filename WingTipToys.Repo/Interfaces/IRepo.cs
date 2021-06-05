using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingTipToys.Repo.Interfaces
{
    public interface IRepo<TEntity> where TEntity : class 
    {
        public void Create(TEntity entity);
        public TEntity Read(object id);
        public void Update(TEntity entity);
        public void Delete(object id);
        public void Delete(TEntity entity);
    }
}
