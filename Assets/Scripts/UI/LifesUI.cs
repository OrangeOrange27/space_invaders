using UnityEngine;

namespace UI
{
    public class LifesUI : MonoBehaviour
    {
        [SerializeField] private LifeIndicator[] _lifeIndicators = new LifeIndicator[3];

        private int _currentLife;

        private void Awake()
        {
            _currentLife = _lifeIndicators.Length - 1;
        }

        public void LoseLife()
        {
            if(_currentLife<=0) return;

            _lifeIndicators[_currentLife].SetActive(false);
            _currentLife--;
        }

        public void GainAllLifes()
        {
            foreach (var lifeIndicator in _lifeIndicators)
            {
                lifeIndicator.SetActive(true);
            }

            _currentLife = _lifeIndicators.Length - 1;
        }
    }
}
