using UnityEngine;

public class Shooting : MonoBehaviour
{
    // prefab de la bala
    public GameObject bulletPrefab;

    // punto desde donde dispara
    public Transform firePoint;

    // velocidad de la bala
    public float bulletSpeed = 20f;

    void Update()
    {
        // click izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // crear bala
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            firePoint.rotation
        );

        // obtener rigidbody
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // mover bala hacia adelante
        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }
}