using UnityEngine;
using UnityEngine.SceneManagement;

public class ForTheInsufficientBerriesPanel : MonoBehaviour
{
    [SerializeField] public InsufficientBerriesPanel insufficientBerriesPanel;
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
        SceneManager.LoadSceneAsync("Map");
    }
}
