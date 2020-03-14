using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_A2_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo<Deportista> equipo = new Equipo<Deportista>();

            List<Basketbolista> basquet = new List<Basketbolista>();
            List<Futbolista> fut = new List<Futbolista>();
            List<Beisbolistas> beis = new List<Beisbolistas>();
            List<Voleibolista> volei = new List<Voleibolista>();

            //equipo.AgregarIntegrante(new Deportista("19Te0018P", "Arturo", "Flores", "rivera", 32, "Masculino", 1.70, 70));
            //equipo.AgregarIntegrante(new Deportista("19Te0018P", "Arturo", "Flores", "rivera", 32, "Masculino", 1.70, 70));
            //equipo.AgregarIntegrante(new Deportista("19Te0018P", "Arturo", "Flores", "rivera", 32, "Masculino", 1.70, 70));
            //equipo.AgregarIntegrante(new Deportista("19Te0018P", "Arturo", "Flores", "rivera", 32, "Masculino", 1.70, 70));
            //equipo.Eliminar(new Futbolista("000000", "Arturo", "Flores", "rivera", 32, "Masculino", 1.70, 70));
            //equipo.Eliminar(new Deportista("19Te0018P", "Juan", "Flores", "Rivera", 31, "Masculino", 1.60, 78));


            /////////////
            //equipo.AgregarIntegrante(new Futbolista("20","Mayra", "Gomez", "Garcia", 20, "Femenino", 1.50, 50, "delantero", 0, 0, 0));
            equipo.AgregarIntegrante(new Futbolista("21", "Helena", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, "portero", 5, 0, 0));

            equipo.AgregarIntegrante(new Basketbolista("21", "Helena", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, 0, 0, 5));
            equipo.AgregarIntegrante(new Beisbolistas("22", "JAvier", "Lopez", "Perez", 30, "MAsculino", 1.7, 60, 5, 2, 3, 6));
            equipo.AgregarIntegrante(new Voleibolista("23", "antonio", "ramirez", "Gonzalez", 28, "Masculino", 1.8, 65, 5, 0, 5));

            ///////////////////////////////////////////////////////
            basquet.Add(new Basketbolista("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, 0, 0, 5));
            basquet.Add(new Basketbolista("2019", "Hilda", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, 0, 0, 5));
            fut.Add(new Futbolista("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino", 1.45, 50, "Delantero", 5, 0, 5));
            fut.Add(new Futbolista("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino", 1.45, 50, "Delantero", 5, 0, 5));

            /////////////////
            byte option;
            Console.WriteLine("Elige una opción:\n1.Visualizar deportistas\n2.Agregar\n3.Elminar");
            option = Convert.ToByte(Console.ReadLine());

            switch(option)
            {
                case 1:
                    foreach (Deportista b in equipo)
                    {
                        Console.WriteLine(b);
                    }
                    foreach (Basketbolista b in basquet)
                    {
                        Console.WriteLine(b);
                    }
                    foreach (Beisbolistas b in beis)
                    {
                        Console.WriteLine(b);
                    }
                    foreach (Futbolista f in fut)
                    {
                        Console.WriteLine(f);
                    }
                    foreach (Voleibolista v in volei)
                    {
                        Console.WriteLine(v);
                    }

                    break;
                case 2:
                    byte op;

                    Console.WriteLine("Elige una opción:\n1.BAsketbolistas\n2.Beisbolistas\n3.Futbolistas\n4.Voleiblistas");
                    op = Convert.ToByte(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            //basquet.Add(new Basketbolista("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, 0, 0, 5));
                            //basquet.Add(new Basketbolista("2019", "Hilda", "Castillo", "Ramirez", 25, "Femenino", 1.5, 55, 0, 0, 5));
                            //Console.WriteLine("Datos agregados correctamente");
                            var bas = new Basketbolista("21", "Juan", "Castillo", "Lozano", 25, "Masculino", 1.5, 55, 0, 0, 5);
                            if (Predicados.ValidarSexo(bas))
                            {
                                basquet.Add(bas);
                                Console.WriteLine("Agregado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("Los datos no se pudieron agregar porque el equipo es femenil");
                            }

                            foreach (Basketbolista b in basquet)
                            {
                                Console.WriteLine(b);
                            }
                            break;

                         
                        case 2:
                            //beis.Add(new Beisbolistas("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino",1.45,50,5,0,2,0));
                            //beis.Add(new Beisbolistas("21", "Adriana", "Sedano", "Parra", 20, "Femenino", 1.45, 50, 5, 0, 2, 0));
                            //Console.WriteLine("Datos agregados correctamente");
                            var beisbolista= new Beisbolistas("21", "Sandra", "Castillo", "Ramirez", 25, "Femenino", 1.45, 50, 5, 0, 2, 0);
                            if (Predicados.ValidarSexo(beisbolista))
                            {
                                beis.Add(beisbolista);
                                Console.WriteLine("Agregado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("Los datos no se pudieron agregar porque el equipo es femenil");
                            }

                            foreach (Beisbolistas b in beis)
                            {
                                Console.WriteLine(b);
                            }
                            break;

                        case 3:
                            var futbolista = new Futbolista("19te0019", "Mayra", "Gomez", "Garcia", 29, "Femenino", 1.60, 60,"", 0, 0, 0);

                            if(Predicados.ValidarSexo(futbolista))
                            {
                                fut.Add(futbolista);
                                Console.WriteLine("Agregado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("Los datos no se pudieron agregar porque el equipo es femenil");
                            }
 
                            foreach (Futbolista b in fut)
                            {
                                Console.WriteLine(b);
                            }
                            break;

                        case 4:
                            //volei.Add(new Voleibolista("21", "Nora", "Andrade", "Ramirez", 20, "Femenino", 1.45,50,0,0,0));
                            //volei.Add(new Voleibolista("22", "Lizbeth", "Rios", "Rosas", 25, "Femenino", 1.45, 50, 0, 0, 0));
                            //Console.WriteLine("Datos agregados correctamente");

                            var vol = new Voleibolista("21", "Nora", "Andrade", "Ramirez", 20, "Femenino", 1.45, 50, 0, 0, 0);

                            if (Predicados.ValidarSexo(vol))
                            {
                                volei.Add(vol);
                                Console.WriteLine("Agregado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("Los datos no se pudieron agregar porque el equipo es femenil");
                            }




                            foreach (Voleibolista b in volei)
                            {
                                Console.WriteLine(b);
                            }
                            break;
                    }

                    
                    break;
                case 3:

                    equipo.Eliminar(new Futbolista("20", "Mayra", "Gomez", "Garcia", 20, "Femenino", 1.50, 50, "delantero", 0, 0, 0));
                    equipo.AgregarIntegrante(new Futbolista("19", "Mayra", "Gomez", "Garcia", 20, "Femenino", 1.50, 50, "delantero", 0, 0, 0));

                    break;

                default:
                    Console.WriteLine("opcion no valida");
                    break;

            }
            
            Console.ReadKey();



            ////////////////////////////
        }
    }
}
