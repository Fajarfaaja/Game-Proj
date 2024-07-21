using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun : MonoBehaviour
{
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
        _input = transform.root.GetComponent<StarterAssetsInputs>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.shoot)
        {
            Shoot();
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
}
