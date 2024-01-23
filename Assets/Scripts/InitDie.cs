using System.Collections.Generic;
using Fungus;
using UnityEngine;

namespace DefaultNamespace
{
    [CommandInfo("Narrative", 
        "InitDie", 
        "init")]
    [AddComponentMenu("")]
    public class InitDie : Command
    {
        [SerializeField] private Flowchart _flowchart;
        [SerializeField] private DeathCounter _deathCounter;

        public override void OnEnter()
        {
            _deathCounter.SetValues(_flowchart);
            Continue();
        }
    }
}