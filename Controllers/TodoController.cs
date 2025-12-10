using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers;

public class TodoController : Controller
{

    private readonly ApplicationDbContext _context;
    public TodoController(ApplicationDbContext context)
    {
        _context = context;
    }

    //Get: Todo
    public async Task<IActionResult> Index()
    {
        var todos = await _context.TodoItems
            .OrderByDescending(t => t.CreatedAt)
            .ToListAsync();
        return View(todos);
    }

    //GET: Todo/Create
    public IActionResult Create()
    {
        return View();
    }

    //POST: Todo/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TodoItem todoItem)
    {
        if (ModelState.IsValid)
        {
            todoItem.CreatedAt = DateTime.Now;
            _context.Add(todoItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(todoItem);
    }

    // GET: Todo/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null) return NotFound();

        return View(todoItem);
    }

    //POST: Todo/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TodoItem todoItem)
    {
        if (id != todoItem.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(todoItem);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(todoItem.Id))
                    return NotFound();
                throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(todoItem);
    }

    // POST: Todo/ToggleComplete/5
    [HttpPost]
    public async Task<IActionResult> ToggleComplete(int id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null) return NotFound();

        todoItem.IsCompleted = !todoItem.IsCompleted;
        todoItem.CompletedAt = todoItem.IsCompleted ? DateTime.Now : null;

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // POST: Todo/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }
        _context.TodoItems.Remove(todoItem);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TodoItemExists(int id)
    {
        return _context.TodoItems.Any(e => e.Id == id);
    }
}