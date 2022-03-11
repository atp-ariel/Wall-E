using WallE.Routine;

namespace WallE.MATLAN.Instructions
{
    public class SetA : Set
    {
        public override object Clone( ) => new SetA( );
        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('A',value);
        }
        public override string ToString( )
        {
            return "setA";
        }
        public override bool Equals(object obj)
        {
            return obj is SetA;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetB : Set
    {
        public override object Clone( ) => new SetB( );
        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('B',value);
        }
        public override string ToString( )
        {
            return "setB";
        }
        public override bool Equals(object obj)
        {
            return obj is SetB;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetC : Set
    {
        public override object Clone( ) => new SetC( );
        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('C',value);
        }
        public override string ToString( )
        {
            return "setC";
        }
        public override bool Equals(object obj)
        {
            return obj is SetC;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetD : Set
    {
        public override object Clone( ) => new SetD( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('D',value);
        }

        public override string ToString( )
        {
            return "setD";
        }
        public override bool Equals(object obj)
        {
            return obj is SetD;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetE : Set
    {
        public override object Clone( ) => new SetE( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('E',value);
        }

        public override string ToString( )
        {
            return "setE";
        }
        public override bool Equals(object obj)
        {
            return obj is SetE;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetF : Set
    {
        public override object Clone( ) => new SetF( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('F',value);
        }

        public override string ToString( )
        {
            return "setF";
        }
        public override bool Equals(object obj)
        {
            return obj is SetF;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetG : Set
    {
        public override object Clone( ) => new SetG( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('G',value);
        }

        public override string ToString( )
        {
            return "setG";
        }
        public override bool Equals(object obj)
        {
            return obj is SetG;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetH : Set
    {
        public override object Clone( ) => new SetH( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('H',value);
        }

        public override string ToString( )
        {
            return "setH";
        }
        public override bool Equals(object obj)
        {
            return obj is SetH;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetI : Set
    {

        public override object Clone( ) => new SetI( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('I',value);
        }

        public override string ToString( )
        {
            return "setI";
        }
        public override bool Equals(object obj)
        {
            return obj is SetI;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetJ : Set
    {
        public override object Clone( ) => new SetJ( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('J',value);
        }

        public override string ToString( )
        {
            return "setJ";
        }
        public override bool Equals(object obj)
        {
            return obj is SetJ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetK : Set
    {
        public override object Clone( ) => new SetK( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('K',value);
        }

        public override string ToString( )
        {
            return "setK";
        }
        public override bool Equals(object obj)
        {
            return obj is SetK;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetL : Set
    {
        public override object Clone( ) => new SetL( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('L',value);
        }

        public override string ToString( )
        {
            return "setL";
        }
        public override bool Equals(object obj)
        {
            return obj is SetL;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetM : Set
    {
        public override object Clone( ) => new SetM( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('M',value);
        }

        public override string ToString( )
        {
            return "setM";
        }
        public override bool Equals(object obj)
        {
            return obj is SetM;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetN : Set
    {
        public override object Clone( ) => new SetN( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('N',value);
        }

        public override string ToString( )
        {
            return "setN";
        }
        public override bool Equals(object obj)
        {
            return obj is SetN;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetO : Set
    {
        public override object Clone( ) => new SetO( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('O',value);
        }

        public override string ToString( )
        {
            return "setO";
        }
        public override bool Equals(object obj)
        {
            return obj is SetO;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetP : Set
    {
        public override object Clone( ) => new SetP( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('P',value);
        }

        public override string ToString( )
        {
            return "setP";
        }
        public override bool Equals(object obj)
        {
            return obj is SetP;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetQ : Set
    {
        public override object Clone( ) => new SetQ( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('Q',value);
        }

        public override string ToString( )
        {
            return "setQ";
        }
        public override bool Equals(object obj)
        {
            return obj is SetQ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetR : Set
    {
        public override object Clone( ) => new SetR( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('R',value);
        }

        public override string ToString( )
        {
            return "setR";
        }
        public override bool Equals(object obj)
        {
            return obj is SetR;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetS : Set
    {
        public override object Clone( ) => new SetS( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('S',value);
        }

        public override string ToString( )
        {
            return "setS";
        }
        public override bool Equals(object obj)
        {
            return obj is SetS;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetT : Set
    {
        public override object Clone( ) => new SetT( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('T',value);
        }

        public override string ToString( )
        {
            return "setT";
        }
        public override bool Equals(object obj)
        {
            return obj is SetT;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetU : Set
    {
        public override object Clone( ) => new SetU( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('U',value);
        }

        public override string ToString( )
        {
            return "setU";
        }
        public override bool Equals(object obj)
        {
            return obj is SetU;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetV : Set
    {
        public override object Clone( ) => new SetV( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('V',value);
        }

        public override string ToString( )
        {
            return "setV";
        }
        public override bool Equals(object obj)
        {
            return obj is SetV;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetW : Set
    {
        public override object Clone( ) => new SetW( );
        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('W',value);
        }

        public override string ToString( )
        {
            return "setW";
        }
        public override bool Equals(object obj)
        {
            return obj is SetW;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetX : Set
    {
        public override object Clone( ) => new SetX( );


        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('X',value);
        }

        public override string ToString( )
        {
            return "setX";
        }
        public override bool Equals(object obj)
        {
            return obj is SetX;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetY : Set
    {
        public override object Clone( ) => new SetY( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('Y',value);
        }

        public override string ToString( )
        {
            return "setY";
        }
        public override bool Equals(object obj)
        {
            return obj is SetY;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
    public class SetZ : Set
    {
        public override object Clone( ) => new SetZ( );

        protected override void SetByChar(Rut routine,int value)
        {
            routine.RegistryRoutine.AddValueAt('Z',value);
        }

        public override string ToString( )
        {
            return "setZ";
        }
        public override bool Equals(object obj)
        {
            return obj is SetZ;
        }
        public override int GetHashCode( )
        {
            return ToString( ).GetHashCode( ) * 2;
        }
    }
}
