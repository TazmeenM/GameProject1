using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelCounter : MonoBehaviour
{
    public static int levelNumber = 0;
    [SerializeField] public Level1Button[] levelButtons;
    public static int[] decisionsMade;
    private static int numberOfLevels;
    private string scene;

    void Start()
    {
    }

    void Awake()
    {
        if (levelButtons.Length > numberOfLevels)
        {
            numberOfLevels = levelButtons.Length;
        }
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
        string scene = clickedButton.scene;
        Debug.Log(clickedButton.thisLevelNumber);
        Debug.Log(levelNumber + "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        if (levelNumber >= clickedButton.thisLevelNumber)
        {
            if (clickedButton.stemmedFromDecision)
            {
                scene += ("-" + LevelCounter.decisionsMade[levelNumber]);
                Debug.Log(scene + "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
            }

            SceneManager.LoadSceneAsync(scene);
        }
        {

        }
    }

    public static void PathDecision(int decisionLevelNumber, int decisionNumber)
    {
        Debug.Log(numberOfLevels + " " + decisionNumber);
        decisionsMade[decisionLevelNumber] = decisionNumber;
    }

    public static void Reset()
    {
        levelNumber = 0;
        for (int i = 0; i < decisionsMade.Length; i++)
        {
            decisionsMade[i] = 0;
        }
    }
}
