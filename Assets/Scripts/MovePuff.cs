using UnityEngine;
using UnityEngine.InputSystem;

public class MovePuff : MonoBehaviour
{
    [SerializeField]
    private float speed = .05f; //Used to control speed of Puff

    [SerializeField]
    private InputActionReference move;

    [SerializeField]
    private InputActionReference jump;

    private Vector2 _moveInput;

    private CharacterController _characterController;
    // Jump Variables
    private Vector3 _playerVelocity;

    private bool _groundedPlayer;

    private float _jumpHeight = 5.0f;

    private bool _jumpPressed = false;

    private float _gravityValue = -9.81f;

    // Start is called before the first frame update
    void start()
    {
        _characterController = GetComponent < CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        _moveInput = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(_moveInput.x, 0.0f, _moveInput.y);
        transform.position += moveDirection * speed;
    }


    private void OnJump()
    {
        Debug.Log("We have Jumped");
        

    }
}
