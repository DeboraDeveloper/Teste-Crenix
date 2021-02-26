using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text textBalloon;
    public detectGears detectGears;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detectGears.detectAtiv)
        {
            textBalloon.GetComponent<Text>().text = "YAY, PARABÉNS. TASK CONCLUÌDA!";
        }
        else
        {
            textBalloon.GetComponent<Text>().text = "ENCAIXE AS ENGRENAGENS EM QUALQUER ORDEM!";
        }
    }
}
