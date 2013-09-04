using UnityEngine;
using System.Collections;
using System;
[Serializable]

public class CharacterControls : MonoBehaviour 
    

	
{
    public KeyCode MoveForward = KeyCode.W;
    public KeyCode MoveBack = KeyCode.S;
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;
}
public class CharcterMovement : MonoBehaviour 
{
    public float MoveSpeed = 5f;
    public CharacterControls controls = new CharacterControls ();
    private float trueSpeed
    {
        get { return MoveSpeed * Time.deltaTime; }
    }
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKey(controls.MoveForward))
		{
			transform.Translate(transform.forward * trueSpeed);
		}
	if (Input.GetKey(controls.MoveBack))
		{
			transform.Translate(transform.forward * trueSpeed *-1);
		}
	if (Input.GetKey(controls.MoveRight))
		{
			transform.Translate(transform.right * trueSpeed);
		}
	if (Input.GetKey(controls.MoveLeft))
		{
			transform.Translate(transform.right * trueSpeed *-1);
		}
	} 
}
