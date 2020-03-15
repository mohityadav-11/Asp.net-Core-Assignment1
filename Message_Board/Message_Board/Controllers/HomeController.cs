using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Message_Board.Models;
using Microsoft.Data.SqlClient;
using Message_Board.ViewModels;

namespace Message_Board.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _appDbContext;
        private readonly IUserRepository _userRepository;
        private readonly ICommentsRepository _commentsRepository;
        MsgListViewModel msgListViewModel;

        private static string connetionString = "Server=(localdb)\\mssqllocaldb;Database=Message_Board;Trusted_Connection=True;MultipleActiveResultSets=true";
        SqlConnection cnn = new SqlConnection(connetionString);

        public HomeController(IUserRepository userRepository, ICommentsRepository commentsRepository, AppDbContext appDbContext)
        {
            _userRepository = userRepository;
            _commentsRepository = commentsRepository;
            _appDbContext = appDbContext;
        }

        public ViewResult Index()
        {
            msgListViewModel = new MsgListViewModel();
            msgListViewModel.Users = _userRepository.AllUsers;
            msgListViewModel.Comments = _commentsRepository.AllComments;
            return View(msgListViewModel);
        }

        [HttpPost]
        public ActionResult Index(string name, string message)
        {
            int likes = 0;
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql = "insert into [Users] values ('" + name + "', '" + likes + "', '" + message + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

            msgListViewModel = new MsgListViewModel();
            msgListViewModel.Users = _userRepository.AllUsers;
            msgListViewModel.Comments = _commentsRepository.AllComments;
            return View(msgListViewModel);

        }

        [HttpPost]
        public ActionResult Comment(string cmtname, string comment, string extra)
        {
            int m_id = int.Parse(extra);
            int likes = 0;
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql = "insert into [Comments] values ('" + comment + "', '" + likes + "', '" + m_id + "', '" + cmtname + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();

            msgListViewModel = new MsgListViewModel();
            msgListViewModel.Users = _userRepository.AllUsers;
            msgListViewModel.Comments = _commentsRepository.AllComments;
            return View("Index",msgListViewModel);

        }
    }
}
