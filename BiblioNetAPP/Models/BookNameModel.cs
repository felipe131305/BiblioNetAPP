using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class BookNameModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage="{0} is required")]
        public string bookName { get; set; }

    }
}
