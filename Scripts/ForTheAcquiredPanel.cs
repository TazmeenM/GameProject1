using UnityEngine;

public class ForTheAcquiredPanel : MonoBehaviour
{
    [SerializeField] public BerriesAcquiredPanel berriesAcquiredPanel;
    public void Start()
    {
        berriesAcquiredPanel.gameObject.SetActive(false);
        berriesAcquiredPanel.okButton.onClick.AddListener(OKButtonClicked);
    }

    public void OpenBerriesAcquiredPanel()
    {
        berriesAcquiredPanel.gameObject.SetActive(true);
        BerryCounter.numberOfBerries += 5;

    }
 
    private void OKButtonClicked()
    {
        berriesAcquiredPanel.gameObject.SetActive(false);
    }
}
