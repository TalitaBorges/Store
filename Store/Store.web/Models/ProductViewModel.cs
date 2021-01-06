
namespace Store.web.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;
    using Store.web.Data.Entities;


    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
