using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDaniel
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation() 
        {
            var product = FactoryMethod();
            var result = "Creator: The same creator's has just work with " + product.Operation();

            return result;
        }
    }
}
