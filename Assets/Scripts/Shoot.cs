using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float shotForce = 100;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private Transform cannonBarrel;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        cannonBarrel = transform.parent;
        rb.AddForce(cannonBarrel.right * shotForce);
        audioSource.Play();
        transform.parent = null;
    }

    void Update()
    {

    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
