using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{

    public float speed = 10f;
    public float zMax = -2.5f;
    public float xMin = 10.5f;

    private float zMin = -3.5f; // starting position
    private float xMax = 11.5f; // starting position
    private int zDirection = 1; // positive to start
    private int xDirection = -1; // negative to start

    // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }

    // Update is called once per frame
    void Update()
    {
        float zNew = transform.position.z + zDirection * speed * Time.deltaTime;
        float xNew = transform.position.x + xDirection * speed * Time.deltaTime;

        if (zNew >= zMax && xNew <= xMin)
        {
            zNew = zMax;
            zDirection *= -1;

            xNew = xMin;
            xDirection *= -1;
        }
        else if (zNew <= zMin && xNew >= xMax)
        {   
            zNew = zMin;
            zDirection *= -1;

            xNew = xMax;
            xDirection *= -1;
                    
        }
        transform.position = new Vector3(xNew, 0.75f, zNew);
    }
}
