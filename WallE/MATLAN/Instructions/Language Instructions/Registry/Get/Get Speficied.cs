using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallE.Routine;
using WallE.Tools;

namespace WallE.MATLAN.Instructions
{
    public sealed class GetA : Get
    {
        public override object Clone( ) => new GetA( );
        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['A'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getA";
        }
        public override bool Equals(object obj)
        {
            return obj is GetA;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetB : Get
    {
        public override object Clone( ) => new GetB( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['B'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getB";
        }
        public override bool Equals(object obj)
        {
            return obj is GetB;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetC : Get
    {
        public override object Clone( ) => new GetC( );
        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['C'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getC";
        }
        public override bool Equals(object obj)
        {
            return obj is GetC;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }


    }
    public sealed class GetD : Get
    {
        public override object Clone( ) => new GetD( );
        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['D'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getD";
        }
        public override bool Equals(object obj)
        {
            return obj is GetD;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }

    }
    public sealed class GetE : Get
    {
        public override object Clone( ) => new GetE( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['E'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getE";
        }
        public override bool Equals(object obj)
        {
            return obj is GetE;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }

    }
    public sealed class GetF : Get
    {
        public override object Clone( ) => new GetF( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['F'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getF";
        }
        public override bool Equals(object obj)
        {
            return obj is GetF;
        }
        public override int GetHashCode( )
        {

            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetG : Get
    {
        public override object Clone( ) => new GetG( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['G'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getG";
        }
        public override bool Equals(object obj)
        {
            return obj is GetG;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetH : Get
    {
        public override object Clone( ) => new GetH( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['H'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getH";
        }
        public override bool Equals(object obj)
        {
            return obj is GetH;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetI : Get
    {
        public override object Clone( ) => new GetI( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['I'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getI";
        }
        public override bool Equals(object obj)
        {
            return obj is GetI;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetJ : Get
    {
        public override object Clone( ) => new GetJ( );
        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['J'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getJ";
        }
        public override bool Equals(object obj)
        {
            return obj is GetJ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetK : Get
    {
        public override object Clone( ) => new GetK( );
        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['K'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getK";
        }
        public override bool Equals(object obj)
        {
            return obj is GetK;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetL : Get
    {
        public override object Clone( ) => new GetL( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['L'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getL";
        }
        public override bool Equals(object obj)
        {
            return obj is GetL;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetM : Get
    {
        public override object Clone( ) => new GetM( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['M'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getM";
        }
        public override bool Equals(object obj)
        {
            return obj is GetM;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetN : Get
    {
        public override object Clone( ) => new GetN( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['N'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getN";
        }
        public override bool Equals(object obj)
        {
            return obj is GetN;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetO : Get
    {
        public override object Clone( ) => new GetO( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['O'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getO";
        }
        public override bool Equals(object obj)
        {
            return obj is GetO;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetP : Get
    {
        public override object Clone( ) => new GetP( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['P'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getP";
        }
        public override bool Equals(object obj)
        {
            return obj is GetP;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetQ : Get
    {
        public override object Clone( ) => new GetQ( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['Q'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getQ";
        }
        public override bool Equals(object obj)
        {
            return obj is GetQ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetR : Get
    {
        public override object Clone( ) => new GetR( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['R'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getR";
        }
        public override bool Equals(object obj)
        {
            return obj is GetR;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetS : Get
    {
        public override object Clone( ) => new GetS( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['S'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getS";
        }
        public override bool Equals(object obj)
        {
            return obj is GetS;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetT : Get
    {
        public override object Clone( ) => new GetT( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['T'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getT";
        }
        public override bool Equals(object obj)
        {
            return obj is GetT;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetU : Get
    {
        public override object Clone( ) => new GetU( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['U'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getU";
        }
        public override bool Equals(object obj)
        {
            return obj is GetU;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetV : Get
    {
        public override object Clone( ) => new GetV( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['V'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getV";
        }
        public override bool Equals(object obj)
        {
            return obj is GetV;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetW : Get
    {
        public override object Clone( ) => new GetW( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['W'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getW";
        }
        public override bool Equals(object obj)
        {
            return obj is GetW;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetX : Get
    {
        public override object Clone( ) => new GetX( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['X'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getX";
        }
        public override bool Equals(object obj)
        {
            return obj is GetX;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }

    }
    public sealed class GetY : Get
    {
        public override object Clone( ) => new GetY( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['Y'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getY";
        }
        public override bool Equals(object obj)
        {
            return obj is GetY;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public sealed class GetZ : Get
    {
        public override object Clone( ) => new GetZ( );

        protected override void GetByChar(IProgrammable robot,Rut routine)
        {
            int value = routine.RegistryRoutine['Z'];
            try { robot.Stack.Push(value); }
            catch ( Exception )
            {
                Simulator.Simulator.ReportError(robot,new Errors.Error("La pila del robot está llena, por tanto no podrá añadir ese valor."));
            }
        }
        public override string ToString( )
        {
            return "getZ";
        }
        public override bool Equals(object obj)
        {
            return obj is GetZ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
