using UnityEngine;
using System.Collections.Generic;

public class Background : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    //For the character emotions
    public Sprite forest;
    public Sprite darkForest;
    private Dictionary<string, Sprite> backgrounds;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        backgrounds = new Dictionary<string, Sprite>
        {
            {"Forest", forest},
            {"DarkForest", darkForest}
        };
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBackground(string backgroundName)
    {
        Debug.Log("Background Changer Called!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        if (backgrounds.ContainsKey(backgroundName))
        {
            spriteRenderer.sprite = backgrounds[backgroundName];
            Debug.Log("Background Changed!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }

    /*
    public void Forest()
    {
        spriteRenderer.sprite = forest;
    }

    public void DarkForest()
    {
        spriteRenderer.sprite = darkForest;
    }
    */

}
