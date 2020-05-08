using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    public class Estanque
    {
        private int _Capacidad;
        private double _Litros;
        private Boolean _Estado;

        public void MitadCombustible()
        {
            if(_Litros > 10.5 || _Litros <= _Capacidad / 2)
            {
                _Estado = true;
            }
        }

        public void BajoCombustible()
        {
            if (_Litros <= 10.5)
            {
                _Estado = false;
            }
        }
    }
}
