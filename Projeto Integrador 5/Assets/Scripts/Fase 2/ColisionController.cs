using UnityEngine;

public class ColisionController : MonoBehaviour
{
    public WinConditionFase2 winCon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Mosquito"))
        {
            Debug.Log("colidiu com mosquito");
            winCon.vida--;
            Destroy(collision.gameObject);
        }
    }
}
