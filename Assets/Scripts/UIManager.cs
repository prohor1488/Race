using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
        public void StartButton()
        {
            SceneManager.LoadScene("Game");
        }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Menu");
    }
        public void ExitGame()
    {
        Application.Quit();

    }
}
