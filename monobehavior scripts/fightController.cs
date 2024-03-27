using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fightController : MonoBehaviour
{
    public GameObject hero_GO, monster_GO;
    public TextMeshPro hero_hp_TMP, monster_hp_TMP;

    // Start is called before the first frame update
    void Start()
    {
        this.hero_hp_TMP.text = "Boo!!!";
    }

    protected void attackTurn
    {
        protected bool currentTurn = true;
        while(playerHP & monsterHP != 0)
        {
            if(currentTurn == true )
            {
                int random = Range(1, 20);
                monsterHP = monsterHP - random;
                currentTurn = false;
            }
            else if(currentTurn == false)
            {
                int random = Range(1, 20);
                if(random >= armorClass)
                {
                    playerHP = playerHP - random;
                    currentTurn = true;
                }
            }
        }
        if(playerHP == 0)
        {
            print("You died!")
        }
        else if(monsterHP == 0)
        {
            print("You win!")
        }
        
    }

    // Update is called once per frame
    void Update()
    {
   =
    }
}
