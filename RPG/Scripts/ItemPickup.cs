using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

	private Item item; 

	// Use this for initialization
	void Start () {
		string name = gameObject.name;
		item = new Item(
			name,
			Resources.Load<Sprite>("Icons/"+name) 
		);
				
		//Debug.Log("name - " + item.GetItemName() +", icon -" + item.GetItemIcon());
	}

	private void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(1))
		{
			//Debug.Log("Pickup: " + item.GetItemName());
			// tu wykonaj zebranie itema ze sceny
			// jeśli ma jakiegoś określonego taga
			// dla pewności loguj ten fakt

			bool picked = InventoryManager.instance.AddItem(item);
			//Debug.Log("Picked: "+picked);
			//if (picked) Destroy(gameObject); // item zebrany
			if (picked) gameObject.SetActive(false);

		}
	}

	public void PutDown() {
		GameObject player = GameObject.Find("Player");
		gameObject.transform.position = new Vector3(player.transform.position.x, gameObject.transform.position.y, player.transform.position.z);
		gameObject.SetActive(true);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
