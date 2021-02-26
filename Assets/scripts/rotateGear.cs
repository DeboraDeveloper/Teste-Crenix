using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateGear : MonoBehaviour
{
    SpriteRenderer spr;
    public encaixe encaixe;
    public detectGears detectGears;
    public GameObject fit;
    public bool top, bot;
    
    //detectGears detect;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //se todas as engrenagens estiverem posicionadas e estiver detectando com a colisão do topo do detector a engrenagem rotacionara em sentido horário
        if (top && detectGears.detectAtiv)
        {
            transform.Rotate(0, 0, -200 * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, 0 * Time.deltaTime);
        }
        //se todas as engrenagens estiverem posicionadas e estiver detectando com a colisão de baixo do detector a engrenagem rotacionara em sentido anti-horário
        if (bot && detectGears.detectAtiv)
        {
            transform.Rotate(0, 0, 200 * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, 0 * Time.deltaTime);
        }

        //muda a cor conforme a tag das engrenagens
        if (encaixe.pink)
        {
            spr.color = Color.magenta;
        }

        if (encaixe.blue)
        {
            spr.color = Color.cyan;
        }

        if (encaixe.yellow)
        {
            spr.color = Color.yellow;
        }

        if (encaixe.green)
        {
            spr.color = Color.green;
        }

        if (encaixe.red)
        {
            spr.color = Color.red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //se colidiu com a coliso de cima do detector
        if (collision.tag == "top")
        {
            top = true;
        }
        //se colidiu com a coliso de baixo do detector
        if (collision.tag == "bot")
        {
            bot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //se qualquer engranagem de arrastar sair da colisão, a engrenagem de rotação sera desativada e a colisão do encaixe ativada novamente
        if(collision.tag == "pink" || collision.tag == "yellow" || collision.tag == "green" || collision.tag == "blue" || collision.tag == "red")
        {
            
            gameObject.SetActive(false);
            fit.GetComponent<Collider2D>().enabled = true;

            //se saiu da colisão de  cima do detector
            if (collision.tag == "top")
            {
                top = false;
            }
            //se saiu da colisão de baixo do detector
            if (collision.tag == "bot")
            {
                bot = false;
            }
        }
        //se determinada engrenagem de arrastar sair da colisão, a cor voltará ao normal
        if (collision.tag == "pink")
        {
            encaixe.pink = false;

        }

        if (collision.tag == "blue")
        {
            encaixe.blue = false;

        }

        if (collision.tag == "yellow")
        {
            encaixe.yellow = false;

        }

        if (collision.tag == "green")
        {
            encaixe.green = false;

        }

        if (collision.tag == "red")
        {
            encaixe.red = false;

        }
    }
}
