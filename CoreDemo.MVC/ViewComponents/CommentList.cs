using CoreDemo.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.MVC.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                     ID=1,
                     Username = "Sinan"
                },
                new UserComment
                {
                    ID =2,
                    Username="Ece"
                }
            };  
            return View(commentValues);
        }
    }
}
