using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botoes : MonoBehaviour {

    public void Play()
    {
        StartCoroutine(iniciar());
    }

    public void Quit()
    {
        StartCoroutine(sair());
    }

    public void Restart()
    {
        Destroy(GameObject.FindWithTag("result"));
        Controller.fase = 1;
        Controller.faseinexistente = 1;
        balde.pontos = 0;
        SceneManager.LoadScene("Play");
    }

    public void MainMenu(){
        Destroy(GameObject.FindWithTag("result"));
        Controller.fase = 1;
        Controller.faseinexistente = 1;
        balde.pontos = 0;
        SceneManager.LoadScene("Start");
    }

    public void Continue()
    {
        if (Controller.isplayerpaused)
        {
            Controller.jogando = false;
            Controller.travamover = false;
            Destroy(GameObject.FindWithTag("result"));
            Controller.a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
            Controller.ispaused = false;
        }
        else if (Controller.passandofase)
        {
            Controller.jogando = false;
            Controller.travamover = true;
            Destroy(GameObject.FindWithTag("result"));
            Controller.a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
            Controller.passfase = true;
            Controller.ispaused = false;
        }
        else if(!Controller.isplayerpaused && !Controller.passandofase)
        {
            Controller.jogando = true;
            Controller.travamover = true;
            Misseis.trava = false;
            Destroy(GameObject.FindWithTag("result"));
            Controller.a_BackgroundMusic.GetComponent<AudioSource>().UnPause();
            Controller.ispaused = false;
        }
    }

    IEnumerator iniciar(float t = 1)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator sair(float t = 1)
    {
        yield return new WaitForSeconds(t);
        Debug.Log("QUIT");
        Application.Quit();
    }

}
