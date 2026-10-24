using UnityEngine;
using TMPro;

public class RequiredPartsUpdate : MonoBehaviour
{
    public TextMeshProUGUI partCounter;
    private PlayerStats playerStats;
    public GameObject requiredPartsObject;

    private int totalRequiredParts;
    void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>();
        totalRequiredParts = requiredPartsObject.transform.childCount;
        partCounter.text = $"Parts Collected: {playerStats.requiredParts}/{totalRequiredParts}";
    }

    public void UpdateCounter()
    {
        partCounter.text = $"Parts Collected: {playerStats.requiredParts}/{totalRequiredParts}";
    }
}
