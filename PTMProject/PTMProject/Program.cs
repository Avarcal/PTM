using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using Microsoft.SPOT.IO;
using Microsoft.SPOT.Time;
using System.Threading;

namespace PTMProject
{
    public class Program
    {
        //Diody - zmienne odpowiadające za wbudowane diody

        private static OutputPort led;
        private static OutputPort led1;
        private static OutputPort led2;
        private static OutputPort led3;


        public static void Main()
        {
            //Przypisanie do zmiennych odpowiednich diod na płytce
            led = new OutputPort((Cpu.Pin)60, false);
            led1 = new OutputPort((Cpu.Pin)61, false);
            led2 = new OutputPort((Cpu.Pin)62, false);
            led3 = new OutputPort((Cpu.Pin)63, false);

            while (true)
            {


                //Realizacja migania diodami za pomocą usypiania wątku oraz zmiany wartości logicznej
                led.Write(false);
                led1.Write(true);
                led2.Write(false);
                led3.Write(true);
                Thread.Sleep(500);
                led.Write(true);
                led1.Write(false);
                led2.Write(true);
                led3.Write(false);
                Thread.Sleep(500);

            }

        }

    }
}
