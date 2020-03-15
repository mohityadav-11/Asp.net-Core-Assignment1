using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public class Users
    {
        [Key]
        public int Msg_id { get; set; }

        public string User_name { get; set; }

        public int like { get; set; }

        public string Msg_content { get; set; }
    }
}
