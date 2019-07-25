namespace Builder
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public HouseBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _house = new House();
        }

        // All production steps work with the same product instance.
        public void BuildWalls()
        {
            _house.Add("4 Walls");
        }

        public void BuildRoof()
        {
            _house.Add("1 Roof");
        }

        public void InstallDoor()
        {
            _house.Add("1 Door");
        }

        public void InstallWindows()
        {
            _house.Add("2 Windows");
        }

        public void BuildGarage()
        {
            _house.Add("1 Garage");
        }

        public void InstallSwimmingPool()
        {
            _house.Add("1 Swimming Pool");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public House BuildHouse()
        {
            var result = _house;

            Reset();

            return result;
        }
    }
}
