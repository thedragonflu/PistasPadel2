using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PistasPadel.Models;

namespace PistasPadel.Pages
{
    public class IndexModel : PageModel
    {
        //Si pongo esto da error 
       /* //inicializamos el contexto de la base de datos
        private readonly ApplicationDbContext _db;
        //constructor
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }*/

        //Vincula los datos del cliente con este modelo
        [BindProperty]
        public Cliente Cliente { get; set; }

        //
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

         //
        public void OnGet()
        {
          
        }

        //si se añade el metodo onPost() es para añadir los datos a la base de datos        
         /* public async Task<IActionResult> OnPost()
         {
             if(!ModelState.IsValid)
             {
                 return Page();
             }     
             _db.Add(Cliente);
             await _db.SaveChangesAsync();
             return RedirectToPage("ReservasPistas");
         }*/
    }
}
