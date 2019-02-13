using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {
	private Sprite spriteAudioON, spriteAudioON_h, spriteAudioOFF, spriteAudioOFF_h;
	private Component[] buttons; // tablica wszystkich komponentów
	private SpriteState spriteState = new SpriteState();
	private bool AudioIsON;
	private Slider slider;
	private Dropdown dropdown;
	private Toggle toggle_fullscreen;
	private List<string> listRes;
	// Use this for initialization
	void Start () {
		spriteAudioON = Resources.Load<Sprite>("Sprites/btn_audio_on") ;
		spriteAudioON_h = Resources.Load<Sprite>("Sprites/btn_audio_on_h") ;
		spriteAudioOFF = Resources.Load<Sprite>("Sprites/btn_audio_off") ;
		spriteAudioOFF_h = Resources.Load<Sprite>("Sprites/btn_audio_off_h") ;
		AudioIsON = true;
		listRes = new List<string>{};

		//gameObject.Find("Name").GetComponent()
		buttons = GetComponentsInChildren(typeof(Button)); // szukam tylko butonów
		//Debug.Log(buttons.Length); // liczba butonow
		//(buttons[1] as Button).onClick.AddListener(KlikButton1);
		// foreach (Button button in buttons)
		// {
		// 	button.onClick.AddListener(KlikButton1);
		// }
		foreach (Button button in buttons)
		{
			button.onClick.AddListener(() => KlikButton2(button));
		}

		slider = GetComponentInChildren(typeof(Slider)) as Slider;
		slider.onValueChanged.AddListener( GameObject.Find("Sounds").GetComponent<SoundManager>().OnBgVolumeChanged );

		dropdown = GetComponentInChildren(typeof(Dropdown)) as Dropdown;
		dropdown.ClearOptions();
		listRes.Add("Default");
		foreach( Resolution x in Screen.resolutions) {
			listRes.Add(x.ToString());
		}
		dropdown.AddOptions(listRes);
		dropdown.onValueChanged.AddListener(SetResolution);
		// Debug.Log(Screen.resolutions);
		// Debug.Log(Screen.resolutions.Length);
		// Debug.Log(Screen.resolutions[0].width);
		// Debug.Log(Screen.resolutions[0].height);
		// Debug.Log(Screen.currentResolution.width);

		toggle_fullscreen = GetComponentInChildren(typeof(Toggle)) as Toggle;
		toggle_fullscreen.onValueChanged.AddListener(SetFullscreen);

	}
	private void SetFullscreen(bool value)
	{
		Debug.Log(value);
		Screen.fullScreen = value;
	}
	private void SetResolution(int index)
	{
		//Debug.Log(index);
		Screen.SetResolution(Screen.resolutions[index-1].width, Screen.resolutions[index-1].height, false);
	}
	
	public void KlikButton2(Button b)
	{
		//Debug.Log(b.name);
		switch(b.name){
		    case "btn1":
				Debug.Log("LEVEL1");
				SceneManager.LoadScene("scene1", LoadSceneMode.Single); 
				break;
			case "btn2":
				Debug.Log("LEVEL2");
				SceneManager.LoadScene("scene2", LoadSceneMode.Single); 
				break;
			case "btn3":
				Image img = b.GetComponent<Image>();
				Button bt = b.GetComponent<Button>();
				spriteState = bt.spriteState;
				if (AudioIsON){
					Debug.Log("MUSIC OFF");
					img.sprite = spriteAudioOFF;						
					spriteState.highlightedSprite = spriteAudioOFF_h;
					spriteState.pressedSprite = spriteAudioOFF;

					GameObject.Find("Sounds").GetComponent<SoundManager>().BgMusicStop();
					//MenuManager.BgMusicStop();
					//GameObject.Find("Nordic Landscape Ambient Edit").GetComponent<AudioSource>().Stop();				
				}
				else{
					Debug.Log("MUSIC ON");
					img.sprite = spriteAudioON;						
					spriteState.highlightedSprite = spriteAudioON_h;
					spriteState.pressedSprite = spriteAudioON;
					
					GameObject.Find("Sounds").GetComponent<SoundManager>().BgMusicPlay();
					//MenuManager.BgMusicPlay();
					//GameObject.Find("Nordic Landscape Ambient Edit").GetComponent<AudioSource>().Play();					
				}
				EventSystem.current.SetSelectedGameObject(null);
				AudioIsON=!AudioIsON;	
				bt.spriteState = spriteState; 
				break;
			case "btn4":
				Debug.Log("EXIT");
				Application.Quit();
				break;
		}
		
			
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyUp(KeyCode.Escape)) {
			gameObject.GetComponent<Canvas>().enabled = !gameObject.GetComponent<Canvas>().enabled;
		}
			
	}
}
