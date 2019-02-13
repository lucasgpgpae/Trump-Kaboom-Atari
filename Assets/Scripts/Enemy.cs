using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject missel;
    public Transform launcher;
    public static int misseisjogados;
    public static float velocidade;
    public static bool jogarmissel;

    private bool direita;
    private bool esquerda;
    private bool mover;
    private Rigidbody2D rb2d;
    private Animator animar;
    
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        animar = GetComponent<Animator>();
        mover = false;
        jogarmissel = false;
        velocidade = 0f;
        esquerda = false;
        direita = false;
    }
	
	// Update is called once per frame
	void Update () {
        mover = Controller.jogando;


        //Jogar misseis
        if (jogarmissel)
        {
            print("jogando missel");
            if (Controller.fase == 1)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
            }
            else if (Controller.fase == 2)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 3)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 4)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 5)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 6)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 7)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 8)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 9)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 10)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 11)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 12)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 13)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 14)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 15)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 16)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 17)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 18)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 19)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            else if (Controller.fase == 20)
            {
                Instantiate(missel, launcher.position, launcher.rotation, transform.parent);
                misseisjogados++;
                
            }
            jogarmissel = false;
        }

        //Movimentação do inimigo para animacoes
        if (mover)
        {
            //Definindo lado
            if (velocidade > 0)
            {
                direita = true;
                esquerda = false;
            }
            else if (velocidade < 0)
            {
                esquerda = true;
                direita = false;
            }
            else
            {
                esquerda = false;
                direita = false;
            }
        }
        else
        {
            esquerda = false;
            direita = false;
        }
        

        // Animações
            animar.SetBool("runright", direita);
            animar.SetBool("runleft", esquerda);

    }

    private void FixedUpdate()
    {
        // Mover
        if (mover)
        {
            float run = 1 * velocidade;
            rb2d.velocity = new Vector2(run, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Detecta colisão com o missel
        if (col.gameObject.tag == "Limite")
        {
            velocidade = velocidade * -1;
        }
    }
}
