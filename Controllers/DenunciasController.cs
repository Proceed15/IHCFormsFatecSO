using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IHCFormsFatecSO.Data;
using Validacao_Form.Models;

namespace IHCFormsFatecSO.Controllers
{
    public class DenunciasController : Controller
    {
        private readonly IHCFormsFatecSOContext _context;

        public DenunciasController(IHCFormsFatecSOContext context)
        {
            _context = context;
        }

        // GET: Denuncias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Denuncia.ToListAsync());
        }

        // GET: Denuncias/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }

        // GET: Denuncias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Denuncias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Denuciante,Telefone,Email,Cnpj,RazaoSocial,Logradouro,Numero,Bairro,Cidade,UF,Pais,CEP,Conteudo")] Denuncia denuncia)
        {
            if (ModelState.IsValid)
            {
                denuncia.Id = Guid.NewGuid();
                _context.Add(denuncia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(denuncia);
        }

        // GET: Denuncias/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia.FindAsync(id);
            if (denuncia == null)
            {
                return NotFound();
            }
            return View(denuncia);
        }

        // POST: Denuncias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Denuciante,Telefone,Email,Cnpj,RazaoSocial,Logradouro,Numero,Bairro,Cidade,UF,Pais,CEP,Conteudo")] Denuncia denuncia)
        {
            if (id != denuncia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(denuncia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DenunciaExists(denuncia.Id))
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
            return View(denuncia);
        }

        // GET: Denuncias/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.Denuncia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }

        // POST: Denuncias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var denuncia = await _context.Denuncia.FindAsync(id);
            if (denuncia != null)
            {
                _context.Denuncia.Remove(denuncia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DenunciaExists(Guid id)
        {
            return _context.Denuncia.Any(e => e.Id == id);
        }
    }
}
