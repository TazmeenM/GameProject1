using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public static int levelNumber = 0;
    [SerializeField] public Level1Button[] levelButtons;
    private static int[] decisionsMade;
    private static int numberOfLevels;

    void Start()
    {
    }

    void Awake()
    {
        numberOfLevels = levelButtons.Length;
        decisionsMade = new int[numberOfLevels];
        for (int i = 0; i < decisionsMade.Length; i++)
        {
            decisionsMade[i] = 0;
        }
        DontDestroyOnLoad(gameObject);
    }

    public static void LevelPassed(int levelPassedNumber)
    {
        Debug.Log(levelPassedNumber + "Level Passed");
        if (levelPassedNumber >= levelNumber)
        {
            levelNumber = levelPassedNumber + 1;
            Debug.Log(levelNumber + "Current Level Current Level Current Level Current Level Current Level Current Level Current Level Current Level");
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

    public static void PathDecision(int levelNumber, int decisionNumber)
    {
        decisionsMade[levelNumber] = decisionNumber;
    }
}
