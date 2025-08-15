using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    //From other GameObjects
    [SerializeField] public NextTextBoxButtonGameOver nextTextBoxButton;
    [SerializeField] private GameObject gameOverPanel;

    //For the buttons
    [SerializeField] private Button okButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        okButton.onClick.AddListener(OKButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenGameOverPanel()
    {
        gameOverPanel.gameObject.SetActive(true);

    }

    public void OKButtonClicked()
    {
        LevelCounter.Reset();
        BerryCounter.Reset();
        ForTheFeedRabbitPanel.Reset();
        SceneManager.LoadSceneAsync("MainMenu");

    }
    

}
