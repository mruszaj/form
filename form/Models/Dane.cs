using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class Dane
    {

        public string Miasto { get; set; }
        public enum Miasta { Kłaj = 1, Kraków = 2, Piekary = 3, Liszki = 4, Olsztyn = 5 }
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage ="Wprowadź poprawny format")]
        public string Email { get; set; }
  
        [Required(ErrorMessage = "Prosze podaj hasło")]
        [MinLength(8,ErrorMessage ="Hasło musi miećprzynajmniej 8 znaków")]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).*", ErrorMessage = "Niepoprawny format hasła")]
        public string Hasło { get; set; }
        [Required(ErrorMessage = "Prosze powtórz hasło")]
        [Compare("Hasło", ErrorMessage = "Hasła muszą być takie same")]
        public string Hasło2 { get; set; }

        
        [Phone(ErrorMessage = "wprowadź poprawny numer telefonu")]
        public string NumerTelefonu { get; set; }
        [Range(10,80,ErrorMessage = "wprowadź poprawny wiek")]
        public string Wiek { get; set; }

 
    }
}



