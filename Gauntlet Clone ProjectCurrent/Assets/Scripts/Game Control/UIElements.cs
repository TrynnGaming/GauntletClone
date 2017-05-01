using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElements : MonoBehaviour {

    //UI Text Elements

    //player 1
    public Text drawTreasurePlayer1;
    public Text drawHealthPlayer1;
    public Text drawKeysPlayer1;
    public Text drawPotionsPlayer1;
    public Text player1Name;
    //player 2
    public Text drawTreasurePlayer2;
    public Text drawHealthPlayer2;
    public Text drawKeysPlayer2;
    public Text drawPotionsPlayer2;
    public Text player2Name;
    //player 3
    public Text drawTreasurePlayer3;
    public Text drawHealthPlayer3;
    public Text drawKeysPlayer3;
    public Text drawPotionsPlayer3;
    public Text player3Name;
    //player 4
    public Text drawTreasurePlayer4;
    public Text drawHealthPlayer4;
    public Text drawKeysPlayer4;
    public Text drawPotionsPlayer4;
    public Text player4Name;

    //Text Colors
    Color red = new Color(255.0f / 255.0f, 56.0f / 255.0f, 56.0f / 255.0f);
    Color gold = new Color(231.0f / 255.0f, 217.0f / 255.0f, 17.0f / 255.0f);
    Color purple =  new Color(123.0f / 255.0f, 11.0f / 255.0f, 221.0f / 255.0f);
    Color green = new Color (79.0f / 255.0f, 212.0f / 255.0f, 124.0f / 255.0f);
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void OnGUI() {

        //------------------------------------
        //DRAW UI STATS BASED ON WHAT CHARACTER EACH PLAYER IS
        //------------------------------------


        //------------
        //PLAYER 1
        //------------

        //IF PLAYER 1 NOT NULL
        if (GetComponent<GameControlScript>().player1Character == 1) //if player 1 is warrior
        {
            DrawWarriorStatsPlayer1();
        }

        if (GetComponent<GameControlScript>().player1Character == 2) //if player 1 is valkyrie
        {
            DrawValkyrieStatsPlayer1();
        }

        if (GetComponent<GameControlScript>().player1Character == 3) //if player 1 is wizard
        {
            DrawWizardStatsPlayer1();
        }

        if (GetComponent<GameControlScript>().player1Character == 4) //if player 1 is elf
        {
            DrawElfStatsPlayer1();
        }
        
        

        //------------
        //PLAYER 2
        //------------

        //IF PLAYER 2 NOT NULL
        if(GetComponent<GameControlScript>().player2)
        {
            print("player to no null");
            if (GetComponent<GameControlScript>().player2Character == 1) //if player 2 is warrior
            {
                DrawWarriorStatsPlayer2();
            }

            if (GetComponent<GameControlScript>().player2Character == 2) //if player 2 is valkyrie
            {
                DrawValkyrieStatsPlayer2();
            }

            if (GetComponent<GameControlScript>().player2Character == 3) // is player 2 is wizard
            {
                DrawWizardStatsPlayer2();
            }

            if (GetComponent<GameControlScript>().player2Character == 4) //if player 2 is elf
            {
                DrawElfStatsPlayer2();
            }
        }

        //ELSE
        else 
        {
            //set all player 2 values to null
            player2Name.text = null;
            drawHealthPlayer2.text = null;
            drawTreasurePlayer2.text = null;
            drawKeysPlayer2.text = null;
            drawPotionsPlayer2.text = null;
        }
        


        //------------
        //PLAYER 3
        //------------

        //IF PLAYER 3 IS NOT NULL
        if(GetComponent<GameControlScript>().player3)
        {
            if (GetComponent<GameControlScript>().player3Character == 1) //if player 3 is warrior
            {
                DrawWarriorStatsPlayer3();
            }

            if (GetComponent<GameControlScript>().player3Character == 2) //if player 3 is valkyrie
            {
                DrawValkyrieStatsPlayer3();
            }

            if (GetComponent<GameControlScript>().player3Character == 3) //if player 3 is wizard
            {
                DrawWizardStatsPlayer3();
            }

            if (GetComponent<GameControlScript>().player3Character == 4) //if player 3 is elf
            {
                DrawElfStatsPlayer3();
            }
        }
        //ELSE
        else
        {
            //set all player 3 values to null
            player3Name.text = null;
            drawHealthPlayer3.text = null;
            drawTreasurePlayer3.text = null;
            drawKeysPlayer3.text = null;
            drawPotionsPlayer3.text = null;
        }

        //------------
        //PLAYER 4
        //------------

        //IF PLAYER 4 IS NOT NULL
        if(GetComponent<GameControlScript>().player4)
        {
            if (GetComponent<GameControlScript>().player4Character == 1)//if player 4 is warrior
            {
                DrawWarriorStatsPlayer4();
            }

            if (GetComponent<GameControlScript>().player4Character == 2)//if player 4 is valkrie
            {
                DrawValkyrieStatsPlayer4();
            }

            if (GetComponent<GameControlScript>().player4Character == 3)//if player 4 is wizard
            {
                DrawWizardStatsPlayer4();
            }

            if (GetComponent<GameControlScript>().player4Character == 4)// if player 4 is elf
            {
                DrawElfStatsPlayer4();
            }
        }
        //ELSE
        else
        {
            //set all player 4 values to null
            player4Name.text = null;
            drawHealthPlayer4.text = null;
            drawTreasurePlayer4.text = null;
            drawKeysPlayer4.text = null;
            drawPotionsPlayer4.text = null;
        }
    }


    //----------------------------------
    //PLAYER 1 STATS FOR UI
    //----------------------------------

    void DrawWarriorStatsPlayer1()
    {
        player1Name.color = red; 
        player1Name.text = "Warrior";
        drawHealthPlayer1.text = "Health:" + GetComponent<GameControlScript>().warrior.health.ToString();
        drawTreasurePlayer1.text = "Treasure:" + GetComponent<GameControlScript>().warrior.treasureScore.ToString();
        drawKeysPlayer1.text = "Keys:" + GetComponent<GameControlScript>().warrior.keyCount.ToString();
        drawPotionsPlayer1.text = "Potions:" + GetComponent<GameControlScript>().warrior.potionCount.ToString();
    }


    void DrawValkyrieStatsPlayer1()
    {
        player1Name.color = gold;
        player1Name.text = "Valkyrie";
        drawHealthPlayer1.text = "Health:" + GetComponent<GameControlScript>().valkyrie.health.ToString();
        drawTreasurePlayer1.text = "Treasure:" + GetComponent<GameControlScript>().valkyrie.treasureScore.ToString();
        drawKeysPlayer1.text = "Keys:" + GetComponent<GameControlScript>().valkyrie.keyCount.ToString();
        drawPotionsPlayer1.text = "Potions:" + GetComponent<GameControlScript>().valkyrie.potionCount.ToString();
    }

    void DrawWizardStatsPlayer1()
    {
        player1Name.color = purple;
        player1Name.text = "Wizard";
        drawHealthPlayer1.text = "Health:" + GetComponent<GameControlScript>().wizard.health.ToString();
        drawTreasurePlayer1.text = "Treasure:" + GetComponent<GameControlScript>().wizard.treasureScore.ToString();
        drawKeysPlayer1.text = "Keys:" + GetComponent<GameControlScript>().wizard.keyCount.ToString();
        drawPotionsPlayer1.text = "Potions:" + GetComponent<GameControlScript>().wizard.potionCount.ToString();
    }

    void DrawElfStatsPlayer1()
    {
        player1Name.color = green;
        player1Name.text = "Elf";
        drawHealthPlayer1.text = "Health:" + GetComponent<GameControlScript>().elf.health.ToString();
        drawTreasurePlayer1.text = "Treasure:" + GetComponent<GameControlScript>().elf.treasureScore.ToString();
        drawKeysPlayer1.text = "Keys:" + GetComponent<GameControlScript>().elf.keyCount.ToString();
        drawPotionsPlayer1.text = "Potions:" + GetComponent<GameControlScript>().elf.potionCount.ToString();
    }


    //----------------------------------
    //PLAYER 2 STATS FOR UI
    //----------------------------------
    void DrawWarriorStatsPlayer2()
    {
        player2Name.color = red;
        player2Name.text = "Warrior";
        drawHealthPlayer2.text = "Health:" + GetComponent<GameControlScript>().warrior.health.ToString();
        drawTreasurePlayer2.text = "Treasure:" + GetComponent<GameControlScript>().warrior.treasureScore.ToString();
        drawKeysPlayer2.text = "Keys:" + GetComponent<GameControlScript>().warrior.keyCount.ToString();
        drawPotionsPlayer2.text = "Potions:" + GetComponent<GameControlScript>().warrior.potionCount.ToString();
    }


    void DrawValkyrieStatsPlayer2()
    {
        player2Name.color = gold;
        player2Name.text = "Valkyrie";
        drawHealthPlayer2.text = "Health:" + GetComponent<GameControlScript>().valkyrie.health.ToString();
        drawTreasurePlayer2.text = "Treasure:" + GetComponent<GameControlScript>().valkyrie.treasureScore.ToString();
        drawKeysPlayer2.text = "Keys:" + GetComponent<GameControlScript>().valkyrie.keyCount.ToString();
        drawPotionsPlayer2.text = "Potions:" + GetComponent<GameControlScript>().valkyrie.potionCount.ToString();
    }

    void DrawWizardStatsPlayer2()
    {
        player2Name.color = purple;
        player1Name.text = "Wizard";
        drawHealthPlayer2.text = "Health:" + GetComponent<GameControlScript>().wizard.health.ToString();
        drawTreasurePlayer2.text = "Treasure:" + GetComponent<GameControlScript>().wizard.treasureScore.ToString();
        drawKeysPlayer2.text = "Keys:" + GetComponent<GameControlScript>().wizard.keyCount.ToString();
        drawPotionsPlayer2.text = "Potions:" + GetComponent<GameControlScript>().wizard.potionCount.ToString();
    }

    void DrawElfStatsPlayer2()
    {
        player2Name.color = green;
        player1Name.text = "Elf";
        drawHealthPlayer2.text = "Health:" + GetComponent<GameControlScript>().elf.health.ToString();
        drawTreasurePlayer2.text = "Treasure:" + GetComponent<GameControlScript>().elf.treasureScore.ToString();
        drawKeysPlayer2.text = "Keys:" + GetComponent<GameControlScript>().elf.keyCount.ToString();
        drawPotionsPlayer2.text = "Potions:" + GetComponent<GameControlScript>().elf.potionCount.ToString();
    }




    //----------------------------------
    //PLAYER 3 STATS FOR UI
    //----------------------------------
    void DrawWarriorStatsPlayer3()
    {
        player3Name.color = red;
        player3Name.text = "Warrior";
        drawHealthPlayer3.text = "Health:" + GetComponent<GameControlScript>().warrior.health.ToString();
        drawTreasurePlayer3.text = "Treasure:" + GetComponent<GameControlScript>().warrior.treasureScore.ToString();
        drawKeysPlayer3.text = "Keys:" + GetComponent<GameControlScript>().warrior.keyCount.ToString();
        drawPotionsPlayer3.text = "Potions:" + GetComponent<GameControlScript>().warrior.potionCount.ToString();
    }


    void DrawValkyrieStatsPlayer3()
    {
        player3Name.color = gold;
        player3Name.text = "Valkyrie";
        drawHealthPlayer3.text = "Health:" + GetComponent<GameControlScript>().valkyrie.health.ToString();
        drawTreasurePlayer3.text = "Treasure:" + GetComponent<GameControlScript>().valkyrie.treasureScore.ToString();
        drawKeysPlayer3.text = "Keys:" + GetComponent<GameControlScript>().valkyrie.keyCount.ToString();
        drawPotionsPlayer3.text = "Potions:" + GetComponent<GameControlScript>().valkyrie.potionCount.ToString();
    }

    void DrawWizardStatsPlayer3()
    {
        player3Name.color = purple;
        player3Name.text = "Wizard";
        drawHealthPlayer3.text = "Health:" + GetComponent<GameControlScript>().wizard.health.ToString();
        drawTreasurePlayer3.text = "Treasure:" + GetComponent<GameControlScript>().wizard.treasureScore.ToString();
        drawKeysPlayer3.text = "Keys:" + GetComponent<GameControlScript>().wizard.keyCount.ToString();
        drawPotionsPlayer3.text = "Potions:" + GetComponent<GameControlScript>().wizard.potionCount.ToString();
    }

    void DrawElfStatsPlayer3()
    {
        player3Name.color = green;
        player3Name.text = "Elf";
        drawHealthPlayer3.text = "Health:" + GetComponent<GameControlScript>().elf.health.ToString();
        drawTreasurePlayer3.text = "Treasure:" + GetComponent<GameControlScript>().elf.treasureScore.ToString();
        drawKeysPlayer3.text = "Keys:" + GetComponent<GameControlScript>().elf.keyCount.ToString();
        drawPotionsPlayer3.text = "Potions:" + GetComponent<GameControlScript>().elf.potionCount.ToString();
    }




    //----------------------------------
    //PLAYER 4 STATS FOR UI
    //----------------------------------
    void DrawWarriorStatsPlayer4()
    {
        player4Name.color = red;
        player4Name.text = "Warrior";
        drawHealthPlayer4.text = "Health:" + GetComponent<GameControlScript>().warrior.health.ToString();
        drawTreasurePlayer4.text = "Treasure:" + GetComponent<GameControlScript>().warrior.treasureScore.ToString();
        drawKeysPlayer4.text = "Keys:" + GetComponent<GameControlScript>().warrior.keyCount.ToString();
        drawPotionsPlayer4.text = "Potions:" + GetComponent<GameControlScript>().warrior.potionCount.ToString();
    }


    void DrawValkyrieStatsPlayer4()
    {
        player4Name.color = gold;
        player4Name.text = "Valkyrie";
        drawHealthPlayer4.text = "Health:" + GetComponent<GameControlScript>().valkyrie.health.ToString();
        drawTreasurePlayer4.text = "Treasure:" + GetComponent<GameControlScript>().valkyrie.treasureScore.ToString();
        drawKeysPlayer4.text = "Keys:" + GetComponent<GameControlScript>().valkyrie.keyCount.ToString();
        drawPotionsPlayer4.text = "Potions:" + GetComponent<GameControlScript>().valkyrie.potionCount.ToString();
    }

    void DrawWizardStatsPlayer4()
    {
        player4Name.color = purple;
        player4Name.text = "Wizard";
        drawHealthPlayer4.text = "Health:" + GetComponent<GameControlScript>().wizard.health.ToString();
        drawTreasurePlayer4.text = "Treasure:" + GetComponent<GameControlScript>().wizard.treasureScore.ToString();
        drawKeysPlayer4.text = "Keys:" + GetComponent<GameControlScript>().wizard.keyCount.ToString();
        drawPotionsPlayer4.text = "Potions:" + GetComponent<GameControlScript>().wizard.potionCount.ToString();
    }

    void DrawElfStatsPlayer4()
    {
        player4Name.color = green;
        player4Name.text = "Elf";
        drawHealthPlayer4.text = "Health:" + GetComponent<GameControlScript>().elf.health.ToString();
        drawTreasurePlayer4.text = "Treasure:" + GetComponent<GameControlScript>().elf.treasureScore.ToString();
        drawKeysPlayer4.text = "Keys:" + GetComponent<GameControlScript>().elf.keyCount.ToString();
        drawPotionsPlayer4.text = "Potions:" + GetComponent<GameControlScript>().elf.potionCount.ToString();
    }
}
