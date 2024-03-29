using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum eCardStateGolf
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardGolf : MonoBehaviour
{
    [Header("Set Dynamically: CardGolf")]
    public eCardStateGolf state = eCardStateGolf.drawpile;
    public List<CardGolf> hiddenBy = new List<CardGolf>();
    public int layoutID;
    public SlotDef slotDef;

    // Additional properties specific to Golf Solitaire can be added here

    // This method can be extended or overridden to include specific behavior for Golf Solitaire
    public virtual void OnMouseUpAsButton()
    {
        // Additional logic for card interaction in Golf Solitaire
    }
}
