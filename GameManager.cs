// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de sistema de pontuação 

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    int score;
    public static GameManager inst;

    [SerializeField] Text scoreText;

    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore ()
    {
        score++;
        scoreText.text = "Pontuação: " + score;
        playerMovement.speed += playerMovement.speedIncreasePerPoint; // Aumenta a velocidade do jogador
    }

    private void Awake ()
    {
        inst = this;
    }

    private void Start () {

	}

	private void Update () {
	
	}
}