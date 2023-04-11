using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        readonly IContentDAL _contentDAL;

        public ContentManager(IContentDAL contentDAL)
        {
            _contentDAL = contentDAL;
        }

        public void AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetContents()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDAL.List(x => x.HeadingId == id);
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
