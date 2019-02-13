using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    //Reacionadas ao Gameplay
    public static int vidas = 3;
    private float velocidade;
    public static bool jogando;
    public static bool mover;
    public static int fase = 1;
    public static bool travamover;
    public static int faseinexistente = 1;
    public static bool passandofase;
    public static bool passfase;
    //Relacionadas a pontuação
    public GameObject lose;
    public GameObject win;
    //Relacionadas ao sistema de pause
    public GameObject pause;
    public static bool ispaused;
    public static bool isplayerpaused;
    //Relacionadas ao sistema de som
    private GameObject a_lvlup;
    private float a_TrumpRandom;
    private GameObject a_Trump1;
    private GameObject a_Trump2;
    private GameObject a_Trump3;
    private GameObject a_Trump4;
    private GameObject a_Trump5;
    private GameObject a_Trump6;
    public static GameObject a_BackgroundMusic;
    private float a_LoseRandom;
    private GameObject a_Lose1;
    private GameObject a_Lose2;
    private GameObject a_Lose3;

    //Privadas
    private bool result;
    private float intervalo;
    private bool voltarposicao;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start () {
        jogando = false;
        isplayerpaused = true;
        travamover = false;
        ispaused = false;
        vidas = 3;
        intervalo = 3.0f;
        result = true;
        velocidade = 7f;
        voltarposicao = true;
        passandofase = false;
        passfase = false;

        //Get audios
        a_lvlup = GameObject.Find("Audio-LvlUp");
        a_Trump1 = GameObject.Find("Audio-Trump1");
        a_Trump2 = GameObject.Find("Audio-Trump2");
        a_Trump3 = GameObject.Find("Audio-Trump3");
        a_Trump4 = GameObject.Find("Audio-Trump4");
        a_Trump5 = GameObject.Find("Audio-Trump5");
        a_Trump6 = GameObject.Find("Audio-Trump6");
        a_BackgroundMusic = GameObject.Find("Audio-Music-DoctorVox_NeonLights");
        a_Lose1 = GameObject.Find("Audio-Lose1");
        a_Lose2 = GameObject.Find("Audio-Lose2");
        a_Lose3 = GameObject.Find("Audio-Lose3");

        //Get RigidBody
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //definindo fases
        if(balde.pontos == 0 && fase == 1 && faseinexistente == 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Enemy.velocidade = 4.0f;
                misseltimer.intervalo = 1f;
                velocidade = 7f;
            }
        }
        if(balde.pontos >= 8 && fase == 1 && faseinexistente == 1)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.8f;
            Enemy.velocidade = 8.0f;
            velocidade = 7f;
            print("Level Up");
            faseinexistente++;
        }
        else if(balde.pontos >= 25 && fase == 2 && faseinexistente == 2)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.5f;
            Enemy.velocidade = 8.0f;
            velocidade = 6f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 60 && fase == 3 && faseinexistente == 3)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.4f;
            Enemy.velocidade = 10.0f;
            velocidade = 8f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 115 && fase == 4 && faseinexistente == 4)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.4f;
            Enemy.velocidade = 12.0f;
            velocidade = 9f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 205 && fase == 5 && faseinexistente == 5)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.2f;
            Enemy.velocidade = 10.0f;
            velocidade = 9f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 325 && fase == 6 && faseinexistente == 6)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.2f;
            Enemy.velocidade = 11.0f;
            velocidade = 9f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 470 && fase == 7 && faseinexistente == 7)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.2f;
            Enemy.velocidade = 12.0f;
            velocidade = 10f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 635 && fase == 8 && faseinexistente == 8)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.1f;
            Enemy.velocidade = 12.0f;
            velocidade = 12f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 815 && fase == 9 && faseinexistente == 9)
        {
            a_lvlup.GetComponent<AudioSource>().Play();
            jogando = false;
            StartCoroutine(intervalodefases(intervalo));
            misseltimer.intervalo = 0.1f;
            Enemy.velocidade = 13.0f;
            print("Level Up");
            faseinexistente++;
        }
        else if (balde.pontos >= 1000 && fase == 10 && faseinexistente == 10)
        {
            if (result && vidas == 0)
            {
                Instantiate(win);
                result = false;
            }
        }

        // Input 
        if (Input.GetAxis("Horizontal") != 0)
        {
            mover = true;
        }
        else
        {
            mover = false;
        }

        //Controle da bool jogando (Se tiver levado dano desliga o jogando)
        if(jogando == false)
        {
            //Destroi todos os misseis se o jogo n estiver pausado
            if (!ispaused)
            {
                Destroy(GameObject.FindWithTag("Missel"));
            }
                //verifica se precisa voltar ao ponto inicial e se não está pausado.
            if (voltarposicao && !travamover && !ispaused)
            {
                transform.position = new Vector2(0f, -4f);
                voltarposicao = false;
            }
            //Ao pressionar Space ativa o jogando novamente
            if (Input.GetButtonDown("Jump") && vidas > 0 && !ispaused)
            {
                voltarposicao = true;
                travamover = true;
                jogando = true;

                //Sistema de audio de fala do trump
                a_TrumpRandom = Random.Range(1, 6);

                if (a_TrumpRandom == 1)
                {
                    a_Trump1.GetComponent<AudioSource>().Play();
                }
                else if (a_TrumpRandom == 2)
                {
                    a_Trump2.GetComponent<AudioSource>().Play();
                }
                else if (a_TrumpRandom == 3)
                {
                    a_Trump3.GetComponent<AudioSource>().Play();
                }
                else if (a_TrumpRandom == 4)
                {
                    a_Trump4.GetComponent<AudioSource>().Play();
                }
                else if (a_TrumpRandom == 5)
                {
                    a_Trump5.GetComponent<AudioSource>().Play();
                }
                else if (a_TrumpRandom == 6)
                {
                    a_Trump6.GetComponent<AudioSource>().Play();
                }
            }
            else if(vidas == 0) // se não tiver mais vidas não deixa iniciar
            {
                if (result) // PERDEU
                {
                    a_LoseRandom = Random.Range(1, 3);
                    if(a_LoseRandom == 1)
                    {
                        a_Lose1.GetComponent<AudioSource>().Play();
                    }else if(a_LoseRandom == 2)
                    {
                        a_Lose2.GetComponent<AudioSource>().Play();
                    }
                    else if(a_LoseRandom == 3)
                    {
                        a_Lose3.GetComponent<AudioSource>().Play();
                    }
                    Instantiate(lose);
                    result = false;
                }
                print("YOU DIED!");
            }

        }

        //se o controlador estiver no 0 o jogo está parado por ter perdido uma vida
        if (transform.position.x == 0)
        {
            isplayerpaused = true;
        }
        else
        {
            isplayerpaused = false;
        }

        //Pausa o game com ESC
        if (ispaused && result) // Despausa o game
        {
            if (Input.GetButtonDown("ESC"))
            {
                
                if (isplayerpaused) //Verifica se o jogador já estava parado antes de pausar
                {
                    jogando = false;
                    travamover = false;
                    Destroy(GameObject.FindWithTag("result"));
                    a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
                    ispaused = false;
                }
                else if (passandofase)
                {
                    jogando = false;
                    travamover = true;
                    Destroy(GameObject.FindWithTag("result"));
                    a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
                    passfase = true;
                    ispaused = false;
                }
                else if(!isplayerpaused && !passandofase)
                {
                    jogando = true;
                    travamover = true;
                    Misseis.trava = false;
                    Destroy(GameObject.FindWithTag("result"));
                    a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
                    ispaused = false;
                }
            }
        }
        else if(!ispaused && result) // Pausa o game
        {
            if (Input.GetButtonDown("ESC"))
            {
                jogando = false;
                travamover = false;
                Misseis.trava = true;
                Instantiate(pause);
                a_BackgroundMusic.GetComponent<AudioSource>().Pause();
                ispaused = true;
            }
        }

        if (passfase)
        {
            StartCoroutine(intervalodefases(intervalo));
            passfase = false;
        }

    }

    IEnumerator intervalodefases(float t)
    {
        passandofase = true;
        yield return new WaitForSeconds(t);

        //verifica se o jogo esta parado antes de comecar nova fase
        if (ispaused) // se estiver pausado ele volta a executar até o jogador despausar
        {
            print("Game is paused, waiting for unpause");
        }
        else // se não estiver pausado ele inicia a nova fase
        {
            fase++;
            passandofase = false;
            jogando = true;

            //Sistema de audio de fala do trump
            a_TrumpRandom = Random.Range(1, 6);

            if(a_TrumpRandom == 1)
            {
                a_Trump1.GetComponent<AudioSource>().Play();
            }
            else if(a_TrumpRandom == 2)
            {
                a_Trump2.GetComponent<AudioSource>().Play();
            }
            else if (a_TrumpRandom == 3)
            {
                a_Trump3.GetComponent<AudioSource>().Play();
            }
            else if (a_TrumpRandom == 4)
            {
                a_Trump4.GetComponent<AudioSource>().Play();
            }
            else if (a_TrumpRandom == 5)
            {
                a_Trump5.GetComponent<AudioSource>().Play();
            }
            else if (a_TrumpRandom == 6)
            {
                a_Trump6.GetComponent<AudioSource>().Play();
            }
        }

    }

    private void FixedUpdate()
    {
        // Mover
        if (mover && travamover)
        {
            float run = Input.GetAxisRaw("Horizontal") * velocidade;
            rb2d.velocity = new Vector2(run, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

    }
}
