﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRManagerWeb.Data;
using AutoMapper;
using HRManagerWeb.Models;
using HRManagerWeb.IRepositories;
using Microsoft.AspNetCore.Authorization;
using HRManagerWeb.Constants;

namespace HRManagerWeb.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {

        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocation)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            this.leaveAllocationRepository = leaveAllocation;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leavetypes =_mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());
            return View(leavetypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,DefaultDays,Id,DateCreated,DateUpdated")] LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leavetype = _mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leavetype);
                TempData["success"] = "Leavetype Created Succesfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Error"; 
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leavetypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leavetypeVM);
        }

        // POST: LeaveTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                    leaveType.DateUpdated = DateTime.Now;
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            TempData["success"] = "Deleted Succesfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
           await leaveAllocationRepository.LeaveAllocation(id);
           return RedirectToAction(nameof(Index));
        }
       
    }
}
