using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    Vector3 MousePositionOffset;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + MousePositionOffset;
    }

    void OnMouseDown()
    {
        MousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
        //pozycja obecna 
    }

}
