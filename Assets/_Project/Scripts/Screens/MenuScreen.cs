using _Project.Services;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Screens
{
    public class MenuScreen : BaseScreen
    {
        [SerializeField] private GameObject _game;
        [SerializeField] private Button _play;
        [SerializeField] private Button _quit;

        private void OnEnable()
        {
            _play.onClick.AddListener(() =>
            {
                ButtonOnClicked(_play, Play);
            });

            _quit.onClick.AddListener(() =>
            {
                ButtonOnClicked(_quit, Quit);
            });
        }

        private void OnDisable()
        {
            _play.onClick?.RemoveAllListeners();
            _quit.onClick?.RemoveAllListeners(); 
        }

        public void Play()
        {
            _game.SetActive(true);
            ScreenStateMachine.Instance.SetScreen(State.Game);
        }

        public void Quit()
        {
            Application.Quit();
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#endif
        }
    }
}
