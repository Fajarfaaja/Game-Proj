using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGameNamespace
{
    public class Bullet : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            AIEnemy enemy = collision.gameObject.GetComponent<AIEnemy>();
            if (enemy != null)
            {
                Debug.Log("Bullet hit enemy!");
                enemy.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}
