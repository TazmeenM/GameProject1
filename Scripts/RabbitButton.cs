using UnityEngine;

public class RabbitButton : MonoBehaviour
{
    [SerializeField] public ForTheFeedRabbitPanel forTheFeedRabbitPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Debug.Log("Rabbit Clicked");
        forTheFeedRabbitPanel.OpenFeedRabbitPanel();
    }
}
