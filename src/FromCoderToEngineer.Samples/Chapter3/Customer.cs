﻿namespace FromCoderToEngineer.Samples.Chapter3
{
    using Common;

    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            Assert.IsNotNull(name);
            Assert.IsAlphaOnly(name);

            Name = name;
        }
    }
}
