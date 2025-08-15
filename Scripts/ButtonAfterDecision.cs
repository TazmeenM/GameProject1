using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAfterDecision : MonoBehaviour
{
    [SerializeField] int levelNumber;
    [SerializeField] string scene;


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
        scene += ("-" + LevelCounter.decisionsMade[levelNumber]);
        SceneManager.LoadSceneAsync(scene);
    }
}
