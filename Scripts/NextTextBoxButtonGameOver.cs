using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextBoxButtonGameOver : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public string scene = "MainMenu";
    [SerializeField] public Button nextTextBoxButton;
    [SerializeField] public GameOverPanel gameOverPanel;

    public void OnClick()
    {
        Debug.Log("Next Button Clicked");
        if (!textBoxChanger.IsLastTextBox())
        {
            textBoxChanger.NextTextBox();
        }
        else
        {
            gameOverPanel.OpenGameOverPanel();
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
