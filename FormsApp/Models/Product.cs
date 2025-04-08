using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{

    public class Product{

        [Display(Name ="Ürün Id")]
        public int ProductId {get;set;}

        [Display(Name ="Ürün Adı")]
        [StringLength(100)]
        [Required(ErrorMessage = "Ürün Adı Zorunlu")]
        public string? Name {get;set;}

        [Display(Name ="Ürün Fiyatı")]
        [Range(0,100000,ErrorMessage = "Fiyat 0 ile 100000 arasında olmalıdır")]
        [Required(ErrorMessage = "Ürün Fiyatı Zorunlu")]
        public decimal? Price {get;set;}

        [Display(Name ="Ürün Görseli")]
        public string? Image {get;set;} = string.Empty;
        public bool IsActive {get;set;}

        [Display(Name ="Ürün Kategorisi")]
        [Required]
        public int? CategoryId {get;set;}
    }
}