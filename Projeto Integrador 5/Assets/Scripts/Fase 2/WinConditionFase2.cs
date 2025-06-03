using TMPro;
using UnityEngine;

public class WinConditionFase2 : MonoBehaviour
{
    public int pontos = 0;

    public GameObject pnlVitoria;

    public TextMeshProUGUI txtPontos;
    public TextMeshProUGUI txtVida;

    public SoundManager soundManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pnlVitoria.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        txtPontos.text = "Pontos: " + pontos;

        if (pontos >= 10)
        {
            pontos = 10;
            pnlVitoria.SetActive(true);
            soundManager.SomVictory();
        }
    }
}
