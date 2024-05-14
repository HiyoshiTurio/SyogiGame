using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasuManager : MonoBehaviour
{
    [SerializeField] GameObject _masuObj;
    GameObject[,] _masuArr = new GameObject[9,9];

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                _masuArr[i,j] = _masuObj;
            }
        }
    }
    public void InstanceMasues()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Instantiate(_masuArr[i, j], new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }
}