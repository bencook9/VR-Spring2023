using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacer_circle : MonoBehaviour
{
    private float Rotation = 0;
    private float speed = 5;

    // Start is called before the first frame update
void Start()
{

}

    // Update is called once per frame
void Update()
{
    if(Rotation == 360)
    {
        Rotation = 0;
    }
    Rotation = Rotation + 150 * Time.deltaTime;
    gameObject.transform.rotation = Quaternion.Euler(0, 0, Rotation);
    gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
}

}