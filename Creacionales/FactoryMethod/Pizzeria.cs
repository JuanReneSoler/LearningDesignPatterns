using System;

namespace patrones.FactoryMethod
{
    public abstract class Pizzeria
    {
        protected string _origen;
        public Pizza CreatePizza<T>()
            where T : Pizza => (T)Activator.CreateInstance(typeof(T), _origen);
    }
}
