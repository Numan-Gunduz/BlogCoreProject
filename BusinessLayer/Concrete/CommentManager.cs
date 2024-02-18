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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDAl;

		public CommentManager(ICommentDal commentDAl)
		{
			_commentDAl = commentDAl;
		}

		public void CommentAdd(Comment comment)
		{
			_commentDAl.Insert(comment);
		}

		public List<Comment> GetList(int id)
		{
		return _commentDAl.GetListAll(x=>x.BlogID==id);
		}

		
	}
}
