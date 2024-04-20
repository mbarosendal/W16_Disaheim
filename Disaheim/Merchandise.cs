namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        private string _itemId;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }

        public abstract double GetValue();

    }
}
