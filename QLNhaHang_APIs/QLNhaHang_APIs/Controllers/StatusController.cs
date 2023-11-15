using Microsoft.AspNetCore.Mvc;
using QLNhaHang_APIs.Data;
using QLNhaHang_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNhaHang_APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Status> Get()
        {
            return _context.Status.ToList();
        }
    }
}
