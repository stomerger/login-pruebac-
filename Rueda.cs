using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }

    class Rueda : VehiculoComponentes
    {
        private int[] _durometro = new int[2] {100,180};
        private TipoRecubrimiento _recubrimiento;
        private string _opcion;
        private int _cantidadRuedas;


    }
}
