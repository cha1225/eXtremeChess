using UnityEngine;
using UnityEngine.UI;

public class Rook : BasePiece
{
    [HideInInspector]
    public Cell mCastleTriggerCell = null;
    private Cell mCastleCell = null;

    public override void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        base.Setup(newTeamColor, newSpriteColor, newPieceManager);

        mMovement = new Vector3Int(7, 7, 0);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Rook");
    }

    public override void Place(Cell newCell)
    {

    }

    public void Castle()
    {
  
    }

    private Cell SetCell(int offset)
    {
        return null;
    }
}
