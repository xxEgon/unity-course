using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour {
	private GameObject backMusic;
	private AudioClip[] shortSounds;
	// Use this for initialization
	void Start () {
		backMusic = GameObject.Find("Nordic Landscape Ambient Edit");
		shortSounds = Resources.LoadAll<AudioClip>("Sounds");
		//Debug.Log("DLUGOSC: "+shortSounds.Length);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BgMusicPlay() {
		backMusic.GetComponent<AudioSource>().Play();
	}
	public void BgMusicStop() {
		backMusic.GetComponent<AudioSource>().Stop();
	}
	public void PlayRandomSound(){
   		AudioSource.PlayClipAtPoint(shortSounds[Random.Range(0,49)], transform.position);
	}
	public void OnBgVolumeChanged(float value){
		//backMusic.GetComponent<AudioSource>().volume = value;
		AudioListener.volume = value;
	}

}
