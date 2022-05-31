using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class LifeIndicator : MonoBehaviour
    {
        [SerializeField] private Image _active;

        public void SetActive(bool value)
        {
            _active.enabled = value;
        }
    }
}
