using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masu : MonoBehaviour
{
    UInt16 _state = 0; //現在のマスの状態
    private (int, int) _masuPos;

    public (int, int) MasuPos
    {
        get => _masuPos;
        set
        {
            _masuPos = value;
        }
    }
    
    public void ChangeState(UInt16 x)
    {
        _state = x;
    }
}
