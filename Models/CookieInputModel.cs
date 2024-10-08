using System.ComponentModel.DataAnnotations;
namespace Lr5.Models
{
    public class CookieInputModel
    {
        [Required(ErrorMessage = "Поле Значення є обов'язковим.")]
        [Display(Name = "Значення")]
        public string Value { get; set; }
        [Required(ErrorMessage = "Поле Дата закінчення є обов'язковим.")]
        [Display(Name = "Дата закінчення")]
        [DataType(DataType.DateTime)]
        public DateTime ExpirationDate { get; set; }
    }
}