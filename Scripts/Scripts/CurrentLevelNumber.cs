using UnityEngine;

public class CurrentLevelNumber : MonoBehaviour
{
    public static int currentLevelNumber = 1;

    public void LevelPassed(int levelNumber)
    {
        if (levelNumber > currentLevelNumber)
        {
            currentLevelNumber = levelNumber;
        }
    }

    public int GetCurrentLevelNumber()
    {
        return currentLevelNumber;
    }
}
