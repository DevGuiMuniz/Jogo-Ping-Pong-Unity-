using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public float Velocidade = 10;
    public TMP_Text pontuacaoEsquerda;
    public TMP_Text pontuacaoDireita;
    int pontosEsquerda = 0;
    int pontosDireita = 0;

    void Start()
    {
      
        float x = Random.Range(0, 2); // ou Random.Range( 0, 2) == 0 ? -1: 1; -- outo  jeito do c# de fazer o if e else
        if(x == 0)
        {
            x = -1;
        }else
        {
            x = 1;
        }

        float y = Random.Range(0, 2);

        if(y == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }
        GetComponent<Rigidbody>().velocity = new Vector2(Velocidade *x, Velocidade*y);
        pontuacaoDireita.SetText(pontosDireita.ToString());
        pontuacaoEsquerda.SetText(pontosEsquerda.ToString());



    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision batida)
        
    {
        if (batida.gameObject.name == "BEsquerda")  
        {
            transform.position = new Vector3(33, 0, 3);
            pontosDireita++;
            
            Start();
        } else if (batida.gameObject.name == "BDireita")
        {
            transform.position = new Vector3(33, 0, 3);
            pontosEsquerda++;
       
            Start();
        }

        
            
    }
}
