using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speedMove = 350f;
    [SerializeField] private GameObject bulletPrefab; 
    [SerializeField] private Transform bulletSpawnPoint; 
    [SerializeField] private float bulletSpeed = 10f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Kontrol pergerakan
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
        rb.velocity = moveDirection * speedMove * Time.deltaTime;

        // Fungsi tembak
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletPrefab == null || bulletSpawnPoint == null)
        {
            Debug.LogWarning("BulletPrefab atau BulletSpawnPoint belum diassign!");
            return;
        }

        // spawn peluru
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // tambah speed
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        if (bulletRb != null)
        {
            bulletRb.velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
