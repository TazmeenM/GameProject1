using UnityEngine;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    public static int levelNumber = 0;

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
        if (levelPassedNumber > levelNumber)
        {
            levelNumber = levelPassedNumber;
        }
    }
}
