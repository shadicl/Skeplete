using UnityEngine;

public class BodyManager : MonoBehaviour
{
    public bool hasTorso;
    public bool hasArm1;
    public bool hasArm2;
    public bool hasLeg1;
    public bool hasLeg2;

    public bool HasAllParts()
    {
        return hasTorso && hasArm1 && hasArm2 && hasLeg1 && hasLeg2;
    }

    public void CollectPart(SkeletonPart part)
    {
        switch (part)
        {
            case SkeletonPart.Torso:
                hasTorso = true;
                break;
            case SkeletonPart.Arm1:
                hasArm1 = true;
                break;
            case SkeletonPart.Arm2:
                hasArm2 = true;
                break;
            case SkeletonPart.Leg1:
                hasLeg1 = true;
                break;
            case SkeletonPart.Leg2:
                hasLeg2 = true;
                break;
        }
    }

    void ChangeSprite()
    {

    }

    void EnableArmsAbility()
    {

    }

    void EnableLegsAbility()
    {
        
    }
}
