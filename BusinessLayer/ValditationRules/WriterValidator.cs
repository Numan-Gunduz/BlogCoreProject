﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValditationRules
{
	public class WriterValidator:AbstractValidator<Writer>
	{
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez."); 
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Maili Boş Geçilemez."); 
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
			RuleFor(x => x.WriterName).MaximumLength (50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız.");

		}
	}
}
