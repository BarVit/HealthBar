using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Health _health;

    private void Start()
    {
        _healthBar.value = _health.HealthAmount;
    }

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    public void OnHealthChanged(float health)
    {
        _healthBar.value = health;
    }
}