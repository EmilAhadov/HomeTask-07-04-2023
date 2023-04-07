namespace OOP2
{
    //Task4
    interface ICalculate_For_Transporst
    {

        void Speed();
        void FuelConsumption();
        void Travel();
    }
    class Car : ICalculate_For_Transporst
    {
        public void FuelConsumption()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }

        public void Travel()
        {
            throw new System.NotImplementedException();
        }
    }
    class MotorCycle : ICalculate_For_Transporst
    {
        public void FuelConsumption()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }

        public void Travel()
        {
            throw new System.NotImplementedException();
        }
    }
    class Bike : ICalculate_For_Transporst
    {
        public void FuelConsumption()
        {
            throw new System.NotImplementedException();
        }

        public void Speed()
        {
            throw new System.NotImplementedException();
        }

        public void Travel()
        {
            throw new System.NotImplementedException();
        }
    }
}
