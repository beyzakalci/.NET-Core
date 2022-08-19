using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adı boş geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez!");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harften oluşmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harften oluşmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifre en az bir rakamdan oluşmalıdır.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("İsim en az 2 karakterden oluşmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim en fazla 50 karakterden oluşmalıdır.");
        }
    }
}
