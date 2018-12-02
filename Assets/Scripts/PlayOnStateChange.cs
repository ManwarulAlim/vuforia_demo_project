using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnStateChange : MonoBehaviour {

	public AudioClip appearClip;
	public AudioClip disAppearClip;

	private AudioSource source;

	void Awake() {
		source = GetComponent<AudioSource>();
		source.enabled = false;
	}
	
	public void Initialize(){
		source.enabled = true;
	}

	public void PlayOnAppear(){
		source.clip = appearClip;
		source.Play();
	}

	public void PlayOnDisAppear(){
		source.clip = disAppearClip;
		source.Play();
	}

}
