using System;
using System.Collections.Generic;

namespace Uranus.Domain
{
    public interface IDependencyResolver :IDependencyScope, IDisposable
    {
         

       
    }
    public interface IDependencyScope : IDisposable
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    } 
}