using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Tao dang di sang trai ne");
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Tao dang di sang phai ne");
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Tao dang di len tren ne");
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Tao dang di xuong duoi ne");
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
    }
}
