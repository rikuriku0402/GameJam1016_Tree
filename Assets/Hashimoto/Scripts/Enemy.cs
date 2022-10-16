using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour,IEnemy
{
    NavMeshAgent _agent;

    [SerializeField]
    [Header("ターゲット")]
    Transform _target;

    [SerializeField]
    [Header("マイナスポイント")]
    int _minusPoint;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        _agent.destination = _target.position;


    }

    public void GetMinusPoint(int damage)
    {
        damage -= _minusPoint;
        print(damage + "くらいました");
        ScoreManager.Instance.AllScore(damage);
    }
}
