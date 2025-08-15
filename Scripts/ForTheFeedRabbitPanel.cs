using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForTheFeedRabbitPanel : MonoBehaviour
{
    [SerializeField] public FeedRabbitPanel feedRabbitPanel;
    [SerializeField] public ForTheInsufficientBerriesPanel forTheInsufficientBerriesPanel;
    private static bool rabbitFed = false;
    [SerializeField] public NextTextBoxButton nextTextBoxButton;
    public void Start()
    {
        feedRabbitPanel.gameObject.SetActive(false);
        feedRabbitPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OpenFeedRabbitPanel()
    {
        nextTextBoxButton.DisableButton();
        if (BerryCounter.numberOfBerries >= 5)
        {
            if (!rabbitFed)
            {
                feedRabbitPanel.rabbitFeedTextBox.text = "Would you like to feed the rabbit?";
                Debug.Log("Rabbit has not been fed yet");
                feedRabbitPanel.gameObject.SetActive(true);
                BerryCounter.RemoveBerries(5);
                rabbitFed = true;
            }
            else
            {
                feedRabbitPanel.rabbitFeedTextBox.text = "You already fed the rabbit!";
                Debug.Log("You already fed the rabbit!");
                feedRabbitPanel.gameObject.SetActive(true);
            }
        }

        else
        {
            forTheInsufficientBerriesPanel.OpenInsufficientBerriesPanel();
        }



    }

    private void OKButtonClicked()
    {
        feedRabbitPanel.gameObject.SetActive(false);
        rabbitFed = true;
        Debug.Log("Rabbit was fed!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        nextTextBoxButton.EnableButton();
        SceneManager.LoadSceneAsync("Level1.1");
    }

    public static void Reset()
    {
        rabbitFed = false;
    }
}
