using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_2_HProg.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [BindProperty]//Lo que viaja a traves de la llamada post, mapealo con esta propiedad para ahorrar un monton de codigo.
    public Form Data { get; set; } // estamos diciendo q el privacy model va a tener dentro de la clase, una propiedad que se llame data
    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametrox"]; 
        Data = new Form(); // creo un objeto y le asignamos valores(mail y password)
        Data.Mail = "test@gmail.com";
        Data.Password="12345";
    
    
    }
    public IActionResult OnPost()
    {
        if(!ModelState.IsValid){
            return Page();
        }
    //Guardar en la base de datos, procesar informacion
    var formValues= Data;

    return RedirectToPage("Index");
    }

}

