using UnityEngine;

public class BodyPart : MonoBehaviour
{
    
    public AudioSource sfx;
    public BodyManager bodyManager;
    public PlayerStats playerStats;
    public RequiredPartsUpdate requiredPartsUpdate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            if (gameObject.name == "Torso")
            {
                bodyManager.CollectPart(SkeletonPart.Torso);
            }
            else if (gameObject.name == "Arm1")
            {
                if (!bodyManager.hasTorso)
                {
                    return;
                }

                bodyManager.CollectPart(SkeletonPart.Arm1);
            }
            else if (gameObject.name == "Arm2")
            {
                if (!bodyManager.hasTorso)
                {
                    return;
                }

                bodyManager.CollectPart(SkeletonPart.Arm2);
            }
            else if (gameObject.name == "Leg1")
            {
                if (!bodyManager.hasTorso)
                {
                    return;
                }

                bodyManager.CollectPart(SkeletonPart.Leg1);
            }
            else if (gameObject.name == "Leg2")
            {
                if (!bodyManager.hasTorso)
                {
                    return;
                }

                bodyManager.CollectPart(SkeletonPart.Leg2);
            }

            Debug.Log("Found player");

            sfx.Play();

            playerStats.requiredParts++;

            requiredPartsUpdate.UpdateCounter();

            Destroy(gameObject);
        }
    }
}
