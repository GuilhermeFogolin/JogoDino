// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de criação e destruição das moedas

using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); // Colisão com moedas = destruição 
        }
        else if (other.gameObject.CompareTag("PlayerTag"))
        {
            GameManager.inst.IncrementScore();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}

