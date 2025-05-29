
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    public int cenaAtual;

    private void Start()
    {
        cenaAtual = SceneManager.GetActiveScene().buildIndex;

        // Pega todos os botões da cena (inclusive os desativados)
        Button[] botoes = GameObject.FindObjectsOfType<Button>(true);

        foreach (Button btn in botoes)
        {
            switch (btn.name)
            {
                case "BtnStart":
                    if (cenaAtual == 0)
                        btn.onClick.AddListener(Iniciar);
                    break;

                case "BtnFase1":
                    if (cenaAtual == 1)
                        btn.onClick.AddListener(Fase1);
                    break;

                case "BtnFase2":
                    if (cenaAtual == 1)
                        btn.onClick.AddListener(Fase2);
                    break;

                case "BtnFase3":
                    if (cenaAtual == 1)
                        btn.onClick.AddListener(Fase3);
                    break;

                case "BtnMenu":
                    if (cenaAtual >= 2)
                        btn.onClick.AddListener(Menu);
                    break;

                case "BtnReiniciar":
                    if (cenaAtual >= 2)
                        btn.onClick.AddListener(Reiniciar);
                    break;

                case "BtnProximo":
                    if (cenaAtual >= 2)
                        btn.onClick.AddListener(ProximoNivel);
                    break;

                
            }
        }

        // Painéis (opcional)
        if (cenaAtual >= 2)
        {
            GameObject pnlPause = GameObject.Find("PnlPause");
            if (pnlPause != null) pnlPause.SetActive(false);

            GameObject pnlVitoria = GameObject.Find("PnlVitoria");
            if (pnlVitoria != null) pnlVitoria.SetActive(false);
        }

    }

    #region Menu inicial
    public void Iniciar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Fase1()
    {
        SceneManager.LoadScene("Fase 1");
    }
    public void Fase2()
    {
        SceneManager.LoadScene("Fase 2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("Fase 3");
    }

    public void FecharJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
    #endregion

    #region In Game
    public void Reiniciar()
    {
        SceneManager.LoadScene(cenaAtual);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ProximoNivel()
    {
        SceneManager.LoadScene(cenaAtual + 1);
        Debug.Log("Foi para o proximo");
    }

    #endregion
}
