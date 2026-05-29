using UnityEngine;

public class Bullet : MonoBehaviour
{
    // velocidad de la bala
    public float speed = 20f;

    // tiempo antes de destruirse
    public float lifeTime = 5f;

    void Start()
    {
        // destruir bala despues de 5 segundos
        // para que no queden flotando si falla el player
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // mover bala hacia adelante
        transform.Translate(
            Vector3.forward * speed * Time.deltaTime
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        // destruir al impactar
        Destroy(gameObject);
    }
}

//olaprofe