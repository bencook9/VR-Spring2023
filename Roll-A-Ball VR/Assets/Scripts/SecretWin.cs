using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWin : MonoBehaviour
{
    public GameObject winTextObject;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 2)
        {
            winTextObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Secret"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }
}
