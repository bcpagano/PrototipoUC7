using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Image currentHealthBar;

    private float hitpoint = 150;
    private float maxHitpoint = 150;

    public Image vida1HUD;
    public Image vida2HUD;
    public Image vida3HUD;
    public Image vida0HUD;

    public float vidas = 3;

    private void Start()
    {
        vida3HUD.enabled = true;
        UpdateHealthBar();

    }

    private void UpdateHealthBar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }

    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if (hitpoint < 0)
        {
            hitpoint = 0;
            Debug.Log("Morreu!!");
            vidas = vidas - 1;
            hitpoint = 150;
            Debug.Log(vidas);

            if (vidas == 3)
            {

                vida1HUD.enabled = false;
                vida2HUD.enabled = false;
                vida0HUD.enabled = false;

            }
            if (vidas == 2)
            {
                vida1HUD.enabled = false;
                vida2HUD.enabled = true;
                vida3HUD.enabled = false;
                vida0HUD.enabled = false;
            }
            if (vidas == 1)
            {
                vida1HUD.enabled = true;
                vida2HUD.enabled = false;
                vida3HUD.enabled = false;
                vida0HUD.enabled = false;
            }
            if (vidas == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Handheld.Vibrate();
                vida1HUD.enabled = false;
                vida2HUD.enabled = false;
                vida3HUD.enabled = false;
                vida0HUD.enabled = true;
                // ScoreTextScript.pontos = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
        UpdateHealthBar();
    }

    /*private void telavida()
    {
        if (vidas == 3)
        {
            vida1HUD.enabled = false;
            vida1HUD.enabled = false;
            vida1HUD.enabled = true;
        }
        if (vidas == 2)
        {
            vida1HUD.enabled = false;
            vida1HUD.enabled = true;
            vida1HUD.enabled = false;
        }
        if (vidas == 1)
        {
            vida1HUD.enabled = true;
            vida1HUD.enabled = false;
            vida1HUD.enabled = false;
        }
    }*/
}
