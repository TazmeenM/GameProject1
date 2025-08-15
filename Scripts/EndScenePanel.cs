using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScenePanel : MonoBehaviour
{
    //From other GameObjects
    [SerializeField] public NextTextBoxButtonGameOver nextTextBoxButton;
    [SerializeField] private GameObject endScenePanel;

    //For the buttons
    [SerializeField] private Button okButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endScenePanel.gameObject.SetActive(false);
        okButton.onClick.AddListener(OKButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenEndScenePanel()
    {
        endScenePanel.gameObject.SetActive(true);

    }

    public void OKButtonClicked()
    {
        SceneManager.LoadSceneAsync("Map");

    }
    

}
