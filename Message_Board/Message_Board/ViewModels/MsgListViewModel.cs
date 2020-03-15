using Message_Board.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.ViewModels
{
    public class MsgListViewModel
    {
        public IEnumerable<Users> Users { get; set; }

        public IEnumerable<Comments> Comments { get; set; }

        public string data { get; set; }
    }
}
