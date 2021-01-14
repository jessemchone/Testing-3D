using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1f;

    [SerializeField] Transform _goal;

    [SerializeField] bool manualControl;

    private Rigidbody _rb;
    private float _xAxisInput;
    private float _yAxisInput;
    private bool _isMoving;
    bool isWithinMinDistance;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manualControl)
        {
            _xAxisInput = Input.GetAxis("Horizontal");
            _yAxisInput = Input.GetAxis("Vertical");

            if (_xAxisInput != 0 || _yAxisInput != 0)
            {
                _isMoving = true;
            }
            else
            {
                //_isMoving = false;
            }
        }
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            manualControl = !manualControl;
        }
    }

    private void FixedUpdate()
    {
        if (_isMoving)
        {
            // This directly sets the velocity
            //_rb.velocity = new Vector3(_xAxisInput * _moveSpeed, _rb.velocity.y, _yAxisInput * _moveSpeed);

            // Adds force
            MovePlayer(_xAxisInput, _yAxisInput);
        }

        if (!manualControl)
        {
            /*Vector3 dir = _goal.position - _rb.position;
            //Vector3 normalizedVector = dir.normalized;
            Vector3 deltaMovement = dir * _moveSpeed; // Time.deltaTime can go here or below
            Vector3 newPos = _rb.position + deltaMovement * Time.deltaTime;

            if (dir.magnitude > 1)
            {
                _rb.MovePosition(newPos);
            }*/

            MimicRBMovePosition(_rb.position, _goal.position, _moveSpeed, 1.5f);

            //MoveTowardsObject(_rb.position, _goal.position, _moveSpeed);
        }
        
        //Debug.Log(_rb.velocity);
    }

    private void MovePlayer(float xAxis, float yAxis)
    {
        _rb.AddForce(new Vector3(xAxis * _moveSpeed, _rb.velocity.y, yAxis * _moveSpeed));
    }
    
    private void MoveTowardsObject(Vector3 currentPos, Vector3 targetPos, float moveSpeed)
    {
        Vector3 newPos = Vector3.MoveTowards(currentPos, targetPos, moveSpeed * Time.deltaTime);
        _rb.MovePosition(newPos);
    }
    
    
    // This will mimic rb.MovePosition but will allow for collisions with a rigidbody
    private void MimicRBMovePosition(Vector3 currentPos, Vector3 targetPos, float forceToAdd, float minimumDistance)
    {
        Vector3 dir = targetPos - currentPos;
        Vector3 normalizeDir = dir.normalized;
        
        if (dir.magnitude > minimumDistance && !isWithinMinDistance)
        {
            // Desired velocity minus current velocity, without taking mass into consideration
            _rb.AddForce((normalizeDir * forceToAdd) - _rb.velocity, ForceMode.VelocityChange);
        }
        else
        {
            isWithinMinDistance = true;
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Ball has collided with the wall");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Ball has collided with trigger");
        }
    }
}
