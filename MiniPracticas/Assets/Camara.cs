using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = playerPosition.TransformPoint(new Vector3(-6, 2, 0));

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        
    }
}
