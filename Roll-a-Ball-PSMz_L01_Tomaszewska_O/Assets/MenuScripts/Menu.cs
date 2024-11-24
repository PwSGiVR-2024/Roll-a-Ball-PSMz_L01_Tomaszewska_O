using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void ShowSettings()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
