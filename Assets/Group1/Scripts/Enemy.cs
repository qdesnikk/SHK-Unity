﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed;
    private float _moveRadius;
    private Vector3 _nextPosition;

    private void Start()
    {
        _speed = 2f;
        _moveRadius = 4f;
        _nextPosition = Random.insideUnitCircle * _moveRadius;
    }

    private void Update()
    {
        RandomMove();
    }

    private void RandomMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, _nextPosition, _speed * Time.deltaTime);

        if (transform.position == _nextPosition)
            _nextPosition = Random.insideUnitCircle * _moveRadius;
    }
}
