using WallE.MATLAN.Instructions;

namespace WallE.MATLAN.InstructionFactory
{
    public class BackwardFactory : InstructionsFactory
    {
        public override Instruction Create( ) => new Backward( );
    }
}
