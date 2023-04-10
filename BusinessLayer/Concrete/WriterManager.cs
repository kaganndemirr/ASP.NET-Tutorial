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
    public class WriterManager : IWriterService
    {
        readonly IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public void AddWriter(Writer writer)
        {
            _writerDAL.Insert(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            _writerDAL.Delete(writer);
        }

        public Writer GetById(int id)
        {
            return _writerDAL.Get(x => x.WriterId == id);
        }

        public List<Writer> GetWriters()
        {
            return _writerDAL.List();
        }

        public void UpdateWriter(Writer writer)
        {
           _writerDAL.Update(writer);
        }
    }
}
