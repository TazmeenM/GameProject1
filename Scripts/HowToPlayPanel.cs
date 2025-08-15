using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HowToPlayPanel : MonoBehaviour
{
    //From other GameObjects
    [SerializeField] private GameObject howToPlayPanel;

    //For the buttons
    [SerializeField] private Button mainMenuButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        howToPlayPanel.gameObject.SetActive(true);
        mainMenuButton.onClick.AddListener(MainMenuButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenuButtonClicked()
    {
        SceneManager.LoadSceneAsync("MainMenu");

    }
    

}
