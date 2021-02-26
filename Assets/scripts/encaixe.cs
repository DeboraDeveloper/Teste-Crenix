using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encaixe : MonoBehaviour
{
    public GameObject gearRot;
    public rotateGear rotatGear;
    public bool pink,blue,yellow,green, red;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //se qualquer engrenagem de arrastar entrar na colisão, o encaixe perderá a colisão, e a engrenagem de rotação será ativada
        if (collision.tag == "pink" || collision.tag == "yellow" || collision.tag == "green" || collision.tag == "blue" || collision.tag == "red")
        {
            GetComponent<Collider2D>().enabled = false;
            gearRot.SetActive(true);
        }

        //se determinada engrenagem de arrastar entrar na colisão a cor da engrenagem de rotação mudará conforme sua tag
        if (collision.tag == "pink")
        {
            pink = true;
        }

        if (collision.tag == "blue")
        {
            blue = true;
        }

        if (collision.tag == "yellow")
        {
            yellow = true;
        }

        if (collision.tag == "green")
        {
            green = true;
        }

        if (collision.tag == "red")
        {
            red = true;
        }

    }

}
