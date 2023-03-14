using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiTheBindableInfrastructure
{
    internal class TypeInformation
    {
        bool isBaseGenericType;
        Type baseGenericTypeDef;
        private Type type;
        private bool isXamarinForms;

        public TypeInformation()
        {
            
        }
        public TypeInformation(Type type, bool isXamarinForms)
        {
            this.Type = type;
            this.IsXamarinForms = isXamarinForms;
            TypeInfo typeInfo = type.GetTypeInfo();
            BaseType = typeInfo.BaseType;

            if (BaseType != null)
            {
                TypeInfo baseTypeInfo = BaseType.GetTypeInfo();
                isBaseGenericType = baseTypeInfo.IsGenericType;

                if (isBaseGenericType)
                {
                    baseGenericTypeDef = baseTypeInfo.GetGenericTypeDefinition();
                }

            }
           
        }

        public Type Type { get; private set; }
        public Type BaseType { get; private set; }
        public bool IsXamarinForms { private set; get; }

        public bool IsDerivedDirectlyFrom(Type parentType)
        {
            if (BaseType != null && isBaseGenericType)
            {
                if (baseGenericTypeDef == parentType)
                {
                    return true;
                }
            }
            else if (BaseType == parentType)
            {
                return true;
            }
            return false;
        }
    }
}
