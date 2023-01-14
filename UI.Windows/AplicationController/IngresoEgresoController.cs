﻿using Aplication.ServicesEntity;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class IngresoEgresoController
    {
        private IngresoEgresoServices ingresoEgresoServices = new IngresoEgresoServices();

        public bool InsertarIngresoEgreso(IngresoEgresoViewModel ingresoEgresoViewModel)
        {
            IngresoEgreso ingresoEgreso = new IngresoEgreso();
            try
            {
                ingresoEgreso.FechaHora = ingresoEgresoViewModel.FechaHora;
                ingresoEgreso.Descripcion = ingresoEgresoViewModel.Descripcion;
                ingresoEgreso.TipoTransaccionId = ingresoEgresoViewModel.TipoTransaccionId;
                ingresoEgreso.Estado = ingresoEgresoViewModel.Estado;
                ingresoEgresoServices.InsertarIngresoEgreso(ingresoEgreso);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
