using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// マイナスポイント
    /// </summary>
    int _minusPoint;

    /// <summary>X座標</summary>
	float _moveX = 0f;

    /// <summary>Y座標</summary>
    float _moveZ = 0f;

    Vector3 _mouse;

    Vector3 _target;

    /// <summary>スピード</summary>
	[SerializeField]
    [Header("スピード")]
    float _speed = 3f;


	Rigidbody _rb;
    void Start() => _rb = GetComponent<Rigidbody>();

    void Update()
    {
        _moveX = Input.GetAxis("Horizontal") * _speed;
        _moveZ = Input.GetAxis("Vertical") * _speed;

        new Vector3(_moveX, 0, _moveZ);

        _mouse = Input.mousePosition;
        _target = Camera.main.ScreenToWorldPoint(new Vector3(_mouse.x, _mouse.y, 10));
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector3(_moveX, 0, _moveZ);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ITree tree))
        {
            tree.TreeCut(other.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Cut);
        }
        PlayerPrefs.SetInt("SCORE", ScoreManager.Instance.AllScorePoint);
        PlayerPrefs.Save();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IEnemy enemy))
        {
            enemy.GetMinusPoint(_minusPoint);
            Destroy(collision.gameObject);
            SoundManager.Instance.PlaySFX(SFXType.Death);
        }
    }
}
