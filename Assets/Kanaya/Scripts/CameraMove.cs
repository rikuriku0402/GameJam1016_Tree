using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    [Header("追従対象")]
    GameObject _target;

    [SerializeField]
    [Header("オフセット")]
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
