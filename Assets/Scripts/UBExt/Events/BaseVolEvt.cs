using UnityEngine;
using Uniblocks;
using System.Collections;

public class BaseVolEvt :  DefaultVoxelEvents{

    public override void OnMouseDown(int mouseButton, VoxelInfo voxelInfo)
    {
        base.OnMouseDown(mouseButton, voxelInfo);
        CursorManager.Hide();
    }
}
