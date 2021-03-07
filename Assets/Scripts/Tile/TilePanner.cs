using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePanner
{
    public float Speed
    {
        get
        {
            return playerController.speed * speed;
        }

        set
        {
            speed = value;
        }
    }

    Vector3 movePos = Vector3.back;

    PlayerController playerController;

    float speed = 10f;

    public TilePanner(PlayerController playerController)
    {
        this.playerController = playerController;
    }

    public void Update()
    {
        for (int i = 0; i < Tile.currentTiles.Count; i++)
        {
            Tile.currentTiles[i].transform.localPosition += movePos * Speed * Time.deltaTime;
        }
    }
}
