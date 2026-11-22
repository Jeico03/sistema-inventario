using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.Consola
{
    internal interface IDescontable
    {
        void AplicarDescuento(decimal porcentaje);
    }
}
