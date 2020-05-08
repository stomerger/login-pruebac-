using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    public class Automovil : Vehiculo
    {
        private string _Marca;
        private int _Año;
        private int _Kilometraje;
        private int _Opcion;
        private int _Id;
        private int _OpcionMotor;
        private int _Cilindrada;
        private int _Rueda;
        private int _Durometro;
        private double _Litros;
        private Boolean _Estado;
        private int _Capacidad;

        public string MarcaVehiculo(string nombre)
        {
            this._Marca = nombre;
            return nombre;
        }
        public int AñoVehiculo(int año)
        {
            this._Año = año;
            return año;
        }

        public int KilometrajeVehiculo(int kilometraje)
        {
            this._Kilometraje = kilometraje;
            return kilometraje;
        }
        public int Opcion(int opcion)
        {
            this._Opcion = opcion;
            return opcion;
        }

        public int IdMotor(int id)
        {
            this._Id = id;
            return id;
        }

        public int OpcionMotor(int opcion)
        {
            this._OpcionMotor = opcion;
            return opcion;
        }

        public int Cilindrada(int cilindro)
        {
            this._Cilindrada = cilindro;
            return cilindro;
        }

        public int Rueda(int rueda)
        {
            this._Rueda = rueda;
            return rueda;
        }

        public int Durometro(int durometro)
        {
            this._Durometro = durometro;
            return durometro;
        }
        public double Litro (double litro)
        {
            this._Litros = litro;
            return litro;
        }


        public override string ToString()
        {
            string convertir_opcion = Convert.ToString(_Opcion);
            //OPCION TIPO RECUBRIMIENTO
            if (convertir_opcion == "0")
                convertir_opcion = "FENOL";
            else if (convertir_opcion == "1")
                convertir_opcion = "HULE";
            else if (convertir_opcion == "2")
                convertir_opcion = "POLIUTERANO";
            //MOTOR
            string convert_opcion_motor = Convert.ToString(_OpcionMotor);
            if (convert_opcion_motor == "0")
                convert_opcion_motor = "DOS_TIEMPOS";
            else if (convert_opcion_motor == "1")
                convert_opcion_motor = "CUATRO_TIEMPOS";
            if (_Marca == "")
                _Marca = "N/A";
            //COMBUSTIBLE
            if (_Litros > 10.5 || _Litros <= _Capacidad / 2) //MITAD COMBUSTIBLE
            {
                _Estado = true;

            }
            if (_Litros <= 10.5) //BAJO COMBUSTIBLE
            {
                _Estado = false;
            }

            //CONVERSIONES      
            string rueda = Convert.ToString(_Rueda);
            string kilometraje = Convert.ToString(_Kilometraje);
            string año = Convert.ToString(_Año);
            string id = Convert.ToString(_Id);
            string cilindrada = Convert.ToString(_Cilindrada);
            string durometro = Convert.ToString(_Durometro);
            string litros = Convert.ToString(_Litros);

            string[] MiLista = new string[10];
            MiLista[0] = _Marca;
            MiLista[1] = año;
            MiLista[2] = kilometraje;
            MiLista[3] = convertir_opcion;
            MiLista[4] = id;
            MiLista[5] = convert_opcion_motor;
            MiLista[6] = cilindrada;
            MiLista[7] = rueda;
            MiLista[8] = durometro;
            MiLista[9] = litros;

            return "Marca: " + MiLista[0] + "\n" +
                "Año: " + MiLista[1] + "\n" +
                "Kilometraje: " + MiLista[2] + "\n" +
                "Recubrimiento: " + MiLista[3] + "\n" + 
                "Id: " + MiLista[4] + "\n" + 
                "Tipo motor: " + MiLista[5] + "\n" +
                "Cilindro: " + MiLista[6] + "cc" + "\n" +
                "Rueda: " + MiLista[7] + "\n" + 
                "Durometro: " + MiLista[8] + "\n" + 
                "Litros: " + MiLista[9] + "litros";
        }
    }
}
