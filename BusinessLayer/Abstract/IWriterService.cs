using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IWriterService
    {
        List<Writer> GetWriters();
        void AddWriter(Writer writer);

        Writer GetById(int id);

        void DeleteWriter(Writer writer);

        void UpdateWriter(Writer writer);
    }
}
