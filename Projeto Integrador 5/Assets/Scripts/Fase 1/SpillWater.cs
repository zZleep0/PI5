using UnityEngine;

public class SpillWater : MonoBehaviour
{
    public float qtdAgua = 20f;

    public float rotacaoZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacaoZ = transform.eulerAngles.z;

        // Usa transform.eulerAngles para acessar a rota��o de Euler
        if (rotacaoZ >= 45 && rotacaoZ <= 135 || rotacaoZ <= 315 && rotacaoZ >= 225) // Ajuste do intervalo para evitar inconsist�ncias de rota��o
        {
            qtdAgua = qtdAgua - Time.deltaTime * 2;
            Debug.Log("Est� derramando �gua");
            
            
        }
        else
        {
            Debug.Log("N�o est� derramando �gua");
        }
    }
}
