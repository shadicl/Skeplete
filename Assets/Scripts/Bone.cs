using UnityEngine;

public class Bone : MonoBehaviour
{

    public PlayerStats playerStats;
    public PlayerMovement playerMovement;
    public AudioSource sfx;

    void OnCollisionEnter2D(Collision2D collision)
    {
        playerStats.bones += 1;

        if (playerMovement.staminaAmount < playerMovement.maxStamina)
        {
            playerMovement.staminaAmount += 0.1f;

            if (playerMovement.staminaAmount > playerMovement.maxStamina)
            {
                playerMovement.staminaAmount = playerMovement.maxStamina;
            }
        }

        sfx.Play();
        Destroy(gameObject);
    }
}
