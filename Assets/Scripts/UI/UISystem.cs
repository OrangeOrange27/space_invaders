using UnityEngine;

namespace UI
{
    public class UISystem : MonoBehaviour
    {
        [SerializeField] private LifesUI _life;
        [SerializeField] private ScoreUI _score;
        
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _winPopup;
        [SerializeField] private GameObject _losePopup;
        

        public void UpdateScore(int value)
            => _score.UpdateScore(value);

        #region Health

        public void UpdateLife()
            => _life.GainAllLifes();

        public void LoseLife()
            => _life.LoseLife();

        #endregion

        #region Popups

        public void ShowMainMenu()
            => _mainMenu.SetActive(true);
        public void HideMainMenu()
            => _mainMenu.SetActive(false);
        
        public void ShowWinPopUp()
            => _winPopup.SetActive(true);
        public void HideWinPopUp()
            => _winPopup.SetActive(false);
        
        public void ShowLosePopUp()
            => _losePopup.SetActive(true);
        public void HideLosePopUp()
            => _losePopup.SetActive(false);

        #endregion
    }
}
