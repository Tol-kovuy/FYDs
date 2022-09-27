using System.ComponentModel.DataAnnotations;

namespace FYD_s.Domain.ViewModels.Doctor
{
    public class DoctorViewModel // TO DO: цей клас можливо треба бути переробити под анкету від користувача
    {
        public int Id { get; set; }
        [Display(Name = "Опишть своі симптоми(виберить зі списку)")]
        public string Symptom { get; set; }
    }
}
