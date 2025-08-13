using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Button : MonoBehaviour
{
    public string scene = "MainMenu";
    public LevelCounter levelCounter;
    [SerializeField] int thisLevelNumber;
    [SerializeField]private Button levelButton;
    public void Awake()
    {
        levelButton = GetComponent<Button>();
        if (LevelCounter.levelNumber >= thisLevelNumber)
        {
            levelButton.interactable = true;
        }
        else
        {
            Debug.Log("This button is not interactable");
            levelButton.interactable = false;
        }
    }
    public void OnMouseDown()
    {
        if (levelButton.interactable)
        {
            Debug.Log("Clicked");
            SceneManager.LoadSceneAsync(scene);
        }
    }

    public void OnMouseEnter()
    {
        if (levelButton.interactable)
        {
            Debug.Log("Hovered");
        }
    }

}
