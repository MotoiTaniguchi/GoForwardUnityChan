using UnityEngine;
using System.Collections;

public class BlockSound : MonoBehaviour {

	public AudioClip sound;
	private AudioSource  audioSource; 


	void Start () {
		audioSource	= gameObject.AddComponent< AudioSource >();
	}

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "Block" || other.gameObject.tag == "Ground") {
			audioSource.PlayOneShot(sound);
			Debug.Log ("bang");

			}
	}
}
