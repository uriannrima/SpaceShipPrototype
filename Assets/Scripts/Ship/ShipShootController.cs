using UnityEngine;
using System.Collections;

public class ShipShootController : MonoBehaviour
{
    public GameObject LaserPrefab;

    public Transform FrontPivot;

    /// <summary>
    /// How many seconds must wait to fire another bullet.
    /// </summary>
    public float fireRate = 0.5F;

    /// <summary>
    /// Time to fire the bullet.
    /// </summary>
    private float nextFire = 0.0F;

    void Update()
    {
        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject LaserCopy = Instantiate<GameObject>(LaserPrefab);
            LaserCopy.transform.position = FrontPivot.position;
            LaserCopy.transform.rotation = this.transform.rotation;
        }
    }
}
