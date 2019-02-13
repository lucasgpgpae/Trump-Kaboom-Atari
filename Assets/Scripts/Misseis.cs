using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misseis : MonoBehaviour {

    private Vector2 velocidadeantiga;
    public static bool trava;
    private bool execute;
    private bool havesavedvelocity;
    private float impulso;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        impulso = 100;
        trava = false;
        execute = true;
        havesavedvelocity = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (trava)
        {
            if (execute)
            {
                velocidadeantiga = rb2d.velocity;
                print(rb2d.velocity);
                rb2d.constraints = RigidbodyConstraints2D.FreezePositionY;
                havesavedvelocity = true;
                execute = false;
            }
        }
        else
        {
            rb2d.constraints = RigidbodyConstraints2D.None;
            rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (havesavedvelocity)
            {
                rb2d.velocity = velocidadeantiga;
                print(rb2d.velocity);
                execute = true;
                havesavedvelocity = false;
            }
        }
	}
}
