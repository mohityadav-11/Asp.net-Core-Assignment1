using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public class Comments
    {
        public string comment_mgs { get; set; }
        [Key]
        public int id { get; set; }
        public int like { get; set; }
        public int msg_id { get; set; }
        public string name { get; set; }

    }
}
