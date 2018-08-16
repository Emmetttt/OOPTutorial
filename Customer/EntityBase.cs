using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        //Abstract cannot be instantiated, only a base class for others.
        //Concrete can be instantiated

        //Sealed cannot be inherited from
        //     Prevents customisation
        public bool IsNew { get; private set; } //Private, only base class can access
        public bool HasChanges { get; set; }
        public EntityStateOption EntityState { get; set; }
        public abstract bool Validate();
        //Abstract method must be overridden
            
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }
    }
}
