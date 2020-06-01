﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PistasPadel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PistasPadel.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Cliente Cliente { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IEnumerable<Cliente> Clientes { get; set; }
        public async Task OnGet()
        {
            Clientes = await _db.Cliente.ToListAsync();
        }
        public async Task<IActionResult> OnPost(String nombreUsuario, String contraseñaUsuario)
        {
            try
            {
                var cb = new SqlConnectionStringBuilder();
                var clientito = _db.Cliente;

                cb.DataSource = "localhost\\CLUBPADEL";
                using (var connection = new SqlConnection(cb.ConnectionString))
                {
                    foreach (Cliente item in clientito)
                    {
                        if (item != null)
                        {
                            if (item.User == nombreUsuario && item.Password == contraseñaUsuario)
                            {
                                return RedirectToPage("ReservasPistasA");
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return Page();
        }
    }
}