using UnityEngine;
using System.Collections.Generic;

public class DialogueCharacter : MonoBehaviour
{
    [SerializeField] public string characterName;
    private Renderer imageRenderer;
    private SpriteRenderer spriteRenderer;
    private Dictionary<string, Sprite> emotions;

    //For the character emotions
    public Sprite normalCharacter;
    public Sprite sadCharacter;
    public Sprite evilCharacter;

    void Awake()
    {
        imageRenderer = GetComponent<Renderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        emotions = new Dictionary<string, Sprite>
        {
            {"Normal", normalCharacter},
            {"Sad", sadCharacter},
            {"Evil", evilCharacter}
        };
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

    public void ChangeEmotion(string emotionName)
    {
        if (emotions.ContainsKey(emotionName))
        {
            spriteRenderer.sprite = emotions[emotionName];
        }
    }

    /*
    public void NormalCharacter()
    {
        spriteRenderer.sprite = normalCharacter;
    }

    public void SadCharacter()
    {
        spriteRenderer.sprite = sadCharacter;
    }
    */

}
