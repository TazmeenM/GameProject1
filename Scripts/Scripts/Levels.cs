using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    [SerializeField] public LevelButtons levelButtonsArray;
    public static Button[] levelButtons;
    public static int currentLevelNumber = 1;
    private static Levels instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
            for (int i = 0; i < currentLevelNumber; i++)
            {
                levelButtons[i].interactable = true;
            }
        }
        else
        {
            Destroy(gameObject);
        }
        
        
    }
    public void Start()
    {
        levelButtons = levelButtonsArray.levelButtons;
        Debug.Log(levelButtons);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
        }
        levelButtons[0].interactable = true;
    }

    

    public static void LevelPassed(int levelNumber)
    {
        Debug.Log(levelButtons);

        if (levelNumber > currentLevelNumber)
        {
            currentLevelNumber = levelNumber + 1;
        }
        
        for (int i = 0; i <= currentLevelNumber; i++)
        {
            levelButtons[i].interactable = true;
        }
    }

    public int GetCurrentLevelNumber()
    {
        return currentLevelNumber;
    }
}
