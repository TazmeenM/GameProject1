using UnityEngine;
using TMPro;

public class BerryCounter : MonoBehaviour
{
    public static int numberOfBerries = 0;
    [SerializeField] public static TMP_Text berryNumberString;

    void Start()
    {
        berryNumberString.text = numberOfBerries.ToString();
    }

    void Awake()
    {
        berryNumberString = GameObject.Find("BerryCounterText (TMP)").GetComponent<TMP_Text>();
        if (berryNumberString == null)
        {
            Debug.Log("Berry Number String is null");
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddBerries(int berriesAdded)
    {
        Debug.Log("Berries Added");
        numberOfBerries += berriesAdded;
        berryNumberString.text = numberOfBerries.ToString();
    }

    public void RemoveBerries(int berriesRemoved)
    {
        if (numberOfBerries > berriesRemoved)
        {
            numberOfBerries -= berriesRemoved;
        }
        else
        {
            numberOfBerries = 0;
        }
        berryNumberString.text = numberOfBerries.ToString();
    }
}
