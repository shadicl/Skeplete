using UnityEngine;
using UnityEngine.UI;

public class SprintBar : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public Image sprintBar;

    // Update is called once per frame
    void Update()
    {
        sprintBar.fillAmount = playerMovement.staminaAmount / 1;
    }
}
