using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    private void OnCollissionEnter(Collision collision)
    { 
         if(collision.gameObject.tag == "Enemy")
         {
            Destroy(collision.gameObject);


            /*public void NextScene()
            {
                SceneManager.LoadScene("GameOver");
            }
            */
        }
    }

    // Start is called before the first frame update

    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector3.up * 500);
            rb.AddForce(Vector3.right * 150);
        }
        
        //rb.velocity = Vector3.right * 4f;
    } 
    
}