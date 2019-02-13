using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    public GameObject explosao;
    public GameObject loseshield3;
    public GameObject loseshield2;
    public GameObject loseshield1;

    private void OnCollisionEnter2D(Collision2D col)
    {
        //Detecta colisão com missel
        if (col.gameObject.tag == "Missel")
        {
            Instantiate(explosao, col.transform.position, col.transform.rotation);

            //altera o modo jogando para falso
            Controller.jogando = false;
            Controller.travamover = false;

            // Diminui uma vida até o minimo 0
            if(Controller.vidas == 3)
            {
                Controller.vidas--;
                Instantiate(loseshield3);
                Destroy(GameObject.FindWithTag("balde3"));
            }else if(Controller.vidas == 2)
            {
                Controller.vidas--;
                Instantiate(loseshield2);
                Destroy(GameObject.FindWithTag("balde2"));
            }else if(Controller.vidas == 1)
            {
                Controller.vidas--;
                Instantiate(loseshield1);
                Destroy(GameObject.FindWithTag("balde1"));
            }

        }
    }
}
