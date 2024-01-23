using System.Collections.Generic;
using Fungus;
using TMPro;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    private const string Key = "DeathCount";

    [SerializeField] private int _awakeAliveCount;
    [SerializeField] private TMP_Text _finishText;
    [SerializeField] private Canvas _deathCounterCanvas;

    private List<string> _names = new List<string>() {"Kate", "Max", "Alya", "Mark", "Phill"};

    private int _deathCount;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(Key))
            _deathCount = PlayerPrefs.GetInt(Key);
    }

    public void Increase()
    {
        _deathCount++;
        PlayerPrefs.SetInt(Key, _deathCount);
    }

    public void Show()
    {
        Debug.Log("Show");
        _finishText.text = $"Живы {_awakeAliveCount - PlayerPrefs.GetInt(Key)}/{_awakeAliveCount}";
        _deathCounterCanvas.gameObject.SetActive(true);
    }

    public void Hide()
    {
        _deathCounterCanvas.gameObject.SetActive(false);
    }

    public void SetDie(Character character)
    {
        foreach (var characterName in _names)
        {
            if (characterName == character.name)
            {
                Debug.Log("SetKey");
                PlayerPrefs.SetString(characterName, "die");
                break;
            }
        }
    }

    public void SetValues(Flowchart flowchart)
    {
        Debug.Log("Init Value");
        
        foreach (var characterName in _names)
        {
            Debug.Log(characterName);
            
            if(PlayerPrefs.HasKey(characterName))
            {
                Debug.Log("Die " + characterName);
                flowchart.SetBooleanVariable(characterName,true);
            }    
        }
    }

    public void DeletePrefs()
    {
        foreach (var characterName in _names)
        {
            PlayerPrefs.DeleteKey(characterName);
        }
    }
}