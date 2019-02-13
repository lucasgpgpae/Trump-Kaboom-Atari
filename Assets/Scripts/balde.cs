using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balde : MonoBehaviour {

    public static int pontos;
    private AudioSource sound;

    // Use this for initialization
    void Start () {
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if(pontos > 9999)
        {
            pontos--;
        }
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        //Detecta colisão com o missel
        if (col.gameObject.tag == "Missel")
        {
            //Destroi o missel
            Destroy(col.gameObject);
            sound.Play();
            pontos++;
        }
    }
}
