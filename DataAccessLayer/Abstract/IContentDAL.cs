using EntityLayer.Concrete;
using EntityLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContentDAL: IRepository<Content>
    {
    }
}
