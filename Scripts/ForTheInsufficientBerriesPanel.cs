using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForTheInsufficientBerriesPanel : MonoBehaviour
{
    [SerializeField] public InsufficientBerriesPanel insufficientBerriesPanel;
    [SerializeField] public NextTextBoxButton nextTextBoxButton;
    public void Start()
    {
        insufficientBerriesPanel.gameObject.SetActive(false);
        insufficientBerriesPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenInsufficientBerriesPanel()
    {
        insufficientBerriesPanel.gameObject.SetActive(true);

    }

    private void OKButtonClicked()
    {
        insufficientBerriesPanel.gameObject.SetActive(false);
        nextTextBoxButton.EnableButton();
        SceneManager.LoadSceneAsync("Map");
    }
}
