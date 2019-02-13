using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour {

	public static EquipmentManager instance;
	private List<Item> itemsList = new List<Item>();

	private PlayerManager playerManager; 

	private void Awake()
    {
        /* singleton */
        if (instance != null)
        {
             Debug.LogError("Istnieje już instancja tej klasy: " + EquipmentManager.instance);
            return;
        }
        instance = this;
    }

	public void EquipPlayer(Item item){

		//dodaj item do listy ekwipunku
		itemsList.Add(item);

		playerManager.ShowPlayerMesh(item.GetItemName(), true);
		
		
		// pokaż odpowiedni mesh w modelu playera
		// czyli wywołaj funkcję publiczną np ShowPlayerMesh() w klasie PlayerManager
		// zarządzającej poruszaniem playera

	}

	public void UnequipPlayer(Item item)
	{
		//usuwaj item z listy equipunku
		itemsList.Remove(item);

		InventoryManager.instance.AddItem(item);

		//przywróć item do listy inventory
		// czyli wywołaj funkcję AddItem z klasy InventoryManager

	}

	public void UnequipAll()
	{
		int il= itemsList.Count;
		for(int i=0; i< il; i++) {
			UnequipPlayer(itemsList[0]);
		}
		// w tej funkcji wywołaj w pęli for funkcję UnequipPlayer
		// dla każdego elementu listy ekwipunku

		// wyczyśc listę ekwipunku
		GameObject.Find("Player").GetComponent<PlayerManager>().ShowAllPlayerMeshes(false);
		//wywołaj funkcję ukrywającą meshe w modelu playera np ShowAllPlayerMeshes()
		// ta funkcja powinna być napisana w klasie PlayerManagement

	}


	// Use this for initialization
	void Start () {
		playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("u")){
			UnequipAll();
		}
	}
}
