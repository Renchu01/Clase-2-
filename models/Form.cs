using System.ComponentModel.DataAnnotations;

public class Form {
    [Required]// decimos q el mail sea requerido, se ponen arriba de las propiedades y le dan configuraciones adicionales
                //tanto el password como el mail es requerido
    [Display(Name = "Email")]
    public string Mail { get; set;} // para poder setear y traer el valor de esa propiedad

    [Required]
    [Display(Name ="Contraseña")]
    public string Password{get;set;}
}