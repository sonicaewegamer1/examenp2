using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // velocidad de movimiento
    public float moveSpeed = 5f;

    // referencia al rigidbody
    private Rigidbody rb;

    // direccion de movimiento
    private Vector3 movement;

    void Start()
    {
        // obtenemos el rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // movimiento relativo a la camara
        movement =
            transform.forward * vertical +
            transform.right * horizontal;

        // evitar velocidad diagonal absurda
        movement.Normalize();


        // hago que el player rote igual que la camara
        // porque el modelo se quedaba tieso mientras la camara giraba
        // y no tenia sentido
        transform.rotation = Quaternion.Euler(
            0f,
            Camera.main.transform.eulerAngles.y,
            0f
        );
    }

    void FixedUpdate()
    {
        // mover jugador usando fisicas
        rb.MovePosition(
            rb.position +
            movement * moveSpeed * Time.fixedDeltaTime
        );
    }
}