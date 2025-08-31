using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class logic_script : MonoBehaviour
{
    public int score = 0;
    public Text score_text;
    public GameObject game_over_panel;

    [ContextMenu("Increase Score")]
    public void score_increas()
    {
        score++;
        score_text.text = score.ToString();
    }
    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void game_over()
    {
            game_over_panel.SetActive(true);
    }


}
