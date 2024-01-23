using Fungus;
using UnityEngine;

namespace DefaultNamespace
{
    [CommandInfo("Narrative", 
        "SetDie", 
        "set die")]
    [AddComponentMenu("")]
    public class SetDie : Command
    {
        [SerializeField] private DeathCounter _deathCounter;
        [SerializeField] private Character _character;

        public override void OnEnter()
        {
            _deathCounter.SetDie(_character);
            Continue();
        }
    }
}