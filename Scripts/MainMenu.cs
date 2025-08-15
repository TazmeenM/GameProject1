using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("StartingScene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadSceneAsync("HowToPlay");
    }
}
