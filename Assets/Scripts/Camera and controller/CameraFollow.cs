using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform follow;
    public SpriteRenderer bounds;

    public float toleranceX = 0.01f;
    public float toleranceY = 0.01f;

    private float rightBound;
    private float leftBound;
    private float topBound;
    private float bottomBound;

    // Start is called before the first frame update
    void Start()
    {
        float camExtentV = GetComponent<Camera>().orthographicSize;
        float camExtentH = (camExtentV * Screen.width) / Screen.height;

        Bounds levelBounds = bounds.bounds;

        leftBound = levelBounds.min.x + camExtentH;
        rightBound = levelBounds.max.x - camExtentH;
        bottomBound = levelBounds.min.y + camExtentV;
        topBound = levelBounds.max.y - camExtentV;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = new Vector3();

        tmp.x = between(leftBound, follow.position.x, rightBound);
        tmp.y = between(bottomBound, follow.position.y, topBound);

        tmp.x = posWithTolerance(transform.position.x, tmp.x, toleranceX);
        tmp.y = posWithTolerance(transform.position.y, tmp.y, toleranceY);
        tmp.z = transform.position.z;

        transform.position = tmp;
    }

    private float posWithTolerance(float oldPosition, float newPosition, float tolerance)
    {
        float diff = Mathf.Abs(oldPosition - newPosition);
        return diff > tolerance ? newPosition : oldPosition;
    }

    private float between(float min, float number, float max)
    {
        return number < min ? min : (number > max ? max : number);
    }
}
