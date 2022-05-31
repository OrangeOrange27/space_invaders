using System;

namespace Common
{
    public interface IHealth
    {
        float GetCurrentHealth();
        void SetHealth(float value);
        void AddHealth(float value);

        event Action<float> OnAddHealth;
        event Action OnZeroHealth;
    }
}
