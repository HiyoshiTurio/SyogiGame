using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masu : MonoBehaviour
{
    UInt16 _state = 0; //���݂̃}�X�̏�Ԃ�\���B�PP�̋�A�QP�̋�A�����Ȃ��A�Ȃ�

    public void ChangeState(UInt16 x)
    {
        _state = x;
    }
}
