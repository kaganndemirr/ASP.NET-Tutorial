using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IContentService
    {
        List<Content> GetContents();
        void AddContent(Content content);

        Content GetById(int id);

        void DeleteContent(Content content);

        void UpdateContent(Content content);

        List<Content> GetListByHeadingId(int id);
    }
}
