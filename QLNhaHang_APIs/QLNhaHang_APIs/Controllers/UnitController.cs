﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLNhaHang_APIs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNhaHang_APIs.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        //private readonly IMapper _mapper;
        //public UnitController(ApplicationDbContext context, IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UnitDTO>>> Get()
        //{
        //    try
        //    {
        //        var data = await _context.Units
        //                .AsNoTracking()
        //                .Where(u => !u.Deleted)
        //                .ToArrayAsync();
        //        var model = _mapper.Map<IEnumerable<UnitDTO>>(data);
        //        return new JsonResult(model);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        return BadRequest("not good");
        //    }
        //}
    }
}
