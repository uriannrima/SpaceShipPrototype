using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour
{
    public GameObject LaserPrefab;

    /// <summary>
    /// Turn aroud speed of the ship.
    /// </summary>
    public float turnSpeed = 2;

    /// <summary>
    /// Forward (UP) speed.
    /// </summary>
    public float forwardSpeed = 2;

    /// <summary>
    /// How much it should thurst per time.
    /// </summary>
    public float thrustPower = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleAxis();
        HandleButtons();
    }

    private void HandleButtons()
    {
        HandleShooting();
    }

    private void HandleShooting()
    {
        if (Input.GetButton("Fire1"))
        {
            //GameObject LaserCopy = Instantiate<GameObject>(LaserPrefab);
        }
    }

    /// <summary>
    /// Horizontal (X) and Vertical (Y) Input axis.
    /// </summary>
    Vector2 axis = Vector2.zero;

    private void HandleAxis()
    {
        axis.x = Input.GetAxis("Horizontal");
        axis.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        HandleTurn();
        HandleThrust();
    }

    private void HandleThrust()
    {
        forwardSpeed += axis.y * thrustPower * Time.deltaTime;
        forwardSpeed = Mathf.Clamp(forwardSpeed, 0f, 7f);
        this.transform.Translate(Vector3.up * forwardSpeed * Time.deltaTime);
    }

    private void HandleTurn()
    {
        this.transform.Rotate(0, 0, -axis.x * turnSpeed * Time.deltaTime * 100);
    }
}
