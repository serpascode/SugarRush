using UnityEngine;
using UnityEngine.InputSystem;

public class MovePuff : MonoBehaviour
{
    [SerializeField]
    private float speed = .06f; //Used to control speed of Puff

    [SerializeField]
    private InputActionReference move;

    [SerializeField]
    private InputActionReference jump;

    private Vector2 _moveInput;

    // Update is called once per frame
    void Update()
    {
        //updateMovement();
        _moveInput = move.action.ReadValue<Vector2>();
    }

    void updateMovement()
    {
        //float xDirection = Input.GetAxis("Horizontal");
        //float yDirection = Input.GetAxis("Vertical");

        //Vector3 moveDirection = new Vector3(xDirection, 0.0f, yDirection); // Y-Axis is up and down, testing flat movement

        //transform.position += moveDirection*speed;
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(_moveInput.x, 0.0f, _moveInput.y);

        transform.position += moveDirection * speed;
    }

    private void OnEnable()
    {
        jump.action.started += OnJump;
    }

    private void OnDisable()
    {
        jump.action.started -= OnJump;
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("We have Jumped");
    }

}
