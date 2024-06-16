using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasuManager : MonoBehaviour
{
    [SerializeField] private GameObject _masuObj;
    GameObject[,] _masuArr = new GameObject[9,9];

    void Start()
    {
        InstanceMasu();
    }
    public void InstanceMasu()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var masuObj = Instantiate(_masuObj, new Vector3(i, 0, j), Quaternion.identity);
                masuObj.transform.parent = this.gameObject.transform;
                masuObj.GetComponent<Masu>().MasuPos = (i,j);
                _masuArr[i,j] = masuObj;
            }
        }
    }

    void ActiveCanMoveEffect()
    {
        
    }
}