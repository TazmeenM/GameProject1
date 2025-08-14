using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextBoxButton : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public ForTheAcquiredPanel forTheAcquiredPanel;
    public ForTheLevelPassedPanel forTheLevelPassedPanel;
    public string scene = "MainMenu";
    [SerializeField] int levelNumber;
    //public static bool enabled = true;
    [SerializeField] public Button nextTextBoxButton;
    //[SerializeField] Levels levels;

    public void OnClick()
    {
        Debug.Log("Next Button Clicked");
        if (!textBoxChanger.IsLastTextBox())
        {
            if (textBoxChanger.textInBox.text == "Berries Acquired!")
            {
                forTheAcquiredPanel.OpenBerriesAcquiredPanel();
            }
            textBoxChanger.NextTextBox();
        }
        else
        {
            //Levels.LevelPassed(levelNumber);
            if (scene == "Map")
            {
                forTheLevelPassedPanel.OpenLevelPassedPanel(levelNumber);
            }
            else if (textBoxChanger.textInBox.text == "Click the rabbit to give it some berries!")
            {
                EnableButton();
            }
            else
            {
                Debug.Log("Other Scene");
                SceneManager.LoadSceneAsync(scene);
            }
            //SceneManager.LoadSceneAsync(scene);
        }
    }

    public void EnableButton()
    {
        //enabled = true;
        nextTextBoxButton.interactable = true;
    }

    public void DisableButton()
    {
        //enabled = false;
        nextTextBoxButton.interactable = false;
    }
}
