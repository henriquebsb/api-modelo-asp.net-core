﻿using Shared.Commands;
using Shared.FluentValidator;
using System;


namespace Domain.Commands.PublicacaoTema
{
    public class SalvarPublicacaoTemaCommand : Notifiable, ICommand
    {
        public Guid IdTema { get; set; }
        public Guid IdPublicacao { get; set; }

        bool ICommand.Valid()
        {
            return Valid;
        }
    }
}
