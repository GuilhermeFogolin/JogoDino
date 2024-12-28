// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de movimentação (exceção do Pulo)

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    bool alive = true;
    public LayerMask groundLayer; 

    public float speed = 5;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;

    public float speedIncreasePerPoint = 0.1f;
    public float jumpForce = 10f;

    [SerializeField] GameObject character;


    private void FixedUpdate ()
    {
        if (alive)
        {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        }
    }

    private void Update () {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5) {
            Die();
        }
       
    }

    public void Die ()
    {
        alive = false;
        Invoke("Restart", 2); // Reinicia o jogo
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
