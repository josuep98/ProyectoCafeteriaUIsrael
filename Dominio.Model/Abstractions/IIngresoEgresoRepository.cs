﻿using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface IIngresoEgresoRepository : IBaseRepository<IngresoEgreso>
    {
        IngresoEgreso Buscar(int id);
        IEnumerable<IngresoEgreso> ListarIngresoEgresoActivo();
    }
}
