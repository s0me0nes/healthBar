using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private float _valueChangeSpeed = 5;

    private Slider _healthBar;
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _healthBar = GetComponent<Slider>();
    }

    private void Update()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, _health._currentValue, _valueChangeSpeed * Time.deltaTime);
    }
}
