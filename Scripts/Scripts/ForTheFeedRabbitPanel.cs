using UnityEngine;

public class ForTheFeedRabbitPanel : MonoBehaviour
{
    [SerializeField] public FeedRabbitPanel feedRabbitPanel;
    public void Start()
    {
        feedRabbitPanel.gameObject.SetActive(false);
        feedRabbitPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenFeedRabbitPanel()
    {
        feedRabbitPanel.gameObject.SetActive(true);
        BerryCounter.numberOfBerries -= 5;

    }
 
    private void OKButtonClicked()
    {
        feedRabbitPanel.gameObject.SetActive(false);
    }
}
