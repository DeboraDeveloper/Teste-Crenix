using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectGears : MonoBehaviour
{
    public GameObject detect;
    public float gears;
    public bool fullGearCollider;
    public bool detectAtiv;
    // Update is called once per frame
    void Update()
    {

        if (detectAtiv)
        {
            detect.SetActive(true);
        }
        //se todas as engrenagens forem posicionadas será ativada a colisão que fará as engrenagens de rotação rotacionarem
        if(gears >= 5)
        {
            detectAtiv = true;
        }
        else
        {
            detectAtiv = false;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //soma a cada engrenagem ser posicionada nos encaixes
        if (collision.tag == "pink")
        {
            gears = gears + 1;
        }
        if (collision.tag == "yellow")
        {
            gears = gears + 1;
        }
        if (collision.tag == "green")
        {
            gears = gears + 1;
        }
        if (collision.tag == "blue")
        {
            gears = gears + 1;
        }
        if (collision.tag == "red")
        {
            gears = gears + 1;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //subitrai a cada engrenagem ser retirada dos encaixes
        if (collision.tag == "pink")
        {
            gears = gears - 1;
        }
        if (collision.tag == "yellow")
        {
            gears = gears - 1;
        }
        if (collision.tag == "green")
        {
            gears = gears - 1;
        }
        if (collision.tag == "blue")
        {
            gears = gears - 1;
        }
        if (collision.tag == "red")
        {
            gears = gears - 1;
        }
        
    }
}
