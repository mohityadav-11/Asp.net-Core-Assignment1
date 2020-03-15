using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public class CommentsRepository: ICommentsRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Comments> AllComments
        {
            get
            {
                return _appDbContext.Comments;
            }
        }

    }
}
