using UnityEngine;
using UnityEngine.SceneManagement;

public class ForTheFeedRabbitPanel : MonoBehaviour
{
    [SerializeField] public FeedRabbitPanel feedRabbitPanel;
    private static bool rabbitFed = false;
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
        if (!rabbitFed)
        {
            feedRabbitPanel.rabbitFeedTextBox.text = "Would you like to feed the rabbit?";
            Debug.Log("Rabbit has not been fed yet");
            feedRabbitPanel.gameObject.SetActive(true);
            BerryCounter.numberOfBerries -= 5;
            rabbitFed = true;
        }
        else
        {
            feedRabbitPanel.rabbitFeedTextBox.text = "You already fed the rabbit!";
            Debug.Log("You already fed the rabbit!");
            feedRabbitPanel.gameObject.SetActive(true);
        }


    }

    private void OKButtonClicked()
    {
        feedRabbitPanel.gameObject.SetActive(false);
        rabbitFed = true;
        Debug.Log("Rabbit was fed!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        SceneManager.LoadSceneAsync("Level1.1");
    }
}
