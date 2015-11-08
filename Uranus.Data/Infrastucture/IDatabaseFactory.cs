using System;

namespace Uranus.Data.Infrastucture
{
    public interface IDatabaseFactory : IDisposable
    {
        DatabaseContext Get();
    }
}