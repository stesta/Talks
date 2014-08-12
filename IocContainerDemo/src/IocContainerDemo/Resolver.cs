using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocContainerDemo
{
    public class Resolver
    {
        public Resolver()
        {
        }

        public void Register<TFrom, TTo>()
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public object Resolve(Type typeToResolve)
        {
            throw new NotImplementedException();

            // try to resolve the type

            // get the first constructor and its parameters

            // return if there are no parameters
            
            // store the list of params and resolve them
            
            // invoke the constructor
            
        }
    }
}
