using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTextBoxButtonStartingScene : MonoBehaviour
{
    public TextBoxChanger textBoxChanger;
    public string scene = "Map";

    public void OnClick()
    {
        if (!textBoxChanger.isLastTextBox())
        {
            textBoxChanger.NextTextBox();
        }
        else
        {
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
