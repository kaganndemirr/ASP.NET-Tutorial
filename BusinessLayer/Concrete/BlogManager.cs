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
	public class BlogManager : IBlogService
	{
		IBlogDAL blogDAL;
		public BlogManager(IBlogDAL blogDAL)
		{
			this.blogDAL = blogDAL;
		}

		public void AddBlog(Blog blog)
		{
			this.blogDAL.Create(blog);
		}

		public void DeleteBlog(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAll()
		{
			return this.blogDAL.GetAll();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBlog(Blog blog)
		{
			throw new NotImplementedException();
		}
	}
}
