using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    [CommandInfo("Narrative", 
        "Die", 
        "Writes text in a dialog box.")]
    [AddComponentMenu("")]
    public class Die : Command
    {
        [Tooltip("Character to die")]
        [SerializeField] protected List<Character> character;

        public override void OnEnter()
        {
            Debug.Log("Die");
        }
    }
}