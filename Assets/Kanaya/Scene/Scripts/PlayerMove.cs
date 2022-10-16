using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary></summary>
	[SerializeField]
    [Header("スピード")]
    float _speed = 3f;

    /// <summary>X座標</summary>
	float _moveX = 0f;

    /// <summary>Y座標</summary>
    float _moveZ = 0f;

	Rigidbody _rb;
    void Start() { _rb = GetComponent<Rigidbody>(); }

    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxis("Horizontal") * _speed;
        _moveZ = Input.GetAxis("Vertical") * _speed;

        new Vector3(_moveX, 0, _moveZ);
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector3(_moveX, 0, _moveZ);

    }
}
