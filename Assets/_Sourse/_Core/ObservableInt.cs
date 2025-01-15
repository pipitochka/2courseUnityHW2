using Unity.VisualScripting;

namespace _Core
{
    public class ObservableInt
    {
        private int _value;
        
        private System.Action<int> onValueChanged;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                onValueChanged?.Invoke(_value);
            }
        }

        public ObservableInt(int value)
        {
            _value = value;
        }
    }
}