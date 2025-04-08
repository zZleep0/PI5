using UnityEngine;

public class CameraProvisoria : MonoBehaviour
{
    public float sensibilidade = 0.2f;

    private float rotX = 0f;
    private float rotY = 0f;

    private Vector2 lastTouchPos;
    private bool isDragging = false;
    private bool touchedObject = false;

    void Start()
    {
        // Começa com a rotação atual da câmera
        Vector3 rot = transform.localRotation.eulerAngles;
        rotX = rot.y;
        rotY = rot.x;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchedObject = false; // Resetamos no começo do toque

                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.CompareTag("DragAndRotate"))
                    {
                        var objectScript = hit.collider.GetComponent<DragAndRotate>();
                        objectScript.isActive = !objectScript.isActive;

                        touchedObject = true; // MARCA que tocou num objeto interativo
                    }
                }

                if (!touchedObject)
                {
                    lastTouchPos = touch.position;
                    isDragging = true;
                }
            }
            else if (touch.phase == TouchPhase.Moved && isDragging && !touchedObject)
            {
                Vector2 delta = touch.deltaPosition;

                rotX += delta.x * sensibilidade;
                rotY -= delta.y * sensibilidade;
                rotY = Mathf.Clamp(rotY, -90f, 90f);

                Quaternion localRotation = Quaternion.Euler(rotY, rotX, 0f);
                transform.rotation = localRotation;
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isDragging = false;
                touchedObject = false;
            }
        }
    }
}

