using AbsensiApps.Data;
using AbsensiApps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AbsensiApps.Controllers
{
    public class AbsenController : Controller
    {
        private readonly AppDbContext _context;

        public AbsenController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.NIKList = _context.Employees
                .Select(e => new SelectListItem
                {
                    Value = e.NIK,
                    Text = $"{e.Nama} - {e.NIK}"
                }).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Absen absen)
        {
            if (ModelState.IsValid)
            {
                _context.Absens.Add(absen);
                _context.SaveChanges();
                return RedirectToAction("List");
            }

            ViewBag.NIKList = new SelectList(_context.Employees.ToList(), "NIK", "Nama");
            return View(absen);
        }

        public IActionResult List()
        {
            var data = _context.Absens
                .Include(a => a.Employee)
                .OrderBy(a => a.NIK)
                .ThenBy(a => a.TanggalAbsen)
                .ToList();

            
            var tanggalList = _context.Absens
                .Select(a => a.TanggalAbsen.Date)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            
            var employees = _context.Employees.ToList();
            var absens = _context.Absens.ToList();

            
            var matrix = employees.Select(emp => new
            {
                emp.NIK,
                emp.Nama,
                TanggalFlags = tanggalList.Select(tgl =>
                    absens.Any(a => a.NIK == emp.NIK && a.TanggalAbsen.Date == tgl.Date) ? "X" : "").ToList(),
                Total = absens.Count(a => a.NIK == emp.NIK)
            }).ToList();

           
            var bulanList = _context.Absens
                .AsEnumerable()
                .Select(a => a.TanggalAbsen.ToString("yyyyMM"))
                .Distinct()
                .OrderBy(b => b)
                .ToList();
            var rekap = employees.Select(emp => new
            {
                emp.NIK,
                emp.Nama,
                BulanCount = bulanList.ToDictionary(
                    bulan => bulan,
                    bulan => absens.Count(a =>
                        a.NIK == emp.NIK &&
                        a.TanggalAbsen.ToString("yyyyMM") == bulan)
                ),
                Total = absens.Count(a => a.NIK == emp.NIK)
            }).ToList();

            
            ViewBag.Matrix = matrix;
            ViewBag.Rekap = rekap;
            ViewBag.TanggalList = tanggalList;
            ViewBag.BulanList = bulanList;
            return View(data);
        }

    }
}
