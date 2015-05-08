using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour
{
    /// <summary>
    /// Forward (UP) speed.
    /// </summary>
    public float forwardSpeed = 20;

    /// <summary>
    /// Laser rigidbody.
    /// </summary>
    private Rigidbody2D Rigidbody;

    // Use this for initialization
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Rigidbody.velocity = forwardSpeed * this.transform.up;
        Invoke("DestroyAfter", 2);
    }

    /// <summary>
    /// Destroy the laser after timer.
    /// </summary>
    private void DestroyAfter()
    {
        Destroy(this.gameObject);
    }
}
