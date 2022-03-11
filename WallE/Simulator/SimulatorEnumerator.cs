using System;
using System.Collections;
using System.Collections.Generic;
using WallE.Tools;

namespace WallE.Simulator
{
    //OK
    class SimulatorEnumerator : IEnumerator<Round>
    {
        Round current;
        bool move;
        private List<IProgrammable> programmable;

        public SimulatorEnumerator(List<IProgrammable> objects )
        {
            this.programmable = objects;
        }
        public Round Current
        {
            get
            {
                if ( !move )
                    throw new InvalidOperationException("No ha hecho .MoveNext().");
                return current;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose( )
        {
            return;
        }

        public bool MoveNext( )
        {
            RandomOrder( );
            current = new Round(programmable);
            return move = true;
        }

        public void Reset( )
        {
            current = null;
            move = false;
        }

        private void RandomOrder( )
        {
            Random rndm = new Random( );

            int[] tempIndex = new int[programmable.Count];

            for ( int i = 0; i < tempIndex.Length; i++ )
                tempIndex[i] = rndm.Next( );

            var tempProgrammable = programmable.ToArray( );
            Array.Sort(tempIndex,tempProgrammable);

            programmable = new List<IProgrammable>(tempProgrammable);
        } 

           
    }

}