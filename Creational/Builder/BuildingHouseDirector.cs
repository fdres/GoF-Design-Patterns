namespace Builder
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class BuildingHouseDirector
    {
        private IHouseBuilder _builder;

        public IHouseBuilder Builder
        {
            set => _builder = value;
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildSimpleHouse()
        {
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.InstallDoor();
            _builder.InstallWindows();
        }

        public void BuildFullHouse()
        {
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.InstallDoor();
            _builder.InstallWindows();
            _builder.BuildGarage();
            _builder.InstallSwimmingPool();
        }
    }
}
