using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitemovel : MonoBehaviour {

    public float limitedir, limiteesq;
    public float limiterandom;

    private float velocidade = 2.0f;
    private bool mover;

	// Use this for initialization
	void Start () {
        limiterandom = Random.Range(limiteesq, limitedir);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= limiterandom)
        {
            velocidade = 2.0f;
            mover = true;
        }
        else if (transform.position.x >= limiterandom)
        {
            velocidade = -2.0f;
            mover = true;
        }
    }

    private void FixedUpdate()
    {

        // Mover
        if (mover && Controller.jogando)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Detecta colisão com o missel
        if (col.gameObject.tag == "Enemy")
        {
            limiterandom = Random.Range(limiteesq, limitedir);
        }
    }
}
