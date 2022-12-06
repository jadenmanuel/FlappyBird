using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/Immunity")]

public class Immunity : PowerupEffect
{

    public int time;

    void removeImmunity(GameObject target)
    {
        target.GetComponent<BoundaryCollider>().isImmune = false;
    }
    public override void ApplyEffect(GameObject target)
    {


        if (target.gameObject.tag != "Obstacle")
        {

            Debug.Log("Immunity Powerup applied (5 s)");
            target.GetComponent<BoundaryCollider>().SetImmune(time);
        }



    }
}




