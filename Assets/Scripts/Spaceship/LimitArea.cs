using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitArea : MonoBehaviour
{
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = Camera.main;

        float objectWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        float objectHeight = GetComponent<SpriteRenderer>().bounds.extents.y;

        minX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + objectWidth;
        maxX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - objectWidth;

        minY = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + objectHeight;
        maxY = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - objectHeight;
    }

    // Update is called once per frame
    void Update()
    {
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

    }
}
