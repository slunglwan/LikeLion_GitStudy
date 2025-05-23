using UnityEngine;

public class Study_Math : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float degree = 180f;
        float rad = degree * Mathf.Deg2Rad;

        Debug.Log(rad);
    }
}
