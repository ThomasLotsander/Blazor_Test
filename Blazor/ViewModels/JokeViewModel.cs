using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ViewModels
{
    public class JokeViewModel
    {
     
        [Required(AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = "Du kan inte skriva en för lång premiss. (Max 200 tecken)")]
        public string Premiss { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Du kan inte skriva en för lång punchline. (Max 50 tecken)")]
        public string PunchLine { get; set; }

        [MaxLength(200, ErrorMessage = "Du kan inte skriva en för lång förklaring. (Max 200 tecken)")]
        public string Explanation { get; set; }


        public bool IsExplicit { get; set; }
    }
}
