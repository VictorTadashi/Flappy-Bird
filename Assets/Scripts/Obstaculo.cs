using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private UIscript scriptDaUI;

    [SerializeField]
    private float variacaoY;
    private void Awake()
    {
        this.transform.Translate(Vector3.up * -3);
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.pontuei && this.transform.position.x < posicaoPassaro.x)
        {
            Debug.Log("Pontoou");
            this.pontuei = true;
            this.scriptDaUI.adicionarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        
    }
    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<UIscript>();
    }
}
