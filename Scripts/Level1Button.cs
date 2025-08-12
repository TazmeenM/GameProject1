using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Level1Button : MonoBehaviour
{
    public string scene = "MainMenu";
    public void OnMouseDown()
    {
        Debug.Log("Clicked");
        SceneManager.LoadSceneAsync(scene);
    }

    public void OnMouseEnter()
    {
        Debug.Log("Hovered");
    }

}
