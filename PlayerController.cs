﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text winText;
	private Rigidbody rb;
	private int count;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	//ควบคุมผู้เล่น
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	//เมื่อชนวัตถุ
	void OnTriggerEnter(Collider other) 
	{		
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);			
			count = count + 1;
			SetCountText ();
		}
	}

	// กำหนดเมื่อเก็บของครบ
	void SetCountText()
	{
		countText.text = "Player Score : " + count.ToString ();
		if (count >= 10) 
		{
			winText.text = "You Win!";
		}
	}
}