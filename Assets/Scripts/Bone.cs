using UnityEngine;
using TMPro;

public class Bone : MonoBehaviour
{

    private PlayerStats playerStats;
    private PlayerMovement playerMovement;
    [SerializeField] private AudioSource sfx;
    [SerializeField] private TextMeshProUGUI boneCounter;
    private Transform bonesParent;

    private int totalBones;

    void Start()
    {
        playerStats = FindFirstObjectByType<PlayerStats>();
        playerMovement = FindFirstObjectByType<PlayerMovement>();
        bonesParent = transform.parent;

        totalBones = bonesParent.childCount;
        boneCounter.text = $"Bones Collected: {playerStats.bones}/{totalBones}";
    }

    private void UpdateText()
    {
        boneCounter.text = $"Bones Collected: {playerStats.bones}/{totalBones}";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        playerStats.bones += 1;
        UpdateText();

        if (playerMovement.staminaAmount < playerMovement.maxStamina)
        {
            playerMovement.staminaAmount = Mathf.Clamp(
                playerMovement.staminaAmount += 0.1f,
                0f,
                playerMovement.maxStamina
            );
        }

        sfx.Play();
        Destroy(gameObject);
    }
}
