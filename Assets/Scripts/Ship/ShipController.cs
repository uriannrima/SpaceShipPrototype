using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour
{
    /// <summary>
    /// Ship rigidbody.
    /// </summary>
    private Rigidbody2D Rigidbody;

    /// <summary>
    /// Turn aroud speed of the ship.
    /// </summary>
    public float turnSpeed = 2f;

    /// <summary>
    /// Forward (UP) speed.
    /// </summary>
    public float forwardSpeed = 2f;

    /// <summary>
    /// How much it should thurst per time.
    /// </summary>
    public float thrustPower = 1f;

    // Use this for initialization
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetAxis();
    }

    /// <summary>
    /// Horizontal (X) and Vertical (Y) Input axis.
    /// </summary>
    Vector2 axis = Vector2.zero;

    /// <summary>
    /// Get input axis.
    /// </summary>
    private void GetAxis()
    {
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
    }

    /// <summary>
    /// Physical update.
    /// </summary>
    void FixedUpdate()
    {
        HandleTurn();
        HandleMovement();
    }

    /// <summary>
    /// Turn ship around axis value.
    /// </summary>
    private void HandleTurn()
    {
        // Rotate the ship
        this.transform.Rotate(0, 0, -axis.x * turnSpeed * Time.deltaTime * 100);
    }

    /// <summary>
    /// Move ship using axis.
    /// </summary>
    void HandleMovement()
    {
        // Move forward.
        if (axis.y != 0)
        {
            forwardSpeed += axis.y * thrustPower * Time.deltaTime;
            forwardSpeed = Mathf.Clamp(forwardSpeed, -1f, 7f);
        }

        Rigidbody.velocity = forwardSpeed * this.transform.up;
    }
}
