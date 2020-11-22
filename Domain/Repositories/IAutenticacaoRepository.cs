﻿using Domain.Queries;
using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IAutenticacaoRepository
    {
        AutenticacaoQueryResult BuscarDadosToken(string idToken, string sistema);
    }
}
