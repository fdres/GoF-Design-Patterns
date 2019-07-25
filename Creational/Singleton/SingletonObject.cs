using System;

namespace Singleton
{
    public sealed class SingletonObject
    {
        private static readonly Lazy<SingletonObject> Lazy = 
            new Lazy<SingletonObject>(() => new SingletonObject());

        public static SingletonObject GetInstance() => Lazy.Value;

        private SingletonObject()
        {
        }
    }
}
