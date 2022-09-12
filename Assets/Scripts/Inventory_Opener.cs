using UnityEngine;

public class Inventory_Opener : MonoBehaviour
{
    public GameObject Inventory;

    public void OpenInventory()
    {
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			Inventory.SetActive(!Inventory.activeSelf);
		}
	}

    private void Update()
    {
        OpenInventory();
    }
}
