using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

    public Text Pontos;
    public Text Fase;

	// Update is called once per frame
	void Update () {
        Pontos.text = balde.pontos.ToString();
        Fase.text = Controller.fase.ToString();

    }
}
