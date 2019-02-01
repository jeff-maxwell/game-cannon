using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSmoke : MonoBehaviour
{
    public float fadeSpeed = 0f;
    public float fadeTime = 0.5f;

    private Transform connonBarrel;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        connonBarrel = transform.parent;
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {

        float fade = Mathf.SmoothDamp(spriteRenderer.color.a,
                        0f, ref fadeSpeed, fadeTime);
        spriteRenderer.color = new Color(1, 1, 1, fade);

        if (fade < 0.01f)
        {
            Destroy(this.gameObject);
        }
    }
}
