using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f; // Velocidad de la pelota
    public float resetTime = 2f; // Tiempo en segundos para reiniciar la pelota
    private Vector3 initialPosition; // Posición inicial de la pelota
    private Rigidbody rb;
    private float timeSinceLastCollision; // Temporizador para reinicio

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        LaunchBall();
    }

    void LaunchBall()
    {
        // Genera un vector de dirección inicial aleatorio
        Vector3 direction = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
        rb.velocity = direction * speed;
    }

    void Update()
    {
        // Asegura que la velocidad se mantiene constante
        rb.velocity = rb.velocity.normalized * speed;
        // Actualiza el temporizador desde la última colisión
        if (timeSinceLastCollision > 0)
        {
            timeSinceLastCollision += Time.deltaTime;
            if (timeSinceLastCollision >= resetTime)
            {
                // Reinicia la pelota a su posición inicial si ha pasado el tiempo
                ResetBall();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Reinicia el temporizador cuando la pelota colisiona con una pared
        timeSinceLastCollision = 0f;
    }

    private void ResetBall()
    {
        // Restablece la posición y velocidad de la pelota
        transform.position = initialPosition;
        rb.velocity = Vector3.zero;
        LaunchBall(); // Lanza la pelota de nuevo
        timeSinceLastCollision = 0f; // Reinicia el temporizador
    }
}
