using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_2_HProg.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    [BindProperty]//Lo que viaja a traves de la llamada post, mapealo con esta propiedad para ahorrar un monton de codigo.
    public Form Data { get; set; }
    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametrox"];
        Data = new Form(); 
        Data.Mail = "test@gmail.com";
        Data.Password="1234";
    
    
    }
    public IActionResult OnPost(){
        if(!ModelState.IsValid){
            return Page();
        }
    //Guardar en la base de datos, procesar informacion
    var formValues= Data;

    return RedirectToPage("Index");
    }

}

