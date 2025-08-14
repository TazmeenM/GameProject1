using UnityEngine;

public class DialogueCharacter : MonoBehaviour
{
    [SerializeField] public string characterName;
    private Renderer imageRenderer;
    private SpriteRenderer spriteRenderer;

    //For the character emotions
    public Sprite normalCharacter;
    public Sprite sadCharacter;

    void Awake()
    {
        imageRenderer = GetComponent<Renderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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

    public void NormalCharacter()
    {
        spriteRenderer.sprite = normalCharacter;
    }

    public void SadCharacter()
    {
        spriteRenderer.sprite = sadCharacter;
    }

}
