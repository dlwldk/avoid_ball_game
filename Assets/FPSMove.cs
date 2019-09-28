using UnityEngine;
using System.Collections;

public class FPSMove : MonoBehaviour {
    public float speed = 6;
    public float jump = 8, aim=8;
    public float gravity = 20;
    Vector3 move = Vector3.zero;
    public int ColCount = 0;

    public bool groundedComputed = false;
    public float groundY;
    CharacterController con;


    // Use this for initialization
    void Start() {
        con = GetComponent<CharacterController>();
        Debug.Log("FPSMove start");

    }

    // Update is called once per frame
    void Update() {

        //if( con.isGrounded) //temporarily disabled
        {

            move = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            move *= speed;
            if (Input.GetButton("Jump")) {
                move.y = jump;
            }
           

            Debug.Log("Grounded...");

            //Vector3 position = transform.position;
            //groundY = position.y;
            //groundedComputed = true;

        }

        move.y -= gravity * Time.deltaTime;
        con.Move(move * Time.deltaTime);

        //print for debugging
        Debug.Log("move=" + move.x + "," + move.y + "," + move.z);
        Vector3 newPosition = transform.position;
        Debug.Log("pos=" + newPosition.x + "," + newPosition.y + "," + newPosition.z);



    }
    void OnTriggerEnter(Collider other) //충돌 시
    {
        if (other.transform.tag == "Enemy")
        {
            ColCount++;
            if (ColCount >= 3)
            {
                //Application.Quit();
                Destroy(other);
                ColCount = 0;
            }
        }
        else if (other.transform.tag == "heart") //heart에 도착 시
        {
            Destroy(other);
        }
    }
 
}




