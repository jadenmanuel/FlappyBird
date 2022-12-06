using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffect powerupEffect;
    private void OnTriggerEnter(Collider other)
    {
        powerupEffect.ApplyEffect(other.gameObject);
        Destroy(gameObject);



    }
}