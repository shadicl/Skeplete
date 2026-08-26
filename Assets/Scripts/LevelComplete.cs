using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private GameObject levelCompleteText;
    [SerializeField] private GameObject lobbyButton;
    [SerializeField] private GameObject bones;
    [SerializeField] private BodyManager bodyManager;

    private bool isComplete = false;

    public void ShowLevelComplete()
    {
        levelCompleteText.SetActive(true);
        lobbyButton.SetActive(true);
    }

    public void OnLobbyButtonClick()
    {
        SceneManager.LoadScene("LevelSelection");
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

            if (isComplete)
            {
                return;
            }

            isComplete = true;
            ShowLevelComplete();
        }
    }
}
