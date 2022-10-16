using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    [Header("�Ǐ]�Ώ�")]
    GameObject _target;

    [SerializeField]
    [Header("�I�t�Z�b�g")]
    Vector3 _offSet;

    void Start()
    {
        _offSet = transform.position - _target.transform.position;
    }

    void Update()
    {
        transform.position = _target.transform.position + _offSet; 
    }
}
