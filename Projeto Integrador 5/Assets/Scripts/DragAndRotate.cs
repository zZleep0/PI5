using UnityEngine;

public class DragAndRotate : MonoBehaviour
{
    public bool isActive = false;
    Color activeColor = new Color();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = activeColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            activeColor = Color.yellow;

            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, screenTouch.deltaPosition.x, 0f);
                }

                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
        else
        {
            activeColor = Color.white;
        }

        
    }
}
