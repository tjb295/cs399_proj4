using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    private player_move player;


    void Start()
    {
        player = FindObjectOfType<player_move>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }

    public void JumpKey()
    {
        player.jump = true;
    }

    public void ReleaseJumpKey()
    {
        player.jump = false;
    }

}
