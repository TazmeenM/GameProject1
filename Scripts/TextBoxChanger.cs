using UnityEngine;
using TMPro;

public class TextBoxChanger : MonoBehaviour
{
    public GameObject textBox;
    private int textBoxShown = 0;
    [SerializeField] public string[] textBoxText;
    public TextMeshProUGUI textInBox;
    public ForTheAcquiredPanel forTheAcquiredPanel;

    public void Start()
    {
        textBox.SetActive(true);
    }

    public void NextTextBox()
    {
        textBoxShown++;

        if (textBoxShown <= textBoxText.Length)
        {
            textInBox.text = textBoxText[textBoxShown];
        }

        if (textInBox.text == "Berries Acquired!")
        {
            forTheAcquiredPanel.OpenBerriesAcquiredPanel();
        }
    }

    public bool isLastTextBox()
    {
        if (textBoxShown - (textBoxText.Length - 1) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    


    /*Old version of this script, kept for documentation purposes
    public void Start()
    {
        for (int i = 0; i < textBoxes.Length; i++)
        {
            textBoxes[i].SetActive(false);
        }

        if (textBoxes.Length > 0)
        {
            textBoxes[0].SetActive(true);
        }
    }
    public void NextTextBox(){

        textBoxes[textBoxShown].SetActive(false);

        textBoxShown++;

        if (textBoxShown <= textBoxes.Length){
            textBoxes[textBoxShown].SetActive(true);
        }
    }

    public bool isLastTextBox(){
        if (textBoxShown - (textBoxes.Length - 1) == 0){
            return true;
        }
        else{
            return false;
        }
    }
    */
}
