using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour
{
    /// <summary>
    /// Forward (UP) speed.
    /// </summary>
    public float forwardSpeed = 2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector3.up * forwardSpeed * Time.deltaTime);
    }
}
