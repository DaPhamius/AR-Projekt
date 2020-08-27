using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        FlyingEnemy enemy = other.GetComponent<FlyingEnemy>();

        if (enemy != null)
        {
            enemy.TakeDamage();
            Destroy(gameObject);
        }
    }
}
