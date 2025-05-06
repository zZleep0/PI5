using TMPro;
using UnityEngine;

public class WinConditionFase2 : MonoBehaviour
{
    public int pontos = 0;
    public int vida = 5;

    public GameObject pnlVitoria;
    public GameObject pnlDerrota;

    public TextMeshProUGUI txtPontos;
    public TextMeshProUGUI txtVida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pnlDerrota.SetActive(false);
        pnlVitoria.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = "Pontos: " + pontos;
        txtVida.text = "Vida: " + vida;

        if (pontos >= 10)
        {
            pontos = 10;
            pnlVitoria.SetActive(true);
        }

        if (vida <= 0)
        {
            vida = 0;
            pnlDerrota.SetActive(true);
        }
    }
}
