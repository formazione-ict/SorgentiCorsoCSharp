using System;
namespace Corso_06.Models
{
    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }
}
