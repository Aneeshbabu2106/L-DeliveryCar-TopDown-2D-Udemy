using UnityEngine;

public class Car : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float steerSpeed;

    void Update()
    {
        CarMovement();
        CarSteering();
    }

    private void CarMovement()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(0,moveSpeed*verticalInput*Time.deltaTime,0);
    }

    private void CarSteering()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -steerSpeed*horizontalInput*Time.deltaTime);
    }
}
