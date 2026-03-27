using System;
using System.Data;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_12_Adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region adv01
            //Q1: What is a generic class? Why use generics?.
            //A generic class is a class that works with any data type using a placeholder(like T)..

            //Why use generics:.

            //-Code reuse
            //-Type safety(no casting)
            //-Better performance
            //================================================================================================
            //================================================================================================

            //Q2: Write a generic class Container<T> with Add and Get methods.
            //public class Container<T>
            // {
            //      private T item;

            //      public void Add(T value)
            //      {
            //          item = value;
            //      }

            //      public T Get()
            //      {
            //          return item;
            //      }
            //  }

            //================================================================================================
            //================================================================================================

            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.

            //Using more than one generic type.

            //public class Pair<TKey, TValue>
            //        {
            //            public TKey Key { get; set; }
            //            public TValue Value { get; set; }
            //        }

            //================================================================================================
            //================================================================================================

            //Q4:  What is a generic method? Write Swap<T> method.

            //A generic method works with any type.

            //public static void Swap<T>(ref T a, ref T b)
            //        {
            //            T temp = a;
            //            a = b;
            //            b = temp;
            //        }

            //================================================================================================
            //================================================================================================

            //Q5: Write a generic method FindMax<T> that finds maximum value
            //public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //        {
            //            return a.CompareTo(b) > 0 ? a : b;
            //        }

            //================================================================================================
            //================================================================================================

            //Q6:  What is a generic interface? Write IRepository<T>. 
            //public interface IRepository<T>
            //      {
            //          void Add(T item);
            //          T Get(int id);
            //          void Remove(int id);
            //      }

            //================================================================================================
            //================================================================================================

            //Q7: What is the 'struct' constraint? Write an example.

            //Only value types allowed.

            //public class MyStructClass<T> where T : struct
            //        {
            //            public T Value;
            //        }

            //================================================================================================
            //================================================================================================

            //Q8:  What is the 'class' constraint? Write an example.

            //Only reference types allowed.

            //public class MyClass<T> where T : class
            //        {
            //            public T Value;
            //        }

            //================================================================================================
            //================================================================================================

            //Q9: What is the 'new()' constraint? Write an example.

            //Requires parameterless constructor.

            //public class MyNewClass<T> where T : new()
            //      {
            //          public T Create()
            //          {
            //              return new T();
            //          }
            //      }

            //================================================================================================
            //================================================================================================

            //Q10:What is the interface constraint? Write an example.
            //public class MyInterfaceClass<T> where T : IDisposable
            //      {
            //          public void Use(T obj)
            //          {
            //              obj.Dispose();
            //          }
            //      }

            //================================================================================================
            //================================================================================================

            //Q11: What is the base class constraint? Write an example.
            //public class MyBaseClass<T> where T : Animal
            //     {
            //         public void Speak(T obj)
            //         {
            //             obj.MakeSound();
            //         }
            //     }

            //================================================================================================
            //================================================================================================

            //Q12: How do you apply multiple constraints? Write an example.
            //public class MyMulti<T>
            //where T : class, IDisposable, new()
            //    {
            //        public T Create()
            //        {
            //            return new T();
            //        }
            //    }

            //================================================================================================
            //================================================================================================

            //Q13: What does the 'default' keyword do in generics?

            //Returns default value of type:

            //0 for numbers
            //null for reference types

            //T value = default(T);

            //================================================================================================
            //================================================================================================

            //Q14:  Write a SafeList<T> that returns default when the index is invalid.

            //public class SafeList<T>
            //     {
            //         private List<T> list = new List<T>();

            //         public void Add(T item)
            //         {
            //             list.Add(item);
            //         }

            //         public T Get(int index)
            //         {
            //             if (index < 0 || index >= list.Count)
            //                 return default(T);

            //             return list[index];
            //         }
            //     }

            //================================================================================================
            //================================================================================================

            //Q15: What is covariance? Explain the 'out' keyword.

            //Allows returning a more derived type.

            //public interface IProducer<out T>
            //        {
            //            T Get();
            //        }

            //================================================================================================
            //================================================================================================

            //Q16:What is contravariance? Explain the 'in' keyword.

            //Allows using a less derived type as input.

            //public interface IConsumer<in T>
            //        {
            //            void Set(T item);
            //        }

            //================================================================================================
            //================================================================================================

            //Q17:  What is the difference between covariance and contravariance?
            //Covariance(out) → output(return types)
            //Contravariance(in) → input(parameters)

            //================================================================================================
            //================================================================================================

            //Q18: How do static members work in generic types?

            //Each type gets its own static data.

            //public class MyGeneric<T>
            //        {
            //            public static int Count;
            //        }

            //================================================================================================  
            //================================================================================================

            //Q19: How can you inherit from a generic class?
            //public class Base<T>
            //        {
            //            public T Value;
            //        }

            //        public class Derived : Base<int>
            //        {
            //        }

            //================================================================================================
            //================================================================================================

            //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 
            //public class Cache<TKey, TValue>
            //{
            //    private class CacheItem
            //    {
            //        public TValue Value;
            //        public DateTime Expiration;
            //    }

            //    private Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();

            //    public void Add(TKey key, TValue value, int seconds)
            //    {
            //        cache[key] = new CacheItem
            //        {
            //            Value = value,
            //            Expiration = DateTime.Now.AddSeconds(seconds)
            //        };
            //    }

            //    public TValue Get(TKey key)
            //    {
            //        if (cache.ContainsKey(key))
            //        {
            //            var item = cache[key];
            //            if (item.Expiration > DateTime.Now)
            //                return item.Value;

            //            cache.Remove(key);
            //        }
            //        return default(TValue);
            //    }

            //    public void Remove(TKey key)
            //    {
            //        cache.Remove(key);
            //    }

            //    public bool Contains(TKey key)
            //    {
            //        return cache.ContainsKey(key);
            //    }
            //}

            //================================================================================================


            #endregion

        }
    }
}
