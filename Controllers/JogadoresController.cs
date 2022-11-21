using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradoIV.Models;

namespace ProjetoIntegradoIV.Controllers
{
    public class JogadoresController : Controller
    {
        private readonly ProjetoIntegradoContext _context;

        public JogadoresController(ProjetoIntegradoContext context)
        {
            _context = context;
        }

        // GET: Jogadores
        public async Task<IActionResult> Index()
        {
            return _context.Jogadores != null ?
                        View(await _context.Jogadores.ToListAsync()) :
                        Problem("Entity set 'ProjetoIntegradoContext.Jogadores'  is null.");
        }


        // GET: Jogadores/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Jogador());
            else
                return View(_context.Jogadores.Find(id));
        }

        // POST: Jogadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("NomeCamisa,posicaoJoga,numGolCarreira,Id,Nome,AnoNasc,Idade,Altura,Peso,Salario")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                if (jogador.Id == 0)
                    _context.Add(jogador);
                else
                    _context.Update(jogador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogador);
        }

        // GET: Jogadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Jogadores == null)
            {
                return Problem("Entity set 'ProjetoIntegradoContext.Jogadores'  is null.");
            }
            var jogador = await _context.Jogadores.FindAsync(id);
            if (jogador != null)
            {
                _context.Jogadores.Remove(jogador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
