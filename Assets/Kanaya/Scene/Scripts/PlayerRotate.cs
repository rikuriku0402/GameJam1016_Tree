using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    /// <summary>��]�X�s�[�h</summary>
    [SerializeField]
    [Header("��]�X�s�[�h")]
    float _rotateSpeed = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0f, _rotateSpeed, 0f);
    }
}
