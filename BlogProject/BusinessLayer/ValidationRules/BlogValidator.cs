using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog Başlığını 150 karakterden az olmalıdır"); 
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığı 5 karakterden fazla olmalıdır"); 
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz.");
            
        }
    }
}
