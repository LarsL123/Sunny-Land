using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LadderControll : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private Tilemap backgroundLayer;
    [SerializeField] private Tile ladderTile;

    public bool isOnLadder = false;
	
	
	// Update is called once per frame
	void Update () {
        Vector3Int position = new Vector3Int((int)player.position.x-1, (int)player.position.y-1,0);

        if (backgroundLayer.GetTile(position) == ladderTile)
        {
            isOnLadder = true;
            Debug.Log("climbing!");
        }
        else
        {
            isOnLadder = false;
        }

        /*
        if(backgroundLayer.GetTile(position) != null)
        {
            Debug.Log(backgroundLayer.GetTile(position).name + "position 1");
        }

        if(backgroundLayer.GetTile(position2) != null)
        {
            Debug.Log(backgroundLayer.GetTile(position2).name + "position 2");
        }

       
        Debug.Log(isOnLadder);

        */
    }
}
