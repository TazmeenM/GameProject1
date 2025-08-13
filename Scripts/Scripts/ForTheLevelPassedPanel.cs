using UnityEngine;
using UnityEngine.SceneManagement;

public class ForTheLevelPassedPanel : MonoBehaviour
{
    [SerializeField] public LevelPassedPanel levelPassedPanel;
    public int currentLevelNumber;
    //[SerializeField] public LevelCounter levelCounter;
    public void Start()
    {
        levelPassedPanel.gameObject.SetActive(false);
        levelPassedPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenLevelPassedPanel(int levelNumber)
    {
        levelPassedPanel.gameObject.SetActive(true);
        currentLevelNumber = levelNumber;
        LevelCounter.LevelPassed(levelNumber);

    }

    private void OKButtonClicked()
    {
        LevelCounter.LevelPassed(currentLevelNumber);
        levelPassedPanel.gameObject.SetActive(false);
        SceneManager.LoadSceneAsync("Map");
    }
}
