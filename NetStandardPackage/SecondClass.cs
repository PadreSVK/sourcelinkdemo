namespace NetStandardPackage
{
    public class SecondClass
    {
        private readonly int _readonlyAge;

        public SecondClass(int readonlyAge)
        {
            _readonlyAge = readonlyAge;
        }

        public string TestName { get; set; }
    }
}