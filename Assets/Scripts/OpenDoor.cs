using Fungus;
using UnityEngine;

namespace DefaultNamespace
{
    public class OpenDoor : Command
    {
        private bool _isOpenForMax;

        public override void OnEnter()
        {
            Open();
            Continue();
        }
        
        public void Open()
        {
            _isOpenForMax = true;
            PlayerPrefs.SetString(Constants.KeyForMax,_isOpenForMax.ToSerialized());
        }
    }
}