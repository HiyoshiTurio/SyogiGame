using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masu : MonoBehaviour
{
    UInt16 _state = 0; //現在のマスの状態を表す。１Pの駒、２Pの駒、何もない、など

    public void ChangeState(UInt16 x)
    {
        _state = x;
    }
}
