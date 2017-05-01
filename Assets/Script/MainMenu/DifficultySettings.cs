using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

//[CreateAssetMenu(fileName = "GameState", menuName = "Assets/Data", order = 1)]
[CreateAssetMenu]
public class DifficultySettings : MonoBehaviour {
    public Dropdown dropdown;
    public GameState gameState;

	// Use this for initialization
	void Start () {
        string[] enumNames = Enum.GetNames(typeof(DropdownDifficulty));
        dropdown.AddOptions(new List<string>(enumNames));
	}
	
	public void ChangeDifficultySetting()
    {
        var selectedItem = (DropdownDifficulty) dropdown.value;

        switch(selectedItem)
        {
            case DropdownDifficulty.DEFAULT:
            case DropdownDifficulty.NORMAL:
                gameState.difficulty = 6;
                break;

            case DropdownDifficulty.MEDIUM:
                gameState.difficulty = 7;
                break;

            case DropdownDifficulty.HARD:
                gameState.difficulty = 8;
                break;

            case DropdownDifficulty.INSANE:
                gameState.difficulty = 9;
                break;

            case DropdownDifficulty.IMPOSSIBLE:
                gameState.difficulty = 10;
                break;

            case DropdownDifficulty.DEV_EXIT:
                gameState.difficulty = 20;
                break;

            default:
                gameState.difficulty = 6;
                break;
        }
    }

    enum DropdownDifficulty
    {
        DEFAULT,
        NORMAL,
        MEDIUM,
        HARD,
        INSANE,
        IMPOSSIBLE,
        DEV_EXIT
    }
}
