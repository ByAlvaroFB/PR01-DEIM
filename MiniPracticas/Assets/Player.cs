using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10f;
    public float dashSpeed = 40f;

    //[SerializeField] Vector3 playerPosition = new Vector3(0, 0, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translationY = Input.GetAxis("Vertical") * speed;
        float translationZ = Input.GetAxis("Horizontal") * speed;

        translationY *= Time.deltaTime;
        translationZ *= Time.deltaTime;

        transform.Translate(0, translationY, 0);
        transform.Translate(0, 0, translationZ);


        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0, translationZ * 2);
        }

    }


}

   