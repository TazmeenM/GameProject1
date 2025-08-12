using UnityEngine;
using UnityEngine.SceneManagement;

public class ForTheLevelPassedPanel : MonoBehaviour
{
    [SerializeField] public LevelPassedPanel levelPassedPanel;
    public void Start()
    {
        levelPassedPanel.gameObject.SetActive(false);
        levelPassedPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenLevelPassedPanel(int levelNumber)
    {
        levelPassedPanel.gameObject.SetActive(true);
        LevelCounter.LevelPassed(levelNumber);

    }

    private void OKButtonClicked()
    {
        levelPassedPanel.gameObject.SetActive(false);
        SceneManager.LoadSceneAsync("Map");
    }
}
