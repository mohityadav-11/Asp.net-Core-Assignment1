using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comments>().HasData(
                new Comments 
                {
                    id = 1,
                    msg_id = 1,
                    comment_mgs = "Same to you",
                    like = 1,
                    name = "Kuldeep Nikum"
                });

            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Msg_id = 1,
                    Msg_content = "Happy Holi...",
                    User_name = "Mohit Yadav",
                    like = 10
                });


            modelBuilder.Entity<Users>().HasData(
               new Users
               {
                   Msg_id = 2,
                   Msg_content = "Whatever",
                   User_name = "Kuldeep Nikum",
                   like = 15
               });

        }
    }
}
