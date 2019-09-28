using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    private Animator animator;
    public bool cha = false;
    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
    }
	 
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //cha = true;
            //con.SetBool("cha", cha);
            //con.setclip("idle");
            /*foreach (AnimationState state in animation)
            {
                //Debug.Log(state.clip.name);
                Debug.Log("Idle");
            }*/
            Debug.Log("Jump");
            transform.Translate(new Vector3(1, 1, 0) * Time.deltaTime * 0.5f);

            cha = true;
            animator.SetBool("cha", cha);
        }
    }
}
