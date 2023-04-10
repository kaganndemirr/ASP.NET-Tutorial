using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IHeadingService
    {
        List<Heading> GetHeadings();
        void AddHeading(Heading heading);

        Heading GetById(int id);

        void DeleteHeading(Heading heading);

        void UpdateHeading(Heading heading);
    }
}
