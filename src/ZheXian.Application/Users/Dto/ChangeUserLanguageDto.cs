using System.ComponentModel.DataAnnotations;

namespace ZheXian.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}