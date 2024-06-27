/*Скрипт ведет счет очков */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score: MonoBehaviour
{
    private static int score;
    public int scoreForVictory = 1;
    public TextMeshProUGUI enimiesTX;
    public TextMeshProUGUI scoreTX;

private void Start(){

}
   private void Update()
    {
        if(score >= scoreForVictory){

            SceneManager.LoadScene(2);
        }
        enimiesTX.SetText("Враги " + scoreForVictory, enimiesTX);
        scoreTX.SetText("Счет " + score, scoreTX);

        
    }
    public static void upScore(){
        score += 1;
    }
}
