using UnityEngine;

public class Health : MonoBehaviour
{
    private float _minValue = 0;
    private float _maxValue = 100;

    public float _currentValue { get; private set; }

    public void TryChangeValue(float value)
    {
        _currentValue += value;

        if  (_currentValue < _minValue)
        {
            _currentValue = _minValue;
        }
        else if (_currentValue > _maxValue)
        {
            _currentValue = _maxValue;
        }
    }
}
