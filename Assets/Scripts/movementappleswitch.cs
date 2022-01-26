using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movementappleswitch : MonoBehaviour
{
    public GameObject item; //its the object in the scene that the player picks up on contact.
    public GameObject helditem; //its the object attaches to the player once they touch the "item".
    public bool HoldingAnItem; //This bool is true when "helditem" is active.
    public GameObject textbox; //An object with the text related to the "helditem". 
    
    void Start()
    {
        //by default, only the item in the scene is active.
        item.SetActive(true);
        helditem.SetActive(false);
        textbox.SetActive(false);
        HoldingAnItem = false;

    }

    void ItemGrabbed()
    {
        //"appletrigger.cs" sets this logic off
        //this disables the item in the scene, but enables the helditem & text.
      
        item.SetActive(false);
        helditem.SetActive(true);
        textbox.SetActive(true);
        HoldingAnItem = true;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            {
            if (HoldingAnItem == true)
            {
                //if space is pressed while the helditem is active, the helditem & text are disabled. 
                //the item in the field is also re-enabled.

                item.SetActive(true);
                helditem.SetActive(false);
                textbox.SetActive(false);
                HoldingAnItem = false;
                
            }
            
            }
    }

    
}
            