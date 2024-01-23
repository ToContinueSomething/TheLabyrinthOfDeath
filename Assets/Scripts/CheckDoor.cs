using System.Collections.Generic;
using Fungus;
using UnityEngine;

namespace DefaultNamespace
{
    [CommandInfo("Narrative", 
        "CheckDoor", 
        "check door")]
    [AddComponentMenu("")]
    
    public class CheckDoor : Command
    {
        [SerializeField] private List<ConditionExpression> _conditions;
        
        public override void OnEnter()
        {
            TryOpen();
        }
                
        public bool TryOpen()
        {
            return PlayerPrefs.HasKey(Constants.KeyForMax);
        }
    }
}