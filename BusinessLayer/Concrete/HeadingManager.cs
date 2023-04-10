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
    public class HeadingManager : IHeadingService
    {
        readonly IHeadingDAL _headingDAL;

        public HeadingManager(IHeadingDAL headingDAL)
        {
            _headingDAL = headingDAL;
        }

        public void AddHeading(Heading heading)
        {
            _headingDAL.Insert(heading);
        }

        public void DeleteHeading(Heading heading)
        {
            _headingDAL.Delete(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDAL.Get(x => x.HeadingId == id);
        }

        public List<Heading> GetHeadings()
        {
            return _headingDAL.List();
        }

        public void UpdateHeading(Heading heading)
        {
            _headingDAL.Update(heading);
        }
    }
}
