using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform[] _floorPoints;
    [SerializeField, Range(5, 50)] float _velocity;

    GameObject _gameController;
    InputReader _inputReader;
    Rigidbody _rigidbody;


    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(new Vector3(0, -1, 1 ) * _velocity, ForceMode.Force);
        

        #region Horizontal_Move
        if (_inputReader.MoveDir < 0)//left direction 
        {
            HorizontalMove(1);
        }
        else if (_inputReader.MoveDir > 0)//right direction 
        {
            HorizontalMove(0);
        }
        #endregion
    }

    private void HorizontalMove(int direction)
    {
        if (Mathf.Abs(transform.position.x - _floorPoints[direction].position.x) < .05f)
            transform.position = new Vector3(_floorPoints[direction].position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, new Vector3(_floorPoints[direction].position.x, transform.position.y, transform.position.z), .15f);
    }
}
