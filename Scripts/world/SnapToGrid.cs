using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(Mathf.RoundToInt(transform.position.x) + 0.5f, Mathf.RoundToInt(transform.position.y) + 0.5f);
    }
}
