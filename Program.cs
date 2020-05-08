using System;

namespace AgenciaVehiculos
{
    class Program
    {
        public static void Main(string[] args)
        {
            int contraseña;
            string admin;
            Console.WriteLine("Ingrese nombre: ");
            admin = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña: ");
            contraseña = int.Parse(Console.ReadLine()); //ENTRA UN STRING Y LO CONVERTIMOR EN UN INT Y LO GUARDAMOS

            while (contraseña != 1234 || admin != "admin")
            {
                Console.WriteLine("Fallo al iniciar sesion");
                Console.WriteLine("Ingrese usuario: ");
                admin = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña: ");
                contraseña = int.Parse(Console.ReadLine());
            }
            int opcion = 0;
            //INSTANCIAR
            Automovil ingresar = new Automovil();

            do
            {
                Console.WriteLine("Eliga una opcion:\n" +
                "1. Ingresar datos" + "\n" +
                "2. Mostrar datos" + "\n" +
                "3. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese nombe de marca: ");
                        string otro = Console.ReadLine();
                        ingresar.MarcaVehiculo(otro);
                        //INGRESAR AÑO
                        Console.WriteLine("Ingrese año de automovil: ");
                        int AñoAutomovil = int.Parse(Console.ReadLine());
                        ingresar.AñoVehiculo(AñoAutomovil);
                        while (AñoAutomovil > 2020 || AñoAutomovil < 1886)
                        {
                            Console.WriteLine("Error al ingresar el año");
                            Console.WriteLine("Ingrese año de automovil: ");
                            AñoAutomovil = int.Parse(Console.ReadLine());
                            ingresar.AñoVehiculo(AñoAutomovil);
                        }
                        //INGRESAR KILOMETRAJE
                        Console.WriteLine("Ingrese kilometraje: ");
                        int kilometraje = int.Parse(Console.ReadLine());
                        ingresar.KilometrajeVehiculo(kilometraje);
                        //TIPO RECUBRIMIENTO
                        TipoRecubrimiento fenol = TipoRecubrimiento.FENOL;
                        TipoRecubrimiento hule = TipoRecubrimiento.HULE;
                        TipoRecubrimiento poli = TipoRecubrimiento.POLIUTERANO;
                        Console.WriteLine("Tipos de recubrimiento: " + "\n" +
                            "0." + fenol + "\n" +
                            "1." + hule + "\n" +
                            "2." + poli); ;
                        int opcion_recubrimiento = int.Parse(Console.ReadLine());
                        switch (opcion_recubrimiento)
                        {
                            case 0:
                                ingresar.Opcion(opcion_recubrimiento);
                                break;
                            case 1:
                                ingresar.Opcion(opcion_recubrimiento);
                                break;
                            case 2:
                                ingresar.Opcion(opcion_recubrimiento);
                                break;
                            default:
                                Console.WriteLine("Ingrese un valor valido");
                                break;
                        }
                        //INGRESAR ID MOTOR
                        Console.WriteLine("Ingrese id motor: ");
                        int id = int.Parse(Console.ReadLine());
                        ingresar.IdMotor(id);
                        //INGRESAR TIPO MOTOR
                        TipoMotor dos_tiempos = TipoMotor.DOS_TIEMPOS;
                        TipoMotor cuatro_tiempos = TipoMotor.CUATRO_TIEMPOS;
                        Console.WriteLine("Seleccione tipo motor: " + "\n" +
                            "0." + dos_tiempos + "\n" +
                            "1." + cuatro_tiempos + "\n");
                        int opcion_motor = int.Parse(Console.ReadLine());
                        ingresar.OpcionMotor(opcion_motor);
                        //CILINDRO
                        Console.WriteLine("Ingrese cantidad de cilindro: ");
                        int cilindro = int.Parse(Console.ReadLine());
                        ingresar.Cilindrada(cilindro);
                        //NUMERO RUEDAS
                        Console.WriteLine("Ingrese cantidad de ruedas (entre 2 y 16): ");
                        int rueda = int.Parse(Console.ReadLine());
                        while (rueda < 2 || rueda > 16)
                        {
                            Console.WriteLine("Debe ingresar una cantidad de ruedas correctas");
                            Console.WriteLine("Ingrese cantidad de ruedas (entre 2 y 16): ");
                            rueda = int.Parse(Console.ReadLine());
                        }
                        ingresar.Rueda(rueda);
                        //DUROMETRO
                        Console.WriteLine("Ingrese durometro (entre 100 y 180): ");
                        int durometro = int.Parse(Console.ReadLine());
                        while (durometro < 100 || durometro > 180)
                        {
                            Console.WriteLine("Debe ingresar entre el rango requerido");
                            Console.WriteLine("Ingrese durometro (entre 100 y 180): ");
                            durometro = int.Parse(Console.ReadLine());
                        }
                        ingresar.Durometro(durometro);
                        Console.WriteLine("Ingrese Litros del vehiculo");
                        //LITROS s
                        int litros = int.Parse(Console.ReadLine());
                        while(litros == 0)
                        {
                            Console.WriteLine("Ingrese un numero mayor a 0 Litros");
                            Console.WriteLine("Ingrese Litros del vehiculo");
                            litros = int.Parse(Console.ReadLine());
                        }
                        ingresar.Litro(litros);
                        break;
                    case 2:
                        Console.WriteLine(ingresar.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 3);
            
        }
    }
}
