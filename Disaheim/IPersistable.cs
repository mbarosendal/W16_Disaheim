namespace Disaheim
{
    internal interface IPersistable
    {
        // Methods in interfaces are implicitly public and abstract.
        void Save();
        // Added Optional Parameter by specifying default values for fileName.
        void Save(string fileName = "ValuableRepository.txt");
        void Load();
        // Added Optional Parameter by specifying default values for fileName.
        void Load(string fileName = "ValuableRepository.txt");
    }
}
