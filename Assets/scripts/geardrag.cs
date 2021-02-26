using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geardrag : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject fix;
    public Camera cameraM;
    public bool collided, dragging, encaixado;

    // Update is called once per frame
    void Update()
    {

        //arrastar obj
        if (collided && Input.GetKeyDown(KeyCode.Mouse0))
        {
            dragging = true;
        }

        if (dragging)
        {
            rb.MovePosition(cameraM.ScreenToWorldPoint(Input.mousePosition));
        }

        //soltar obj
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            dragging = false;
        }
   
        //engrenagem fixa nos slots ou nos encaixes do cenario
        if(!dragging)
        {
            transform.position = new Vector2(fix.transform.position.x, fix.transform.position.y);
           
        }

        //ao encaixar no mundo as engrenagens ficam atrás do cenário, se sairem do encaixe elas voltam a aparecer
        if (encaixado)
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = -3;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        //ao colidir com o encaixe do mundo ou com as engrenagens que vão rotacionar, a engrenagem estará encaixada
        if (collision.tag == "fit" || collision.tag == "gearot")
        {
            encaixado = true;
        }

        //a engrenagem vai fixar no objeto que colidir com ela
        if (collision.tag == "fit" || collision.tag == "gearot" || collision.tag == "slot")
        {
            fix = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        //aosair da colisão com o encaixe do mundo ou com as engrenagens que vão rotacionar, a engrenagem estará desencaixada
        if (collision.tag == "fit" || collision.tag == "gearot")
        {
            encaixado = false;
        }

    }
    //detectar colisão do mouse nas engrenagens
    private void OnMouseOver()
    {
        collided = true;
    }

    private void OnMouseExit()
    {
        collided = false;
    }
}
