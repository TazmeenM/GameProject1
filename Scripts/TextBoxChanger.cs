using UnityEngine;
using TMPro;

public class TextBoxChanger : MonoBehaviour
{
    public GameObject[] textBoxes;
    private int textBoxShown = 0;
    public void Start(){
        for (int i = 0; i < textBoxes.Length; i++){
            textBoxes[i].SetActive(false);
        }

        if (textBoxes.Length > 0){
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
}
