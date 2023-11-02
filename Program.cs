using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace OPP
{
    class Program
    {
        public static void Main(string [] args)
        {
            
            List<Familias> fam = new List<Familias>();
            string apellido = " ";
            String nombreAnimal = " ";
            string tiposEspecies = " ";
            int opc = 0;
            bool verificacion = true;
            while (verificacion)
            {
                    Console.WriteLine("GESTION DE FAMILIAS Y MASCOTAS "+
                    "\n 1- Gestionar Familias " +
                    "\n 2- Mostrar Familias " + 
                    "\n 3- Salir");
                    opc = int.Parse(Console.ReadLine());
                
                    switch (opc)
                    {
                        case 1:
                        Console.WriteLine($"Ingrese el apellido de la familia");
                        apellido = Console.ReadLine();

                        Console.WriteLine($"Ingrese el nombre de la mascota para la familia {apellido}");
                        nombreAnimal = Console.ReadLine();

                        Console.WriteLine($"Ingrese el tipo de especie de la mascota {nombreAnimal}");
                        tiposEspecies = Console.ReadLine();

                        Mascotas mascotas = Mascotas.getMascotas(nombreAnimal, tiposEspecies);
                        Familias familias = new Familias(apellido, mascotas);
                        fam.Add(familias);
                        Console.WriteLine("Se agrego una familia correctamente");

                    break;

                    case 2:
                    foreach (var fami in fam)
                    {
                        Console.WriteLine(fami.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    break;

                    case 3:
                        verificacion = false;
                    break;
                    
                    }
                }      
        } 
    }
}
