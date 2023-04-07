namespace OOP2
{
    //Task3
    interface IAdministration
    {
        void Salary();
        void Holidays();
    }
    class Designer : IAdministration
    {
        public void Holidays()
        {
            throw new System.NotImplementedException();
        }

        public void Salary()
        {
            throw new System.NotImplementedException();
        }
    }
    class Developer : IAdministration
    {
        public void Holidays()
        {
            throw new System.NotImplementedException();
        }

        public void Salary()
        {
            throw new System.NotImplementedException();
        }
    }
    class Menager : IAdministration
    {
        public void Holidays()
        {
            throw new System.NotImplementedException();
        }

        public void Salary()
        {
            throw new System.NotImplementedException();
        }
    }
}
