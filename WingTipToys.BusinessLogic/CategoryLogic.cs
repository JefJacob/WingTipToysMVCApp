using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingTipToys.Repo.Models;
using WingTipToys.Entities;


namespace WingTipToys.BusinessLogic
{
    public class CategoryLogic
    {
        private CategoryRepo _repo;
        public CategoryLogic()
        {
            _repo = new CategoryRepo();
            //TO DO AutoMapper + DTO
        }
        public void Create(Category category)
        {

            _repo.Create(category);
        }
        public Category Read(int Id)
        {

            return _repo.Read(Id);
        }

        public void Update(Category category)
        {

            _repo.Update(category);
        }
        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }
    }
}
