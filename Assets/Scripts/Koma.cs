using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Koma : MonoBehaviour
{
    [SerializeField] private int _initialXPos = -1;
    [SerializeField] private int _initialYPos = -1;
    private (int, int) _pos = (0, 0);
    private (int, int)[] _canMoveTOMasu = { (1, 1), (1, 0), (0,1), (-1,0), (0,-1), (-1,-1), (1,-1), (-1,1)};

    private void Start()
    {
        if (_initialXPos >= 0) _pos.Item1 = _initialXPos;
        if (_initialYPos >= 0) _pos.Item2 = _initialYPos;
    }

    public (int, int)[] CanMoveToMasu
    {
        get => _canMoveTOMasu;
        private set{}
    }

    public (int, int) Pos
    {
        get => _pos;
        set
        {
            if (value.Item1 < 0) value.Item1 = 0;
            if (value.Item1 > 9) value.Item1 = 9;
            if (value.Item2 < 0) value.Item2 = 0;
            if (value.Item2 > 9) value.Item2 = 9;
            _pos = value;
        }
    }
}
