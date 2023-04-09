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
        _gameController = GameObject.FindGameObjectWithTag("GameController");
        _inputReader = _gameController.GetComponent<InputReader>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
    }

    void Update()
    {
        _rigidbody.velocity = Vector3.forward * _velocity;

        print(_rigidbody.velocity);
    }
    private void FixedUpdate()
    {
        //_rigidbody.AddForce(Vector3.forward * _velocity * Time.fixedDeltaTime, ForceMode.Impulse);


        if (_inputReader.MoveDir < 0)//left direction 
        {
            HorizontalMove(1);
        }
        else if (_inputReader.MoveDir > 0)
        {
            HorizontalMove(0);
        }
    }

    private void HorizontalMove(int dir)
    {
        if (Mathf.Abs(transform.position.x - _floorPoints[dir].position.x) < .05f)
            transform.position = new Vector3(_floorPoints[dir].position.x, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, new Vector3(_floorPoints[dir].position.x, transform.position.y, transform.position.z), .2f);
    }
}
