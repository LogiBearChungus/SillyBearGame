using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 15f;
    public float projectileRange = 10f;
    public float projectileFalloff = 1f;
    public float minVelocityThreshold = 0.1f; // Add this threshold
    private Vector3 startPosition;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        rb.velocity = transform.up * projectileSpeed;
    }

    void Update()
    {
        if (projectileFalloff > 0)
        {
            rb.velocity *= (1 - projectileFalloff * Time.deltaTime);
        }

        // Use magnitude to check if velocity is below threshold
        if (Vector3.Distance(startPosition, transform.position) >= projectileRange ||
            rb.velocity.magnitude < minVelocityThreshold)
        {
            Destroy(gameObject);
        }
    }
}