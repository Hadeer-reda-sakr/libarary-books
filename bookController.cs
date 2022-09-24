using bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Controllers
{
    public class bookController : Controller
    {
      public IActionResult index()
        {
            List<book> books = new List<book>
            {
                new book(){title ="Asp.net " , price = 50, author = "mohamed"} ,
                new book (){title = "c#" , price = 880,author="ahmed"},
                new book(){title ="sQl " , price = 900, author = "ali"} ,

            };
            return View(books);
        } 
        
    }
}
