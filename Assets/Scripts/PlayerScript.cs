using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Camera _cam;
    private GameObject SelectedKoma;
    private bool _isClickedMasu = false;
    private void Awake()
    {
        _cam = Camera.main;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(_ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Masu"))
                {
                    Debug.Log(hit.collider.gameObject.GetComponent<Masu>().MasuPos);
                }

                if (hit.collider.gameObject.tag == "Koma")
                {
                    ClickMasu(hit.collider.gameObject);
                }
            }
        }
    }

    void ClickMasu(GameObject ClickedKoma)
    {
        _isClickedMasu = true;
        SelectedKoma = ClickedKoma;
        Koma _komaSc = ClickedKoma.GetComponent<Koma>();
        int _x = _komaSc.Pos.Item1;
        int _y = _komaSc.Pos.Item2;
        for (int i = 0; i < _komaSc.CanMoveToMasu.Length; i++)
        {
            int _canX = _komaSc.CanMoveToMasu[i].Item1;
            int _canY = _komaSc.CanMoveToMasu[i].Item2;
        }
    }
}
