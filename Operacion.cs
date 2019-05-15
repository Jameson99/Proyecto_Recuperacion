using System;
using System.Collections.Generic;
using System.Text;

namespace P._MenuComida_Jameson_Romeo_Clark_Olivares_
{
    //En esta clase se va a desarrollar gran parte del programa
    public class Operacion
    {
        //propiedades de la clase Operacion
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Operacion()
        {
            Console.WriteLine("Bienvenido a tu rutina de alimentos");
            Console.WriteLine("Selecciona el dia: " +
                "\n1-.Lunes"+
                "\n2-.Martes"+
                "\n3-.Miercoles"+
                "\n4-.Jueves"+
                "\n5.-Viernes"+
                "\n6.-Sabado"+
                "\n7.-Domingo\n");
            int day=0;
            
            day = Convert.ToInt32(Console.ReadLine());
            
            switch (day)
            {
                case 1:
                    Console.WriteLine("Selecciona momento de comida:"+
                        "\n1-.Desayuno"+
                        "\n2-.Comida"+
                        "\n3-Cena\n");
                    int platillo = 0;
                    platillo = Convert.ToInt32(Console.ReadLine());
                    if (platillo  ==1)
                    {
                        Console.WriteLine("Tazon de cereal y una manzana");
                    }
                    if (platillo ==2)
                    {
                        Console.WriteLine("Hamburguesa de queso");
                    }
                    if (platillo ==3)
                    {
                        Console.WriteLine("Sandwich de jamon");
                    }
                    break;
                case 2:
                    Console.WriteLine("Selecciona momento de comida:" +
                    "\n1-.Desayuno" +
                    "\n2-.Comida" +
                    "\n3-Cena\n");
                    int platillo1 = 0;
                    platillo1 = Convert.ToInt32(Console.ReadLine());
                    if (platillo1==1)
                    {
                        Console.WriteLine("Burrito de frijoles");
                    }
                    if (platillo1 ==2)
                    {
                        Console.WriteLine("Macarrones con pollo");
                    }
                    if (platillo1 ==3)
                    {
                        Console.WriteLine("Dos quesadillas");
                    }
                    break;
                   
                case 3:
                    Console.WriteLine("Selecciona momento de comida:" +
                     "\n1-.Desayuno" +
                     "\n2-.Comida" +
                     "\n3-Cena\n");

                    int platillo2 = 0;
                    platillo2 = Convert.ToInt32(Console.ReadLine());
                    if (platillo2 ==1)
                    {
                        Console.WriteLine("Galletas con leche");
                    }
                    if (platillo2 ==2)
                    {
                        Console.WriteLine("Alitas de pollo y ensalada");
                    }
                    if (platillo2 ==3)
                    {
                        Console.WriteLine("Sopa instantanea");
                    }

                    break;
                   
                case 4:
                    Console.WriteLine("Selecciona momento de comida:" +
                     "\n1-.Desayuno" +
                     "\n2-.Comida" +
                     "\n3-Cena\n");
                    int platillo3 = 0;
                    platillo3 = Convert.ToInt32(Console.ReadLine());
                    if (platillo3 ==1)
                    {
                        Console.WriteLine("Sandwich con mermelada");
                    }
                    if (platillo3 ==2)
                    {
                        Console.WriteLine("Estofado de pollo");
                    }
                    if (platillo3 ==3)
                    {
                        Console.WriteLine("Sandwich de pollo");
                    }
                    break;
                    
                case 5:
                    Console.WriteLine("Selecciona momento de comida:" +
                     "\n1-.Desayuno" +
                     "\n2-.Comida" +
                     "\n3-Cena\n");
                    int platillo4 = 0;
                    platillo4 = Convert.ToInt32(Console.ReadLine());
                    if (platillo4 ==1)
                    {
                        Console.WriteLine("Licuado de fresa");
                    }
                    if (platillo4 ==2)
                    {
                        Console.WriteLine("Torta de jamon");
                    }
                    if (platillo4 ==3)
                    {
                        Console.WriteLine("Tacos");
                    }
                    break;
                 
                case 6:
                    Console.WriteLine("Selecciona momento de comida:" +
                     "\n1-.Desayuno" +
                     "\n2-.Comida" +
                     "\n3-Cena\n");
                    int platillo5 = 0;
                    platillo5 = Convert.ToInt32(Console.ReadLine());
                    if (platillo5 ==1)
                    {
                        Console.WriteLine("Huevo con salsicha");
                    }
                    if (platillo5 ==2)
                    {
                        Console.WriteLine("Hot dogs");
                    }
                    if (platillo5 ==3)
                    {
                        Console.WriteLine("Sandwich de jamon");
                    }
                    break;
                case 7:
                    Console.WriteLine("Selecciona momento de comida:" +
                     "\n1-.Desayuno" +
                     "\n2-.Comida" +
                     "\n3-Cena\n");
                    int platillo6 = 0;
                    platillo6 = Convert.ToInt32(Console.ReadLine());
                    if (platillo6 ==1)
                    {
                        Console.WriteLine("Licuado de platano");
                    }
                    if (platillo6 ==2)
                    {
                        Console.WriteLine("Sopa de fideos");
                    }
                    if (platillo6 ==3)
                    {
                        Console.WriteLine("Cereal");
                    }
                    break;

                default: Console.WriteLine("Error");
                    break;
            }

        }

        



    }
}
