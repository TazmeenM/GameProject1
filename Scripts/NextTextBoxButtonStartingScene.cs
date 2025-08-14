using UnityEngine;
using UnityEngine.SceneManagement;

public class NextTextBoxButtonStartingScene : MonoBehaviour
{
    public TextBoxChangerStartingScene textBoxChanger;
    public string scene = "Map";

    public void OnClick()
    {
        if (!textBoxChanger.IsLastTextBox())
        {
            textBoxChanger.NextTextBox();
        }
        else
        {
            SceneManager.LoadSceneAsync(scene);
        }
    }
}
