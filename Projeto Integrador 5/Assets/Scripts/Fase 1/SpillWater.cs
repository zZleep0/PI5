using UnityEngine;

public class SpillWater : MonoBehaviour
{
    public float qtdAgua = 20f;

    //public float rotacaoZ;
    public ParticleSystem aguaParticula;

    public float rotacaoX;

    public bool vazio = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aguaParticula = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        rotacaoX = transform.eulerAngles.x; // Usa transform.eulerAngles para acessar a rota��o de Euler

        var mainmodule = aguaParticula.main;

        // Usa transform.eulerAngles para acessar a rota��o de Euler
        if (rotacaoX >= 45 && rotacaoX <= 135 || rotacaoX <= 315 && rotacaoX >= 225) // Ajuste do intervalo para evitar inconsist�ncias de rota��o
        {
            qtdAgua = qtdAgua - Time.deltaTime * 2;

            mainmodule.startLifetime = 3f;

            Debug.Log("Est� derramando �gua");


        }
        else
        {
            mainmodule.startLifetime = 0f;

            Debug.Log("N�o est� derramando �gua");
        }

        if (qtdAgua <= 0)
        {
            qtdAgua = 0;
            vazio = true;
        }
    }
}
