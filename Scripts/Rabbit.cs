using UnityEngine;
using UnityEngine.EventSystems;

public class Rabbit : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
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

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Rabbit Clicked");
        forTheFeedRabbitPanel.OpenFeedRabbitPanel();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    
    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
