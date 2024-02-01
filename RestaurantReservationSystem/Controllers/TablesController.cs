using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RestaurantReservationSystem.Models;

namespace RestaurantReservationSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TablesController : ControllerBase
{
    private readonly AppDbContext _context;

    public TablesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetTables()
    {
        var tables = _context.Tables.ToList();
        return Ok(tables);
    }

    [HttpPost]
    public IActionResult AddTable(Table table)
    {
        _context.Tables.Add(table);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetTables), new { id = table.Id }, table);
    }
}