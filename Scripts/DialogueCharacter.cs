using UnityEngine;

public class DialogueCharacter : MonoBehaviour
{
    [SerializeField] public string characterName;
    private Renderer imageRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        imageRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetImageVisible()
    {
        imageRenderer.enabled = true;
    }

    public void SetImageInvisible()
    {
        imageRenderer.enabled = false;
    }
}
