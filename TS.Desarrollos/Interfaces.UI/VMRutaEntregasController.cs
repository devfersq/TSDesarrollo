using Almacen.Data.VModels;
using Interfaces.UI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.UI
{
    public class VMRutaEntregasController : Controller
    {
        private readonly InterfacesUIContext _context;

        public VMRutaEntregasController(InterfacesUIContext context)
        {
            _context = context;
        }

        // GET: VMRutaEntregas
        public async Task<IActionResult> Index()
        {
            return View(await _context.VMRutaEntrega.ToListAsync());
        }

        // GET: VMRutaEntregas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vMRutaEntrega = await _context.VMRutaEntrega
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vMRutaEntrega == null)
            {
                return NotFound();
            }

            return View(vMRutaEntrega);
        }

        // GET: VMRutaEntregas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VMRutaEntregas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Folio,Chofer,NombreChofer,Estado,CreatedDate")] VMRutaEntrega vMRutaEntrega)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vMRutaEntrega);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vMRutaEntrega);
        }

        // GET: VMRutaEntregas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vMRutaEntrega = await _context.VMRutaEntrega.FindAsync(id);
            if (vMRutaEntrega == null)
            {
                return NotFound();
            }
            return View(vMRutaEntrega);
        }

        // POST: VMRutaEntregas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Folio,Chofer,NombreChofer,Estado,CreatedDate")] VMRutaEntrega vMRutaEntrega)
        {
            if (id != vMRutaEntrega.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vMRutaEntrega);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VMRutaEntregaExists(vMRutaEntrega.Id))
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
            return View(vMRutaEntrega);
        }

        // GET: VMRutaEntregas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vMRutaEntrega = await _context.VMRutaEntrega
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vMRutaEntrega == null)
            {
                return NotFound();
            }

            return View(vMRutaEntrega);
        }

        // POST: VMRutaEntregas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vMRutaEntrega = await _context.VMRutaEntrega.FindAsync(id);
            _context.VMRutaEntrega.Remove(vMRutaEntrega);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VMRutaEntregaExists(int id)
        {
            return _context.VMRutaEntrega.Any(e => e.Id == id);
        }
    }
}
