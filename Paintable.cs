using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public Camera CameraInUse;
    public GameObject Brush;
    public GameObject BrushLook;
    public float BrushSize = 0.1f;
    void Update () {

        if (Input.GetMouseButton(0))
        {
            var Ray = CameraInUse.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                if (hit.collider.gameObject.name == "papir za crtasnje")
                {
                    var go = Instantiate(Brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                    go.transform.localScale = Vector3.one * BrushSize;
                    Debug.Log("Hit "+hit.collider.gameObject.name, hit.collider.gameObject);
                }
                BrushLook.transform.position = hit.point;
            }

        }
    }
}