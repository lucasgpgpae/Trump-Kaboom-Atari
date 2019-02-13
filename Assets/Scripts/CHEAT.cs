using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHEAT : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && Controller.jogando)
        {
            if (Controller.fase == 1)
            {
                balde.pontos = 8;
            }
            else if (Controller.fase == 2)
            {
                balde.pontos = 25;
            }
            else if (Controller.fase == 3)
            {
                balde.pontos = 60;
            }
            else if (Controller.fase == 4)
            {
                balde.pontos = 115;
            }
            else if (Controller.fase == 5)
            {
                balde.pontos = 205;
            }
            else if (Controller.fase == 6)
            {
                balde.pontos = 325;
            }
            else if (Controller.fase == 7)
            {
                balde.pontos = 470;
            }
            else if (Controller.fase == 8)
            {
                balde.pontos = 635;
            }
            else if (Controller.fase == 9)
            {
                balde.pontos = 815;
            }
            else if (Controller.fase == 10)
            {
                balde.pontos = 1000;
            }

        }
        if (Input.GetButtonDown("Fire2") && Controller.jogando)
        {
            Controller.faseinexistente--;
            Controller.fase--;

            if (Controller.fase == 1)
            {
                balde.pontos = 1;
            }
            else if (Controller.fase == 2)
            {
                balde.pontos = 8;
            }
            else if (Controller.fase == 3)
            {
                balde.pontos = 25;
            }
            else if (Controller.fase == 4)
            {
                balde.pontos = 60;
            }
            else if (Controller.fase == 5)
            {
                balde.pontos = 115;
            }
            else if (Controller.fase == 6)
            {
                balde.pontos = 205;
            }
            else if (Controller.fase == 7)
            {
                balde.pontos = 325;
            }
            else if (Controller.fase == 8)
            {
                balde.pontos = 470;
            }
            else if (Controller.fase == 9)
            {
                balde.pontos = 635;
            }
            else if (Controller.fase == 10)
            {
                balde.pontos = 815;
            }

        }
    }
}
