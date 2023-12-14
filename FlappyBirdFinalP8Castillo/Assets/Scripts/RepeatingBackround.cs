using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackround : MonoBehaviour{

    private BoxCollider2D groundCollider;
    private float groundHorizotalLenght;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizotalLenght = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizotalLenght)
        {
            RepositionBackground ();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizotalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
