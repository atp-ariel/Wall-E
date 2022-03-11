using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallETools
{
    /// <summary>
    /// Simula el funcionamiento de un enum pero este es extensible.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EnumBaseType<T> where T : EnumBaseType<T>
    {
        protected static List<T> enumValues = new List<T>( );

        public readonly int ID;
        public readonly string Value;

        public EnumBaseType(string value)
        {
            this.Value = value;
            enumValues.Add((T) this);
            this.ID = enumValues.Count - 1;
        }
        protected static ReadOnlyCollection<T> GetBaseValues( )
        {
            return enumValues.AsReadOnly( );
        }
        protected static T GetBaseByID(int id)
        {
            if ( id < 0 )
                throw new ArgumentException("Llave no válida.");
            foreach ( T t in enumValues )
                if ( t.ID == id )
                    return t;
            return null;
        }
        public override string ToString( )
        {
            return this.Value;
        }
    }
}
