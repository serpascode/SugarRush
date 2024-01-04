using UnityEngine;

public class MovePuff : MonoBehaviour
{
    public float speed = .06f; //Used to control speed of Puff

    // Update is called once per frame
    void Update()
    {
        updateMovement();
    }

    void updateMovement()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, yDirection); // Y-Axis is up and down, testing flat movement

        transform.position += moveDirection*speed;
    }
}
