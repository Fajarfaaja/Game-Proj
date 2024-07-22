using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGameNamespace
{
    public class Bullet : MonoBehaviour
    {
        public AudioClip hitSound; // Referensi ke klip suara
        private AudioSource audioSource; // Referensi ke komponen AudioSource

        void Start()
        {
            // Tambahkan komponen AudioSource jika belum ada
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false; // Pastikan tidak diputar saat game dimulai
            if (hitSound != null)
            {
                audioSource.clip = hitSound; // Assign klip suara ke AudioSource
            }
            else
            {
                Debug.LogError("hitSound is not assigned!");
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            AIEnemy enemy = collision.gameObject.GetComponent<AIEnemy>();
            if (enemy != null)
            {
                Debug.Log("Bullet hit enemy!");
                enemy.TakeDamage();

                // Mainkan efek suara jika klip suara diassign
                if (hitSound != null)
                {
                    audioSource.PlayOneShot(hitSound);
                }

                // Hancurkan peluru setelah beberapa waktu untuk memungkinkan efek suara diputar
                Destroy(gameObject, hitSound != null ? hitSound.length : 0f);
            }
        }
    }
}
