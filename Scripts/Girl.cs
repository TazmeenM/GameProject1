using UnityEngine;

public class Girl : MonoBehaviour
{
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
