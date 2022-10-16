using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤー")]
    GameObject _player;

	[SerializeField]
    [Header("スピード")]
    float _speed = 3f;


	float _moveX = 0f;
	float _moveZ = 0f;

	Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _moveX = Input.GetAxis("Horizontal") * _speed;
        _moveZ = Input.GetAxis("Vertical") * _speed;

        new Vector3(_moveX, 0, _moveZ);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(_moveX, 0, _moveZ);

    }
}
