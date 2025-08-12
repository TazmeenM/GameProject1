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
        if (textBoxChanger == null) Debug.LogError("textBoxChanger is null!");
        if (forTheAcquiredPanel == null) Debug.LogError("forTheAcquiredPanel is null!");
        if (forTheLevelPassedPanel == null) Debug.LogError("forTheLevelPassedPanel is null!");
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
            forTheLevelPassedPanel.OpenLevelPassedPanel(levelNumber);
            //SceneManager.LoadSceneAsync(scene);
        }
    }
}
