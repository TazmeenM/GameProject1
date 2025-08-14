using UnityEngine;
using UnityEngine.UI;

public class ForTheAcquiredPanel : MonoBehaviour
{
    [SerializeField] public BerriesAcquiredPanel berriesAcquiredPanel;
    [SerializeField] public NextTextBoxButton nextTextBoxButton;
    public void Start()
    {
        berriesAcquiredPanel.gameObject.SetActive(false);
        berriesAcquiredPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenBerriesAcquiredPanel()
    {
        nextTextBoxButton.DisableButton();
        berriesAcquiredPanel.gameObject.SetActive(true);
        BerryCounter.AddBerries(5);

    }

    private void OKButtonClicked()
    {
        berriesAcquiredPanel.gameObject.SetActive(false);
        nextTextBoxButton.EnableButton();
    }
}
