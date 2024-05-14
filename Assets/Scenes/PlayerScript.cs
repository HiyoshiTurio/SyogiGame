using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(_ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Masu")
                {
                    Debug.Log("aaaa");
                }
            }
        }
    }
}
