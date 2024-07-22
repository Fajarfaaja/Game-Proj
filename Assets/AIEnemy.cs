using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace MyGameNamespace
{
    public class AIEnemy : MonoBehaviour
    {
        public Transform playerTransform;
        public GameObject bulletPrefab; // Referensi ke prefab peluru
        public Transform shootPoint; // Titik dari mana peluru ditembakkan
        public float chaseDistance = 10.0f; // Jarak pengejaran
        public float shootDistance = 8.0f; // Jarak tembak
        public float shootInterval = 1.0f; // Waktu antara tembakan
        public float bulletSpeed = 20.0f; // Kecepatan peluru

        private NavMeshAgent agent;
        private int hitCount = 0;
        private int maxHits = 3;
        private float lastShootTime;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            lastShootTime = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
            if (distanceToPlayer <= chaseDistance)
            {
                agent.destination = playerTransform.position;

                if (distanceToPlayer <= shootDistance && Time.time > lastShootTime + shootInterval)
                {
                    Shoot();
                    lastShootTime = Time.time;
                }
            }
            else
            {
                agent.destination = transform.position; // Tetap di tempat
            }
        }

        void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = shootPoint.forward * bulletSpeed;
            Debug.Log("Musuh menembakkan peluru!");
        }

        public void TakeDamage()
        {
            hitCount++;
            Debug.Log("Jumlah serangan musuh: " + hitCount);
            if (hitCount >= maxHits)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log("Musuh mati!");
            Destroy(gameObject);
        }

        void OnCollisionEnter(Collision collision)
    {
    // Check if the collided object has the tag "Player"
            if (collision.gameObject.CompareTag("Player"))
            {
                PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(10);
                }
            }
        }
    }
}
