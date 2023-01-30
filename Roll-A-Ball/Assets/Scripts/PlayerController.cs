using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // physics engine?
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;

    AudioSource billiard2;

    // Start is called before the first frame update
    void Start()
    {
        billiard2 = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody>();
        winTextObject.SetActive(false);
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            billiard2.Play(); //Play it
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }



}
