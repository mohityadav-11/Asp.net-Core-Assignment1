using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public interface ICommentsRepository
    {
        IEnumerable<Comments> AllComments { get; }
    }
   
}
