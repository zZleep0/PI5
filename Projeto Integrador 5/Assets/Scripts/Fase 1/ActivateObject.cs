using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //PARA MOBILE
        //if (Input.touchCount > 0)
        //{
        //    if (Input.touches[0].phase == TouchPhase.Began)
        //    {
        //        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

        //        RaycastHit hit;

        //        if (Physics.Raycast(ray, out hit))
        //        {
        //            if (hit.transform.tag == "DragAndRotate")
        //            {
        //                var objectScript = hit.collider.GetComponent<DragAndRotate>();
        //                objectScript.isActive = !objectScript.isActive;
        //            }
        //        }
        //    }
        //}

        //PC
        if (Input.GetMouseButtonDown(0)) // Clique do mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "DragAndRotate")
                {
                    var objectScript = hit.collider.GetComponent<DragAndRotate>();
                    if (objectScript != null)
                    {
                        objectScript.isActive = !objectScript.isActive;
                        Debug.Log("isActive agora é: " + objectScript.isActive);
                    }
                }
            }
        }

        
    }
}
