using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingTipToys.BusinessLogic.Interfaces
{
    public interface ILogic<TDTO>
    {
        void Create(TDTO item);
        TDTO Read(object Id);
        void Update(TDTO item);
        void Delete(object Id);
    }
}
