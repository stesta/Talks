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
        private Dictionary<Type, Type> dependencyMap = new Dictionary<Type, Type>();

        public Resolver()
        {
        }

        public void Register<TFrom, TTo>()
        {
            dependencyMap.Add(typeof(TFrom), typeof(TTo));
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        public object Resolve(Type typeToResolve)
        {
            // try to resolve the type
            Type resolvedType = null;
            try
            {
                resolvedType = dependencyMap[typeToResolve];
            }
            catch
            {
                var messages = string.Format("could not resolve type: {0}", typeToResolve.FullName);
                throw new Exception(messages);
            }
                  
            // get the first constructor and its parameters
            var firstConstructor = resolvedType.GetConstructors().First();
            var constructorParams = firstConstructor.GetParameters();
            
            // return if there are no parameters
            if (constructorParams.Count() == 0)
                return Activator.CreateInstance(resolvedType);
            
            // store the list of params and resolve them
            IList<object> parameters = new List<object>();
            foreach(var paramToResolve in constructorParams)
            {
                parameters.Add(Resolve(paramToResolve.ParameterType));
            }
            
            // invoke the constructor
            return firstConstructor.Invoke(parameters.ToArray());
        }
    }
}
