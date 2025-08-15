using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextTextBoxButtonEndScene : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public string scene = "Map";
    [SerializeField] public Button nextTextBoxButton;
    [SerializeField] public EndScenePanel endScenePanel;

    public void OnClick()
    {
        Debug.Log("Next Button Clicked");
        if (!textBoxChanger.IsLastTextBox())
        {
            textBoxChanger.NextTextBox();
        }
        else
        {
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