using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appletrigger : MonoBehaviour
{
    public GameObject appleswitcher;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if the player touches the item, it'll activate the "ItemGrabbed" logic in either the "appleswitch.cs"/"movementappleswitch.cs" script.
            appleswitcher.SendMessage("ItemGrabbed");
        }
}
}