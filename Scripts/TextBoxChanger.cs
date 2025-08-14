using UnityEngine;
using TMPro;

public class TextBoxChanger : MonoBehaviour
{
    public GameObject textBox;
    private int textBoxShown = 0;
    [SerializeField] public string[] textBoxText;
    public TextMeshProUGUI textInBox;
    public ForTheAcquiredPanel forTheAcquiredPanel;
    public Background background;

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
            NextTextBox();
        }
        else if (textInBox.text.Substring(0, "Scene".Length).Equals("Scene"))
        {
            background.ChangeBackground(textInBox.text.Substring("Scene".Length));
            NextTextBox();
        }
        else if (textInBox.text.Substring(0, character1Name.Length).Equals(character1Name) || textInBox.text.Substring(0, character2Name.Length).Equals(character2Name))
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
            //The emotions are checked in increasing length order of their names, to avoid Index Out of Bounds errors
            if (textInBox.text.Length > character1Name.Length)
            {
                if (textInBox.text.Equals(character1Name + "Sad"))
                {
                    character1.SadCharacter();
                }
                else if (textInBox.text.Equals(character1Name + "Normal"))
                {
                    character1.NormalCharacter();
                }
                else
                {
                    Debug.Log(textInBox.text.Substring(character1Name.Length));
                }
            }
        }

        else if (textInBox.text.Substring(0, character2Name.Length).Equals(character2Name))
        {
            character2.SetImageVisible();
            character1.SetImageInvisible();
            Debug.Log("Character 2 Shown ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //The emotions are checked in increasing length order of their names, to avoid Index Out of Bounds errors
            if (textInBox.text.Length > character2Name.Length)
            {
                Debug.Log("Emotion Detected!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                if (textInBox.text.Equals(character2Name + "Sad"))
                {
                    Debug.Log("Sad Character :(((((((((((((((((((((((((())))))))))))))))))))))))))");
                    character2.SadCharacter();
                }
                else if (textInBox.text.Equals(character2Name + "Normal"))
                {
                    Debug.Log("Normal Character ____________________________________________________");
                    character2.NormalCharacter();
                }
                else
                {
                    Debug.Log(textInBox.text.Substring(character2Name.Length));
                }
            }
            else
            {
                Debug.Log(textInBox.text);
            }
        }
        else
        {
            Debug.Log(textInBox.text);
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
