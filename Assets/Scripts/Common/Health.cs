using System;
using UnityEngine;

namespace Common
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private float _initHealth = 100;
        
        private float _currentHealth;
        
        public event Action<float> OnAddHealth;
        public event Action OnZeroHealth;
        public float GetCurrentHealth() => _currentHealth;

        public void SetHealth(float value)
        {
            _currentHealth = value;
            ZeroHealthCheck();
        }

        public void AddHealth(float value)
        {
            _currentHealth += value;
            
            if (_currentHealth > _maxHealth)
                _currentHealth = _maxHealth;
            
            OnAddHealth?.Invoke(value);
            ZeroHealthCheck();
        }

        private void Start()
        {
            SetHealth(_initHealth);
        }

        private void ZeroHealthCheck()
        {
            if (!(_currentHealth <= 0)) return;
            
            _currentHealth = 0;
            OnZeroHealth?.Invoke();
        }
    }
}