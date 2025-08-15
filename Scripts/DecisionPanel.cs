using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DecisionPanel : MonoBehaviour
{
    //From other GameObjects
    [SerializeField] public NextTextBoxButton nextTextBoxButton;
    [SerializeField] private GameObject decisionPanel;

    //For the scenario explanation
    [SerializeField] private TextMeshProUGUI decisionText;

    //For the buttons
    [SerializeField] private Button option1;
    [SerializeField] private Button option2;
    [SerializeField] private TextMeshProUGUI option1Text;
    [SerializeField] private TextMeshProUGUI option2Text;
    [SerializeField] private int nextLevelNumber;
    [SerializeField] private string scene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        decisionPanel.gameObject.SetActive(false);
        option1.onClick.AddListener(Option1Clicked);
        option2.onClick.AddListener(Option2Clicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDecisionPanel()
    {
        nextTextBoxButton.DisableButton();
        decisionPanel.gameObject.SetActive(true);
    }

    public void Option1Clicked()
    {
        LevelCounter.PathDecision(nextLevelNumber, 0);
        Debug.Log("Option 1");
        decisionPanel.gameObject.SetActive(false);
        nextTextBoxButton.EnableButton();
        scene += "-0";
        SceneManager.LoadSceneAsync(scene);

    }

    public void Option2Clicked()
    {
        LevelCounter.PathDecision(nextLevelNumber, 1);
        Debug.Log("Option 2");
        decisionPanel.gameObject.SetActive(false);
        nextTextBoxButton.EnableButton();
        scene += "-1";
        SceneManager.LoadSceneAsync(scene);
    }
    

}
