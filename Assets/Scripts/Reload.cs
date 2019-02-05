using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public float interFireTime = 5f;
    public GameObject cannonball;
    public GameObject smokePuff;
    public HUDScript hud = new HUDScript();

    private float timeUntilFire;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilFire = interFireTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUntilFire <= 0f && Input.GetMouseButtonDown(0))
        {
            // Reset the time until fire.
            timeUntilFire = interFireTime;

            // Create a cannonball
            GameObject ball = Instantiate(cannonball);

            // Set the cannon barrel as the parent of the cannonball
            ball.transform.parent = transform;

            // Set the sort layer
            ball.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";

            // Set the transform values of the cannonball;
            // we get these from the values in the hierarchy
            ball.transform.localPosition = new Vector3(5, 0.05f, 0);

            // Create the smoke puff.
            GameObject smoke = Instantiate(smokePuff);

            // Set the cannon barrel as the parent of the smoke puff
            smoke.transform.parent = transform;

            // Set the sort layer and the sorting order
            smoke.GetComponent<SpriteRenderer>().sortingLayerName = "Foreground";
            smoke.GetComponent<SpriteRenderer>().sortingOrder = 5;

            // Set the transform values of the smoke puff
            // we get these from the values in the hierarchy
            smoke.transform.localPosition = new Vector3(7.3f, 0, 0);
            smoke.transform.rotation = transform.rotation;

            hud.IncrementShots();
        }
        else
        {
            timeUntilFire -= Time.deltaTime;
        }
    }
}
