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
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // guardam direccion
        movement = new Vector3(horizontal, 0f, vertical);
    }

    void FixedUpdate()
    {
        // mueve al jugador
        rb.MovePosition(
            rb.position +
            movement * moveSpeed * Time.fixedDeltaTime
        );
    }
}