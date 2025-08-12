using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTextBoxButton : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public ForTheAcquiredPanel forTheAcquiredPanel;
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
            Levels.LevelPassed(levelNumber);
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
