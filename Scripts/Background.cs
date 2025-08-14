using UnityEngine;

public class Background : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    //For the character emotions
    public Sprite forest;
    public Sprite darkForest;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Forest()
    {
        spriteRenderer.sprite = forest;
    }

    public void DarkForest()
    {
        spriteRenderer.sprite = darkForest;
    }

}
