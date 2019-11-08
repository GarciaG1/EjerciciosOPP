using System;

namespace Duracion
{
  //clase Duracion
    class Duracion
    {
        //Declaracion
        public int horas;
        public int minutos;
        public int segundos;
         //constructor de la clase
        public Duracion (int h, int m,int s)
        {
            this.horas=h;
            this.minutos=m;
            this.segundos=s;
        }
        
        public Duracion (int s)
        {
            this.segundos=s;
        }
         //imprime las horas,minutos y segundos iniciales
        public void print()
        {
            Console.WriteLine("Duracion=["+horas+":"+minutos+":"+segundos+"]");
        }
            //imprime los segundos de a+b
        public void print2()
        {
            
            Console.WriteLine("a+b= "+segundos);
        }

        //convierte las horas y minutos a segundos y me retorna segundos
        public int get_segundos()
        {
            int s;
            s=(minutos*60)+(horas*3600)+segundos;

            return s;
        }
        //convierte las horas a minutos y me retorna minutos

        public int get_minutos()
        {
            int m;
            m= minutos=(horas*60)+minutos;

            return m;
        }
        //sobre cargaa de operador
        public static Duracion operator +(Duracion a, Duracion b)
        {
            int sum=0;
            sum=sum+(a.horas+b.horas)*3600;
            sum=sum+(a.minutos+b.minutos)*60;
            sum=sum+(a.segundos+b.segundos);

            return new Duracion (sum);


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
           Duracion Total = new Duracion(03,20,10);
            Duracion a= new Duracion (5,22,43);
            Duracion b= new Duracion(07,23,08);
            Duracion c;
            
           //manda a llamar al primer imprime(horas,minutos y segundos iniciales)
           Total.print();
           //imprime el total de minutos
           Console.WriteLine("Minutos:"+Total.get_minutos());
            //imprime el total de segundos
           Console.WriteLine("Segundos:"+Total.get_segundos());
           //suma de a+b
            c=a+b;
            //manda a llamar el segundo imprime (suma de a+b)
           c.print2();
        }

    }
}