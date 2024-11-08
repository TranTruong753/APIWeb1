﻿using APIWeb1.Data;
using APIWeb1.Helpers;
using APIWeb1.Interfaces;
using APIWeb1.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace APIWeb1.Controllers.ApiControllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDBContext _context;
        public JobController(ApplicationDBContext context, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] JobQueryObject query)
        {
            var Job = await _unitOfWork.JobRepo.GetAllAsync(query);
            return Ok(Job);
        }
    }
}
