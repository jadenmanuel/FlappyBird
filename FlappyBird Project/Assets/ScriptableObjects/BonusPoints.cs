using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/BonusPoints")]
public class BonusPoints : PowerupEffect
{

    public int amount;
    public override void ApplyEffect(GameObject target)
    {


        if (target.gameObject.tag != "Obstacle")
        {
            target.GetComponent<BoundaryCollider>().scoreNum += amount;
            target.GetComponent<BoundaryCollider>().updateScore();
            Debug.Log(target.GetComponent<BoundaryCollider>().scoreNum);
        }







    }
}
