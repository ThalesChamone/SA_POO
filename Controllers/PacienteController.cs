using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SA_OOP.Data;
using SA_OOP.Models;

namespace SA_OOP.Controllers
{
    public class PacienteController : Controller
    {
        private readonly SA_OOPContext _context;

        public PacienteController(SA_OOPContext context)
        {
            _context = context;
        }

        // GET: Paciente
        public async Task<IActionResult> Index()
        {
            var sA_OOPContext = _context.Paciente.Include(p => p.Convenio).Include(p => p.Procedimento);
            return View(await sA_OOPContext.ToListAsync());
        }

        // GET: Paciente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente
                .Include(p => p.Convenio)
                .Include(p => p.Procedimento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Paciente/Create
        public IActionResult Create()
        {
            ViewData["ConvenioId"] = new SelectList(_context.Convenio, "Id", "NomeEmpresa");
            ViewData["ProcedimentoCodigo"] = new SelectList(_context.Procedimentos, "Codigo", "NomeProcedimento");
            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConvenioId"] = new SelectList(_context.Convenio, "Id", "Id", paciente.ConvenioId);
            ViewData["ProcedimentoCodigo"] = new SelectList(_context.Procedimentos, "Codigo", "Codigo", paciente.ProcedimentoCodigo);
            return View(paciente);
        }

        // GET: Paciente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            ViewData["ConvenioId"] = new SelectList(_context.Convenio, "Id", "NomeEmpresa", paciente.ConvenioId);
            ViewData["ProcedimentoCodigo"] = new SelectList(_context.Procedimentos, "Codigo", "NomeProcedimento", paciente.ProcedimentoCodigo);
            return View(paciente);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Rua,Numero,Bairro,Complemento,CPF,CEP,Email,Telefone,ConvenioId,ProcedimentoCodigo")] Paciente paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
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
            ViewData["ConvenioId"] = new SelectList(_context.Convenio, "Id", "Id", paciente.ConvenioId);
            ViewData["ProcedimentoCodigo"] = new SelectList(_context.Procedimentos, "Codigo", "Codigo", paciente.ProcedimentoCodigo);
            return View(paciente);
        }

        // GET: Paciente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Paciente
                .Include(p => p.Convenio)
                .Include(p => p.Procedimento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paciente = await _context.Paciente.FindAsync(id);
            _context.Paciente.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(int id)
        {
            return _context.Paciente.Any(e => e.Id == id);
        }
    }
}
