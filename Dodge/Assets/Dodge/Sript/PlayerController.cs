using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float m_speed = 25f;

    void Update()
    {
        Rigidbody rigidbody = /*gameObject*/GetComponent<Rigidbody>();

        float xAxia = Input.GetAxis("Horizontal");
        float yAxia = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector3(xAxia, 0, yAxia) * m_speed);

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += Vector3.left * m_speed * Time.deltaTime;
            rigidbody.AddForce(Vector3.left * m_speed);
        }
       else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * m_speed);
        }
       else if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * m_speed);
        }
       else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * m_speed);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
            Die();
    }

public void Die()
    {
        Debug.Log("사망");
        gameObject.SetActive(false);
    }
}
