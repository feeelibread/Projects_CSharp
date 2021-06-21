using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shibata_Web.Models;

namespace Shibata_Web.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly Shibata_WebContext _context;

        public UsuariosController(Shibata_WebContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioViewModel = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Email,Id,Created,Updated,Deleted")] UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                usuarioViewModel.Id = Guid.NewGuid();
                _context.Add(usuarioViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioViewModel = await _context.Usuarios.FindAsync(id);
            if (usuarioViewModel == null)
            {
                return NotFound();
            }
            return View(usuarioViewModel);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Email,Id,Created,Updated,Deleted")] UsuarioViewModel usuarioViewModel)
        {
            if (id != usuarioViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioViewModelExists(usuarioViewModel.Id))
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
            return View(usuarioViewModel);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioViewModel = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioViewModel == null)
            {
                return NotFound();
            }

            return View(usuarioViewModel);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var usuarioViewModel = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuarioViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioViewModelExists(Guid id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
