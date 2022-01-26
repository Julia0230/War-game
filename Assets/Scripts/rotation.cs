using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Set object's rotation to zero when the game loads.
        transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    }

    void OnEnable()
    {
        //Set object's rotation to zero every time the object loads.
        transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    }
    void Update()
    {
        //Gradually change object's rotation when a direction is pressed.
        if(Input.GetKey(KeyCode.UpArrow))
        {transform.Rotate(0.6f, 0.0f, 0.0f);}

        if(Input.GetKey(KeyCode.DownArrow))
        {transform.Rotate(-0.6f, 0.0f, 0.0f);}

        if(Input.GetKey(KeyCode.LeftArrow))
        {transform.Rotate(0.0f, 0.0f, 0.6f);}

        if(Input.GetKey(KeyCode.RightArrow))
        {transform.Rotate(0.0f, 0.0f, -0.6f);}

    }
}
