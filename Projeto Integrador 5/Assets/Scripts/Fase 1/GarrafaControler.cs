using UnityEngine;

public class GarrafaControler : MonoBehaviour
{
    public float rotacaoMin = 0f;
    public float rotacaoMax = 0f;

    public float qtdAgua = 20f;
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
        rotacaoX = transform.eulerAngles.x; // Usa transform.eulerAngles para acessar a rotação de Euler

        var mainmodule = aguaParticula.main;

        if (rotacaoX >= rotacaoMin && rotacaoX <= rotacaoMax && qtdAgua > 0) // Ajuste do intervalo para evitar inconsistências de rotação
        {
            qtdAgua = qtdAgua - Time.deltaTime * 2;

            mainmodule.startLifetime = 3f;

            Debug.Log("Está derramando água");
        }
        else
        {
            mainmodule.startLifetime = 0f;
            
            Debug.Log("Não está derramando água");
        }

        if (qtdAgua <= 0)
        {
            qtdAgua = 0;
            vazio = true;
        }
    }
}
