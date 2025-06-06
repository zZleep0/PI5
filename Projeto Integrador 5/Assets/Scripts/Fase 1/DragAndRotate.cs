using UnityEngine;

public class DragAndRotate : MonoBehaviour
{

    public bool isActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            //MOBILE
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

            //MOUSE
            //if (Input.GetMouseButton(0)) // Bot�o esquerdo pressionado
            //{
            //    float mouseDeltaX = Input.GetAxis("Mouse X");

            //    transform.Rotate(0f, mouseDeltaX * 5f, 0f); // Multiplique para ajustar a sensibilidade

            //}
            //if (Input.GetMouseButtonUp(0)) // Soltou o bot�o do mouse
            //{
            //    isActive = false;
            //}
        }
    }
}
