using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTheBindableInfrastructure
{
    internal class ClassAndSubclasses
    {
        public ClassAndSubclasses()
        {
            
        }
        public ClassAndSubclasses(Type parent, bool isXamarinForms)
        {
            Type Type = parent;
            IsXamarinForms = isXamarinForms;
            Subclasses = new List<ClassAndSubclasses>();
        }

        public Type Type { private set; get; }
        public bool IsXamarinForms { private set; get; }
        public List<ClassAndSubclasses> Subclasses { private set; get; }

    }
}
