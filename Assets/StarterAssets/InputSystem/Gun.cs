using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun : MonoBehaviour
{
    public float ClipLength = 1f;
    public AudioSource audioSource; // Ganti GameObject dengan AudioSource
    private StarterAssetsInputs _input;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform bulletPoint;

    [SerializeField]
    private float bulletSpeed = 600f;

    // Start is called before the first frame update
    void Start()
    {
        // Periksa apakah audioSource telah diassign
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned!");
        }
        _input = transform.root.GetComponent<StarterAssetsInputs>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            StartCoroutine(ShootGun()); // Panggil ShootGun Coroutine
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        Debug.Log("Shoot!");
        if (bulletPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(bulletPoint.forward * bulletSpeed, ForceMode.Impulse);
                Destroy(bullet, 1f);
            }
        }
        else
        {
            Debug.LogError("bulletPoint is not assigned!");
        }
    }

    IEnumerator ShootGun()
    {
        Shoot();
        
        // Periksa apakah audioSource telah diassign
        if (audioSource != null)
        {
            audioSource.Play(); // Memutar audio
            yield return new WaitForSeconds(ClipLength);
            // audioSource.Stop(); // Tidak perlu berhenti jika menggunakan PlayOneShot
        }
        else
        {
            Debug.LogError("AudioSource is not assigned!");
        }
    }
}
