using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Tools;
using WallE.MATLAN;
using WallE.MATLAN.InstructionFactory;
using WallE.MATLAN.Instructions;
using WallE.World.WorldObjects;
using WallE.World;
using WallE.Simulator;
using WallE.Routine;
using System.Reflection;
using WallE.World.WorldObjectsFactory;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            //#region Case 1
            ////Map m = new Map(1,5);
            ////Robot r1 = new Robot(new Position(), ref m);
            ////new Sphere( new Position(0,1), ref m, 1);
            ////new Plant(new Position(0,3),ref m,1);
            ////new Sphere(new Position(0, 4), ref m, 1);


            ////Rut mainR1 = new Rut( );
            ////mainR1.Body.AddRowAt(2);
            ////mainR1.Body.AddColumnAt(4);


            ////mainR1.Body.AddStartAt(new Position(0,0));
            ////mainR1.Body.AddInstructionAt(new Forward( ),new Position(1,0));
            ////mainR1.Body.AddInstructionAt(new NE( ),new Position(2,0));
            ////mainR1.Body.AddInstructionAt(new Drop( ),new Position(2,1));
            ////mainR1.Body.AddInstructionAt(new Forward( ),new Position(2,2));
            ////mainR1.Body.AddInstructionAt(new Forward( ),new Position(2,3));
            ////mainR1.Body.AddInstructionAt(new Return( ),new Position(2,4));

            ////r1.ListRoutine.AddRoutine(mainR1);
            //#endregion

            //#region Case 2
            ////Map m = new Map(5,5);
            ////Robot r1 = new Robot(2);

            ////Rut mR1 = new Rut( );

            ////mR1.Body.AddColumnAt(3);
            ////mR1.Body.AddRowAt(3);

            ////mR1.Body.AddStartAt(new Position( ));
            ////mR1.Body.AddInstructionAt(new NE( ),new Position(1,0));
            ////mR1.Body.AddInstructionAt(new Forward( ),new Position(1,1));
            ////mR1.Body.AddInstructionAt(new Forward( ),new Position(1,2));
            ////mR1.Body.AddInstructionAt(new SW( ),new Position(1,3));
            ////mR1.Body.AddInstructionAt(new SE( ),new Position(2,0));
            ////mR1.Body.AddInstructionAt(new Drop( ),new Position(2,1));
            ////mR1.Body.AddInstructionAt(new Left( ),new Position(2,2));
            ////mR1.Body.AddInstructionAt(new NW( ),new Position(2,3));
            ////mR1.Body.AddInstructionAt(new NE( ),new Position(3,0));
            ////mR1.Body.AddInstructionAt(new Left( ),new Position(3,1));
            ////mR1.Body.AddInstructionAt(new Forward( ),new Position(3,2));
            ////mR1.Body.AddInstructionAt(new Forward( ),new Position(3,3));

            ////r1.ListRoutine.AddRoutine(mR1);

            ////WallEObjects s = new Sphere(3,1);
            ////Robot r2 = new Robot(2);

            ////Rut mr2 = new Rut( );

            ////mr2.Body.AddColumnAt(1);
            ////mr2.Body.AddRowAt(5);

            ////mr2.Body.AddStartAt(new Position( ));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(1,0));
            ////mr2.Body.AddInstructionAt(new Right( ),new Position(2,0));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(3,0));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(4,0));
            ////mr2.Body.AddInstructionAt(new NE( ),new Position(5,0));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(0,1));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(1,1));
            ////mr2.Body.AddInstructionAt(new Left( ),new Position(2,1));
            ////mr2.Body.AddInstructionAt(new Forward( ),new Position(3,1));
            ////mr2.Body.AddInstructionAt(new Left( ),new Position(4,1));
            ////mr2.Body.AddInstructionAt(new NW( ),new Position(5,1));

            ////r2.ListRoutine.AddRoutine(mr2);

            ////WallEObjects b = new Box(1);
            ////WallEObjects p5 = new Plant(1);
            ////WallEObjects p6 = new Plant( );
            ////WallEObjects s7 = new Sphere(1);

            ////m.AddNewObjectAt(r1,new Position( ));
            ////m.AddNewObjectAt(s,new Position(1,1));
            ////m.AddNewObjectAt(r2,new Position(0,3));
            ////m.AddNewObjectAt(b,new Position(2,2));
            ////m.AddNewObjectAt(p5,new Position(3,4));
            ////m.AddNewObjectAt(p6,new Position(1,3));
            ////m.AddNewObjectAt(s7,new Position(2,0));
            //#endregion

            //#region Case 3
            //Map m = new Map(4,3);

            //Robot r1 = new Robot(new Position(1,1),ref m,2);

            //Rut main = new Rut( );
            //main.Body.AddColumnAt(3);
            //main.Body.AddRowAt(5);

            //main.Body.AddStartAt(new Position( ));
            //main.Body.AddInstructionAt(new NE( ),new Position(1,0));
            //main.Body.AddInstructionAt(new Forward( ),new Position(1,1));
            //main.Body.AddInstructionAt(new SW( ),new Position(1,2));
            //main.Body.AddInstructionAt(new NW( ),new Position(2,2));
            //main.Body.AddInstructionAt(new Right( ),new Position(2,1));
            //main.Body.AddInstructionAt(new SE( ),new Position(2,0));
            //main.Body.AddInstructionAt(new NE( ),new Position(3,0));
            //main.Body.AddInstructionAt(new Kinect( ),new Position(3,1));
            //main.Body.AddInstructionAt(new SW( ),new Position(3,2));
            //main.Body.AddInstructionAt(new Branch( ),new Position(4,2));
            //main.Body.AddInstructionAt(new Forward( ),new Position(4,3));
            //main.Body.AddInstructionAt(new Left( ),new Position(4,1));
            //main.Body.AddInstructionAt(new Forward( ),new Position(4));

            //r1.ListRoutine.AddRoutine(main);

            //Robot r2 = new Robot(new Position( ),ref m,2);

            //Rut main2 = new Rut( );
            //main2.Body.AddRowAt(3);
            //main2.Body.AddColumnAt(-1);



            //main2.Body.AddStartAt(new Position( ));
            //main2.Body.AddInstructionAt(new Forward( ),new Position(1,0));
            //main2.Body.AddInstructionAt(new Forward( ),new Position(2,0));
            //main2.Body.AddInstructionAt(new Forward( ),new Position(3,0));

            //r2.ListRoutine.AddRoutine(main2);

            //Robot r3 = new Robot(new Position(3,2),ref m,3);

            //Rut main3 = new Rut( );
            //main3.Body.AddColumnAt(6);
            //main3.Body.AddRowAt(3);

            //main3.Body.AddStartAt(new Position( ));
            //main3.Body.AddInstructionAt(new NE( ),new Position(1));
            //main3.Body.AddInstructionAt(new Number( ),new Position(1,1));
            //main3.Body.AddInstructionAt(new One( ),new Position(1,2));
            //main3.Body.AddInstructionAt(new Zero( ),new Position(1,3));
            //main3.Body.AddInstructionAt(new One( ),new Position(1,4));
            //main3.Body.AddInstructionAt(new One( ),new Position(1,5));
            //main3.Body.AddInstructionAt(new SW( ),new Position(1,6));
            //main3.Body.AddInstructionAt(new NW( ),new Position(2,6));
            //main3.Body.AddInstructionAt(new Routine( ),new Position(2,5));
            //main3.Body.AddInstructionAt(new Number( ),new Position(2,4));
            //main3.Body.AddInstructionAt(new One( ),new Position(2,3));
            //main3.Body.AddInstructionAt(new Add( ),new Position(2,2));
            //main3.Body.AddInstructionAt(new SE( ),new Position(2));
            //main3.Body.AddInstructionAt(new NE( ),new Position(3));
            //main3.Body.AddInstructionAt(new Call( ),new Position(3,1));
            //main3.Body.AddInstructionAt(new Print( ),new Position(3,2));

            //Rut fibo = new Rut( );
            //fibo.Body.AddRowAt(6);
            //fibo.Body.AddColumnAt(9);

            //fibo.Body.AddStartAt(new Position( ));
            //fibo.Body.AddInstructionAt(new GetF( ),new Position(0,1));
            //fibo.Body.AddInstructionAt(new GetI( ),new Position(0,2));
            //fibo.Body.AddInstructionAt(new GetB( ),new Position(0,3));
            //fibo.Body.AddInstructionAt(new GetO( ),new Position(0,4));
            //fibo.Body.AddInstructionAt(new GetN( ),new Position(0,5));
            //fibo.Body.AddInstructionAt(new GetA( ),new Position(0,6));
            //fibo.Body.AddInstructionAt(new GetC( ),new Position(0,7));
            //fibo.Body.AddInstructionAt(new GetC( ),new Position(0,8));
            //fibo.Body.AddInstructionAt(new GetI( ),new Position(0,9));

            //fibo.Body.AddInstructionAt(new SetN( ),new Position(1,0));
            //fibo.Body.AddInstructionAt(new NE( ),new Position(2));
            //fibo.Body.AddInstructionAt(new GetN( ),new Position(2,1));
            //fibo.Body.AddInstructionAt(new Number( ),new Position(2,2));
            //fibo.Body.AddInstructionAt(new One( ),new Position(2,3));
            //fibo.Body.AddInstructionAt(new Gt( ),new Position(2,4));
            //fibo.Body.AddInstructionAt(new SW( ),new Position(2,5));
            //fibo.Body.AddInstructionAt(new Branch( ),new Position(3,5));
            //fibo.Body.AddInstructionAt(new Number( ),new Position(3,6));
            //fibo.Body.AddInstructionAt(new One( ),new Position(3,7));
            //fibo.Body.AddInstructionAt(new SE( ),new Position(3));
            //fibo.Body.AddInstructionAt(new NE( ),new Position(4));
            //fibo.Body.AddInstructionAt(new GetN( ),new Position(4,1));
            //fibo.Body.AddInstructionAt(new Number( ),new Position(4,2));
            //fibo.Body.AddInstructionAt(new One( ),new Position(4,3));
            //fibo.Body.AddInstructionAt(new Sub( ),new Position(4,4));
            //fibo.Body.AddInstructionAt(new RecCall( ),new Position(4,5));
            //fibo.Body.AddInstructionAt(new SW( ),new Position(4,6));
            //fibo.Body.AddInstructionAt(new NW( ),new Position(5,6));
            //fibo.Body.AddInstructionAt(new SE( ),new Position(5));
            //fibo.Body.AddInstructionAt(new NE( ),new Position(6));
            //fibo.Body.AddInstructionAt(new GetN( ),new Position(6,1));
            //fibo.Body.AddInstructionAt(new Number( ),new Position(6,2));
            //fibo.Body.AddInstructionAt(new One( ),new Position(6,3));
            //fibo.Body.AddInstructionAt(new Zero( ),new Position(6,4));
            //fibo.Body.AddInstructionAt(new Sub( ),new Position(6,5));
            //fibo.Body.AddInstructionAt(new RecCall( ),new Position(6,6));
            //fibo.Body.AddInstructionAt(new Add( ),new Position(6,7));

            //r3.ListRoutine.AddRoutine(/*main3,*/fibo);
            //r3.Stack.Push(11);
            //new Sphere(new Position(1,0),ref m,1);
            //new Sphere(new Position(2,0),ref m,1);
            //new Box(new Position(2,2),ref m,3);

            //  Robot r4 = new Robot(new Position(0,0), ref m,1,1);

            bool load = false;

            var maintemp = ControllerRoutine.LoadRoutine(@"C:\Users\Ariel\Desktop\asdghj.txt", out load);

            if ( !load )
                return;





            //#endregion
            WallE_Console.OnPrint += WallE_Console_OnPrint;
            ////#region Simulator
            //Simulator sim = new Simulator(m);
            //while ( true )
            //{
            //    Console.WriteLine(sim.World);
            //    ConsoleKey key;
            //    while ( ( key = Console.ReadKey( ).Key ) == ConsoleKey.Spacebar )
            //    {
            //        sim.Advance( );
            //        Console.WriteLine(sim.World);

            //    }
            //    Console.Clear( );
            //    if ( key == ConsoleKey.S )
            //        sim.Stop( );
            //    else if ( key == ConsoleKey.P )
            //        sim.Pause( );
            //}
            //#endregion

            //foreach ( var item in m.SelectIProgrammables() )
            //{
            //    Console.WriteLine(item);
            //}

            //var a = ControllerRoutine.LoadRoutine(@"D:\Escuela\Ciencias de la Computacion\1 Año\Segundo Semestre\Programacion\Wall-E (El retorno)\Casos de Prueba\Caso 3\fibonacci.txt");
            //Console.WriteLine(a);


        }

        private static void WallE_Console_OnPrint(object sender,EventArgs e)
        {
            Console.WriteLine(sender.ToString() + ": " + WallE_Console.Message);
        }
    }
}