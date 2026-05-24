using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompleteText;

    public void ShowLevelComplete()
    {
        levelCompleteText.SetActive(true);
    }
}
