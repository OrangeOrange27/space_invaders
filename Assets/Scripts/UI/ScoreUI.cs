using TMPro;
using UnityEngine;

namespace UI
{
    public class ScoreUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public void UpdateScore(int value)
        {
            _text.text = value.ToString();
        }
    }
}
