
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

        if (cenaAtual == 0)
        {
            Button btnIniciar = GameObject.Find("BtnStart").GetComponent<Button>();
            btnIniciar.onClick.AddListener(Iniciar);
        }

        else if (cenaAtual == 1)
        {
            Button btnFase1 = GameObject.Find("BtnFase1").GetComponent<Button>();
            btnFase1.onClick.AddListener(Fase1);
        }

        else if (cenaAtual == 2)
        {
            Button btnReiniciar = GameObject.Find("BtnReiniciar").GetComponent<Button>();
            Button btnMenu = GameObject.Find("BtnMenu").GetComponent<Button>();

            btnReiniciar.onClick.AddListener(Reiniciar);
            btnMenu.onClick.AddListener(Menu);

            GameObject pnlPause = GameObject.Find("PnlPause");
            pnlPause.SetActive(false);
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
        Debug.Log("Foi para o proximo");
    }

    #endregion

    
}
