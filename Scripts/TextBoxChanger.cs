using UnityEngine;
using TMPro;

public class TextBoxChanger : MonoBehaviour
{
    public GameObject textBox;
    private int textBoxShown = 0;
    [SerializeField] public string[] textBoxText;
    public TextMeshProUGUI textInBox;
    public ForTheAcquiredPanel forTheAcquiredPanel;

    //For the images of the characters talking
    Renderer imageRenderer;
    [SerializeField] DialogueCharacter character1;
    string character1Name;
    [SerializeField] DialogueCharacter character2;
    string character2Name;

    public void Start()
    {
        character1Name = character1.characterName;
        character2Name = character2.characterName;
        textBox.SetActive(true);
        textInBox.text = textBoxText[0];
        character1.SetImageInvisible();
        character2.SetImageInvisible();
        CharacterTalkingImage();
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
        if (textInBox.text.Equals(character1Name) || textInBox.text.Equals(character2Name))
        {
            CharacterTalkingImage();
        }
    }

    public bool IsLastTextBox()
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

    public void CharacterTalkingImage()
    {
        if (textInBox.text.Substring(0, character1Name.Length).Equals(character1Name))
        {
            character1.SetImageVisible();
            character2.SetImageInvisible();
            Debug.Log("Character 1 Shown ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        else if (textInBox.text.Substring(0, character2Name.Length).Equals(character2Name))
        {
            character2.SetImageVisible();
            character1.SetImageInvisible();
            Debug.Log("Character 2 Shown ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
        NextTextBox();
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
