using UnityEngine;

public class MosquitoController : MonoBehaviour
{
    public float velocidade = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover até a camera do jogador
        transform.position = Vector3.MoveTowards(transform.position, Camera.main.transform.position, velocidade * Time.deltaTime);
        transform.LookAt(Camera.main.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("player tomou dano");
            Destroy(gameObject);
        }
    }
}
