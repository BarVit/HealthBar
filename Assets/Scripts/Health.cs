using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    [field : SerializeField] public int HealthAmount { get; private set; }
    [field : SerializeField] public int MaxHealth { get; private set; }

    public event Action<float> Changed;

    private void Awake()
    {
        HealthAmount = 100;
        MaxHealth = 100;
    }

    public void TakeDamage()
    {
        int damage = 10;

        if (damage >= 0)
            HealthAmount = Mathf.Clamp(HealthAmount - damage, 0, HealthAmount);

        Changed?.Invoke(HealthAmount);
    }

    public void Heal()
    {
        int healing = 10;

        if (HealthAmount < MaxHealth)
            HealthAmount = Mathf.Clamp(HealthAmount + healing, HealthAmount, MaxHealth);

        Changed?.Invoke(HealthAmount);
    }
}