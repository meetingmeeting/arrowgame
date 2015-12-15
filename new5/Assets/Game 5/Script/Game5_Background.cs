using UnityEngine;
using System.Collections;

public class Game5_Background : MonoBehaviour
{
	public float scrollSpeed = 0.5F; //the speed the of the texture offset
	
    void Update()
	{
		//Make it smooth
        float offset = Time.time * scrollSpeed;
		
		//Set the texture offset
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
