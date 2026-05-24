using UnityEngine;
using TMPro;

public class RequiredPartsUpdate : MonoBehaviour
{
    public TextMeshProUGUI partCounter;
    public PlayerStats playerStats;
    public GameObject requiredPartsObject;
    public LevelComplete levelComplete;

    private int totalRequiredParts;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalRequiredParts = requiredPartsObject.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        partCounter.text = "Part Collected: " + playerStats.requiredParts + "/" + totalRequiredParts;

        if (playerStats.requiredParts >= totalRequiredParts)
        {
            levelComplete.ShowLevelComplete();
        }
    }
}
