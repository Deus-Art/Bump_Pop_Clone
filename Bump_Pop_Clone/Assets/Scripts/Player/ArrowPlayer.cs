using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlayer : MonoBehaviour
{
    public float scrollX = 0.5f;
    public float scrollY = 0.5f;

    void Update()
    {
        var offsetX = scrollX * Time.time;
        var offsetY = scrollY * Time.time;
        GetComponent<LineRenderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
