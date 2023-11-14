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
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Item.ToList();
        }
    }
}
