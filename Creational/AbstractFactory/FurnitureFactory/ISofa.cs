﻿namespace AbstractFactory.FurnitureFactory
{
    // Here's the the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    public interface ISofa
    {
        // Product B is able to do its own thing...
        string SittingOnSofa();
    }
}
