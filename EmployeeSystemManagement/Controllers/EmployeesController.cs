using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeSystemManagement.Models;
using EmployeeSystemManagement.Models.Entities;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeSystemManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
           var viewModel = await _context.Employees.ToListAsync();
            return View(viewModel);
        }

        // GET: Employees/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel model)
        {
            Employee employees = new Employee();
            {
                employees.EmpNo = model.EmpNo;
                employees.FirstName = model.FirstName;
                employees.MiddleName = model.MiddleName;
                employees.LastName = model.LastName;
                employees.PhoneNumber = model.PhoneNumber;
                employees.EmailAddress = model.EmailAddress;
                employees.Country = model.Country;
                employees.Address = model.Address;
                employees.Department = model.Department;
                employees.Designation = model.Designation;
        };
            if (ModelState.IsValid)
            {
                _context.Add(employees);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
         else
            {
                return View(model); 
            }
           
        }

        // GET: Employees/Edit/5

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
          
            var employee = await _context.Employees.FindAsync(id);
           
            return View(employee);
        }

        // POST: Employees/Edit/5
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Employee viewModel)
        {
            var employees = await _context.Employees.FindAsync(viewModel.Id);

            if (employees is not null)
            {
                employees.EmpNo = viewModel.EmpNo;
                employees.FirstName = viewModel.FirstName;
                employees.MiddleName = viewModel.MiddleName;
                employees.LastName = viewModel.LastName;
                employees.PhoneNumber = viewModel.PhoneNumber;
                employees.EmailAddress = viewModel.EmailAddress;
                employees.Country = viewModel.Country;
                employees.Address = viewModel.Address;
                employees.Department = viewModel.Department;
                employees.Designation = viewModel.Designation;

                await _context.SaveChangesAsync();
                
            }
            return RedirectToAction(nameof(Index));
           
            
        }

        // GET: Employees/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
