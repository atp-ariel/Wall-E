using System.Collections.ObjectModel;

namespace WallE.Tools
{
    public class InstructionEnum : EnumBaseType<InstructionEnum>
    {
        //IActions
        public static readonly InstructionEnum Forward = new InstructionEnum("forward");
        public static readonly InstructionEnum Backward = new InstructionEnum("backward");
        public static readonly InstructionEnum Left = new InstructionEnum("left");
        public static readonly InstructionEnum Right = new InstructionEnum("right");
        public static readonly InstructionEnum Drop = new InstructionEnum("drop");
        //ISensors
        public static readonly InstructionEnum Distance = new InstructionEnum("distance");
        public static readonly InstructionEnum Webcam = new InstructionEnum("color");
        public static readonly InstructionEnum Kinect = new InstructionEnum("shape");
        public static readonly InstructionEnum BarcodeScanner = new InstructionEnum("code");
        public static readonly InstructionEnum Balance = new InstructionEnum("loaded");
        public static readonly InstructionEnum Chronometer = new InstructionEnum("time");
        public static readonly InstructionEnum Compass = new InstructionEnum("direction");
        //Stacks operators
        public static readonly InstructionEnum Number = new InstructionEnum("number");
        public static readonly InstructionEnum Zero = new InstructionEnum("zero");
        public static readonly InstructionEnum One = new InstructionEnum("one");
        //Angulars
        public static readonly InstructionEnum NE = new InstructionEnum("NE");
        public static readonly InstructionEnum NW = new InstructionEnum("NW");
        public static readonly InstructionEnum SE = new InstructionEnum("SE");
        public static readonly InstructionEnum SW = new InstructionEnum("SW");
        //Conditionals
        public static readonly InstructionEnum Branch = new InstructionEnum("branch");
        //Console
        public static readonly InstructionEnum Print = new InstructionEnum("print");
        //Execution Routine 
        public static readonly InstructionEnum Return = new InstructionEnum("return");
        public static readonly InstructionEnum Start = new InstructionEnum("start");
        //Lineal Memory
        public static readonly InstructionEnum GetAt = new InstructionEnum("getAt");
        public static readonly InstructionEnum SetAt = new InstructionEnum("setAt");
        //Operators
        ////Atomic
        public static readonly InstructionEnum Dec = new InstructionEnum("dec");
        public static readonly InstructionEnum Inc = new InstructionEnum("inc");
        public static readonly InstructionEnum Lnot = new InstructionEnum("lnot");
        public static readonly InstructionEnum Not = new InstructionEnum("not");
        ////Binary
        public static readonly InstructionEnum Add = new InstructionEnum("add");
        public static readonly InstructionEnum And = new InstructionEnum("and");
        public static readonly InstructionEnum Div = new InstructionEnum("div");
        public static readonly InstructionEnum Eq = new InstructionEnum("eq");
        public static readonly InstructionEnum Geq = new InstructionEnum("geq");
        public static readonly InstructionEnum Gt = new InstructionEnum("gt");
        public static readonly InstructionEnum Land = new InstructionEnum("land");
        public static readonly InstructionEnum Leq = new InstructionEnum("leq");
        public static readonly InstructionEnum Lor = new InstructionEnum("lor");
        public static readonly InstructionEnum Lt = new InstructionEnum("lt");
        public static readonly InstructionEnum Lxor = new InstructionEnum("lxor");
        public static readonly InstructionEnum Mod = new InstructionEnum("mod");
        public static readonly InstructionEnum Mul = new InstructionEnum("mul");
        public static readonly InstructionEnum Neq = new InstructionEnum("neq");
        public static readonly InstructionEnum Or = new InstructionEnum("or");
        public static readonly InstructionEnum Sub = new InstructionEnum("sub");
        ////Ternary
        public static readonly InstructionEnum Ternary = new InstructionEnum("ternary");
        //Routine
        public static readonly InstructionEnum Call = new InstructionEnum("call");
        public static readonly InstructionEnum Routine = new InstructionEnum("routine");
        public static readonly InstructionEnum RecCall = new InstructionEnum("recCall");
        //T
        public static readonly InstructionEnum TS = new InstructionEnum("TS");
        public static readonly InstructionEnum TE = new InstructionEnum("TE");
        public static readonly InstructionEnum TN = new InstructionEnum("TN");
        public static readonly InstructionEnum TW = new InstructionEnum("TW");
        //Registry
        ////Get
        public static readonly InstructionEnum GetA = new InstructionEnum("getA");
        public static readonly InstructionEnum GetB = new InstructionEnum("getB");
        public static readonly InstructionEnum GetC = new InstructionEnum("getC");
        public static readonly InstructionEnum GetD = new InstructionEnum("getD");
        public static readonly InstructionEnum GetE = new InstructionEnum("getE");
        public static readonly InstructionEnum GetF = new InstructionEnum("getF");
        public static readonly InstructionEnum GetG = new InstructionEnum("getG");
        public static readonly InstructionEnum GetH = new InstructionEnum("getH");
        public static readonly InstructionEnum GetI = new InstructionEnum("getI");
        public static readonly InstructionEnum GetJ = new InstructionEnum("getJ");
        public static readonly InstructionEnum GetK = new InstructionEnum("getK");
        public static readonly InstructionEnum GetL = new InstructionEnum("getL");
        public static readonly InstructionEnum GetM = new InstructionEnum("getM");
        public static readonly InstructionEnum GetN = new InstructionEnum("getN");
        public static readonly InstructionEnum GetO = new InstructionEnum("getO");
        public static readonly InstructionEnum GetP = new InstructionEnum("getP");
        public static readonly InstructionEnum GetQ = new InstructionEnum("getQ");
        public static readonly InstructionEnum GetR = new InstructionEnum("getR");
        public static readonly InstructionEnum GetS = new InstructionEnum("getS");
        public static readonly InstructionEnum GetT = new InstructionEnum("getT");
        public static readonly InstructionEnum GetU = new InstructionEnum("getU");
        public static readonly InstructionEnum GetV = new InstructionEnum("getV");
        public static readonly InstructionEnum GetW = new InstructionEnum("getW");
        public static readonly InstructionEnum GetX = new InstructionEnum("getX");
        public static readonly InstructionEnum GetY = new InstructionEnum("getY");
        public static readonly InstructionEnum GetZ = new InstructionEnum("getZ");
        ////Set
        public static readonly InstructionEnum SetA = new InstructionEnum("setA");
        public static readonly InstructionEnum SetB = new InstructionEnum("setB");
        public static readonly InstructionEnum SetC = new InstructionEnum("setC");
        public static readonly InstructionEnum SetD = new InstructionEnum("setD");
        public static readonly InstructionEnum SetE = new InstructionEnum("setE");
        public static readonly InstructionEnum SetF = new InstructionEnum("setF");
        public static readonly InstructionEnum SetG = new InstructionEnum("setG");
        public static readonly InstructionEnum SetH = new InstructionEnum("setH");
        public static readonly InstructionEnum SetI = new InstructionEnum("setI");
        public static readonly InstructionEnum SetJ = new InstructionEnum("setJ");
        public static readonly InstructionEnum SetK = new InstructionEnum("setK");
        public static readonly InstructionEnum SetL = new InstructionEnum("setL");
        public static readonly InstructionEnum SetM = new InstructionEnum("setM");
        public static readonly InstructionEnum SetN = new InstructionEnum("setN");
        public static readonly InstructionEnum SetO = new InstructionEnum("setO");
        public static readonly InstructionEnum SetP = new InstructionEnum("setP");
        public static readonly InstructionEnum SetQ = new InstructionEnum("setQ");
        public static readonly InstructionEnum SetR = new InstructionEnum("setR");
        public static readonly InstructionEnum SetS = new InstructionEnum("setS");
        public static readonly InstructionEnum SetT = new InstructionEnum("setT");
        public static readonly InstructionEnum SetU = new InstructionEnum("setU");
        public static readonly InstructionEnum SetV = new InstructionEnum("setV");
        public static readonly InstructionEnum SetW = new InstructionEnum("setW");
        public static readonly InstructionEnum SetX = new InstructionEnum("setX");
        public static readonly InstructionEnum SetY = new InstructionEnum("setY");
        public static readonly InstructionEnum SetZ = new InstructionEnum("setZ");
        //Flux
        public static readonly InstructionEnum Horizontal = new InstructionEnum("horizontalFlux");
        public static readonly InstructionEnum Vertical = new InstructionEnum("verticalFlux");

        public InstructionEnum(string value) : base(value)
        {
        }

        /// <summary>
        /// Devuelve una colección de todos los posible valores de colores.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<InstructionEnum> GetValues( ) => GetBaseValues( );
        /// <summary>
        /// Devuelve un color por su identificador.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static InstructionEnum GetByID(int id) => GetBaseByID(id);

        /// <summary>
        /// Obtiene el nombre de la instruccion empezando en mayuscula.
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public static string GetName(InstructionEnum instruction)
        {
            return instruction.Value[0].ToString( ).ToUpper( ) + instruction.Value.Substring(1);
            
            //char[] tempName = instruction.Value.ToCharArray( );
            //tempName[0] = tempName[0].ToString().ToUpper()[0];
            //string name = string.Empty;

            //foreach ( var item in tempName )
            //    name += item;

            //return name;
        }

        /// <summary>
        /// Cast explícito de integer a Color.
        /// </summary>
        /// <param name="id"></param>
        public static explicit operator InstructionEnum(int id) => GetBaseByID(id);

        /// <summary>
        /// Cast explicito de Colors a integer
        /// </summary>
        /// <param name="color"></param>
        public static explicit operator int (InstructionEnum color) => color.ID;
    }
}
