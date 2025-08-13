using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public static int levelNumber = 0;
    [SerializeField] public Level1Button[] levelButtons;

    void Start()
    {
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void LevelPassed(int levelPassedNumber)
    {
        Debug.Log("Level Passed");
        if (levelPassedNumber >= levelNumber)
        {
            levelNumber = levelPassedNumber + 1;
        }
    }

    public void LevelButtonOnClick(Level1Button clickedButton)
    {
        Debug.Log(clickedButton.thisLevelNumber);
        Debug.Log(levelNumber + "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        if (levelNumber >= clickedButton.thisLevelNumber)
        {
            SceneManager.LoadSceneAsync(clickedButton.scene);
        }
        {
            
        }
    }
}
