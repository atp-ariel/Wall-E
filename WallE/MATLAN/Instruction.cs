using System;
using System.Collections.Generic;
using WallE.Tools;

namespace WallE.MATLAN
{
    public abstract class Instruction : ICloneable
    {
        private static Dictionary<string,InstructionsFactory> factories;
        public static Instruction ExecuteCreation(string nameInstructions)
        {
            if ( factories == null )
            {
                factories = new Dictionary<string,InstructionsFactory>( );
                foreach ( var instruction in InstructionEnum.GetValues( ) )
                {
                    var factory = (InstructionsFactory) Activator.CreateInstance(Type.GetType("WallE.MATLAN.InstructionFactory." + InstructionEnum.GetName(instruction) + "Factory"));

                    factories.Add(instruction.Value,factory);
                }
            }
            if ( !factories.ContainsKey(nameInstructions) )
            {
                var arrayKeys = GetNewListAddedOne(factories.Keys,nameInstructions).ToArray();
                Array.Sort(arrayKeys);

                int index = 0;
                for ( int i = 0; i < arrayKeys.Length; i++ )
                    if(arrayKeys[i] == nameInstructions )
                    {
                        index = i;
                        break;
                    }
                string tempResult = string.Empty;
                if ( index == 0 )
                    tempResult = arrayKeys[index + 1];
                else
                    tempResult = arrayKeys[index - 1];

                throw new InvalidOperationException("Instrucción: \"" + nameInstructions + "\" inexistente. Quizás quisiste decir: \"" + tempResult + "\".");
            }
            return factories[nameInstructions].Create( );
        }
        private static List<string> GetNewListAddedOne(Dictionary<string,InstructionsFactory>.KeyCollection keys,string toAdd)
        {
            List<string> list = new List<string>( );
            foreach ( var item in keys )
                list.Add(item);
            list.Add(toAdd);
            return list;
        }
        public abstract object Clone( );
        public abstract void Execute(IProgrammable robot);

    }
}
