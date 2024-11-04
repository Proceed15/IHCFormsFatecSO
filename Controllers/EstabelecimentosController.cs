using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IHCFormsFatecSO.Data;
using IHCFormsFatecSO.Models;

namespace IHCFormsFatecSO.Controllers
{
    public class EstabelecimentosController : Controller
    {
        private readonly IHCFormsFatecSOContext _context;

        public EstabelecimentosController(IHCFormsFatecSOContext context)
        {
            _context = context;
        }

        // GET: Estabelecimentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estabelecimento_1.ToListAsync());
        }

        // GET: Estabelecimentos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estabelecimento = await _context.Estabelecimento_1.FirstOrDefaultAsync(m => m.CnpjBasico == id);
            if (estabelecimento == null)
            {
                return NotFound();
            }

            return View(estabelecimento);
        }

        // GET: Estabelecimentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estabelecimentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CnpjBasico,CnpjOrdem,CnpjDv,NomeFantasia,DataSituacaoCadastral,CnaePrincipal,TpLogradouro,Logradouro,Numero,Complemento,Bairro,CEP,UF,Cidade,Email")] Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estabelecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estabelecimento);
        }

        // GET: Estabelecimentos/Edit/5
        public async Task<IActionResult> Edit(string id, string cnpjordem, string cnpjdv)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estabelecimento = await _context.Estabelecimento_1.FindAsync(id, cnpjordem, cnpjdv);
            if (estabelecimento == null)
            {
                return NotFound();
            }
            return View("Create", estabelecimento);
        }

        // POST: Estabelecimentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, string cnpjordem, string cnpjdv, [Bind("CnpjBasico,CnpjOrdem,CnpjDv,NomeFantasia,DataSituacaoCadastral,CnaePrincipal,TpLogradouro,Logradouro,Numero,Complemento,Bairro,CEP,UF,Cidade,Email")] Estabelecimento estabelecimento)
        {
            if (id != estabelecimento.CnpjBasico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estabelecimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstabelecimentoExists(estabelecimento.CnpjBasico))
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
            return View(estabelecimento);
        }

        // GET: Estabelecimentos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estabelecimento = await _context.Estabelecimento_1
                .FirstOrDefaultAsync(m => m.CnpjBasico == id);
            if (estabelecimento == null)
            {
                return NotFound();
            }

            return View(estabelecimento);
        }

        // POST: Estabelecimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var estabelecimento = await _context.Estabelecimento_1.FindAsync(id);
            if (estabelecimento != null)
            {
                _context.Estabelecimento_1.Remove(estabelecimento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstabelecimentoExists(string id)
        {
            return _context.Estabelecimento_1.Any(e => e.CnpjBasico == id);
        }
    }
}
