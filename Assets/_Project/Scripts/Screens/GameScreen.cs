using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace _Project.Screens
{
    public class GameScreen : BaseScreen
    {



        public void GoBack()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
