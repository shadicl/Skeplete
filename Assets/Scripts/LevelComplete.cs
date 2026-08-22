using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompleteText;
    public GameObject bones;
    public BodyManager bodyManager;

    public void ShowLevelComplete()
    {
        levelCompleteText.SetActive(true);
    }

    void Update()
    {
        // Check if player has all bones and required parts
            // Show level complete screen

        if (bones.transform.childCount <= 0)
        {
            if (!bodyManager.hasTorso || !bodyManager.hasArm1 || !bodyManager.hasArm2 || !bodyManager.hasLeg1 || !bodyManager.hasLeg2)
            {
                return;
            }

            ShowLevelComplete();
        }
    }
}
