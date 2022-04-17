using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
	public AudioSource odo;
	public AudioSource asrc;
	public AudioClip aclp;
	
	void Start ()
	{
		odo = GetComponent<AudioSource> ();
	}
	
	void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.tag == "gutter")
		{
			odo.Play ();
		}
	}
}
