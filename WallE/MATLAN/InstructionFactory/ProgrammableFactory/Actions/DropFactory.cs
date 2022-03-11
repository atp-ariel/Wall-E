using WallE.MATLAN.Instructions;

namespace WallE.MATLAN.InstructionFactory
{
    public class DropFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Drop( );
    }
}
