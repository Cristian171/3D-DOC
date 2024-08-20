using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    private float moveInputX;
    private float moveInputZ;
    private float initialY;

    void Start()
    {
        // Guardar la posición inicial en Y al inicio
        initialY = transform.position.y;
    }

    void Update()
    {
        // Obtener la entrada horizontal y vertical del usuario
        moveInputX = Input.GetAxis("Horizontal");
        moveInputZ = Input.GetAxis("Vertical");

        // Crear un nuevo vector de movimiento solo en los ejes X y Z
        Vector3 movement = new Vector3(moveInputX, 0, moveInputZ);

        // Mover el paddle en los ejes X y Z mientras mantiene su posición en Y
        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;
        transform.position = new Vector3(newPosition.x, initialY, newPosition.z);
    }
}
