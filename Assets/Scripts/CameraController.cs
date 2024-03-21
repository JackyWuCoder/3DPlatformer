using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private bool useOffsetValues;

    // Start is called before the first frame update
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
