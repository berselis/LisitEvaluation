using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RegisterApp.Models;
using RegisterApp.ModelsDTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly RegisterAppLisitDBContext DB;
        private readonly IMapper mapper;

        public HomeController(RegisterAppLisitDBContext DB, IMapper mapper)
        {
            this.DB = DB;
            this.mapper = mapper;

        }


        public async Task<IActionResult>Index()
        {
            List<Employee> resutl = await DB.Employees.ToListAsync();
            List<EmployeeModel> query = mapper.Map<List<EmployeeModel>>(resutl);
            return View(query);
        }
        [HttpPost]
        public async Task<IActionResult> Index(string finder)
        {
            List<Employee> resutl = await DB.Employees.Where(whe => whe.Name.Contains(finder) || whe.Position.Contains(finder) || whe.Offic.Contains(finder)).ToListAsync();
            List<EmployeeModel> query = mapper.Map<List<EmployeeModel>>(resutl);
            return View(query);
        }




    }
}
