using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    /// <summary>回転スピード</summary>
    [SerializeField]
    [Header("回転スピード")]
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
