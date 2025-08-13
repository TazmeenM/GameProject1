using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTextBoxButton : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public ForTheAcquiredPanel forTheAcquiredPanel;
    public ForTheLevelPassedPanel forTheLevelPassedPanel;
    public string scene = "MainMenu";
    [SerializeField] int levelNumber;
    //[SerializeField] Levels levels;

    public void OnClick()
    {
        Debug.Log("Next Button Clicked");
        if (!textBoxChanger.isLastTextBox())
        {
            if (textBoxChanger.textInBox.text == "Berries Acquired!")
            {
                forTheAcquiredPanel.OpenBerriesAcquiredPanel();
            }
            else
            {
                textBoxChanger.NextTextBox();
            }
        }
        else
        {
            //Levels.LevelPassed(levelNumber);
            if (scene == "Map")
            {
                forTheLevelPassedPanel.OpenLevelPassedPanel(levelNumber);
            }
            else
            {
                Debug.Log("Other Scene");
                SceneManager.LoadSceneAsync(scene);
            }
            //SceneManager.LoadSceneAsync(scene);
        }
    }
}
