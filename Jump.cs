// Guilherme Fogolin, Lucas Moreira, Pedro Lemos e Yan Cezarato

// Atividade N1 - Professora Lucy Mari (LogAlg)

// Código de pulo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public bool onGround = true;
        
        private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") && onGround) {
            rb.AddForce(new Vector3(0,6,0), ForceMode.Impulse);
            onGround = false; 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground") 
        {
            onGround = true; 
        }
    }
}
