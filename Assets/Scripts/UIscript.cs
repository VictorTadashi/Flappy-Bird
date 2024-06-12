using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIscript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;

    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    private void Start()
    {
        var roat = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = roat.Q<Label>("pontos");
    }
}
