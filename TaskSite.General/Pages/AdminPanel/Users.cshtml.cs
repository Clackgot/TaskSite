using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskSite.General.Models;

namespace TaskSite.General.Pages
{
    public class UsersModel : PageModel
    {
        private readonly TaskSite.General.Models.ApplicationContext _context;

        public UsersModel(TaskSite.General.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
