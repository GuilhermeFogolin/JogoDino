// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de obstáculos 

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Obstacle : MonoBehaviour {

    PlayerMovement playerMovement;

	private void Start () {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
	}

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.name == "Player") {
            
            playerMovement.Die(); // Mata o personagem
        }
    }

    private void Update () {
	
	}
}