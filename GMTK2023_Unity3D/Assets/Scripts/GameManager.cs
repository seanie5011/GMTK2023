using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    private int scoreTracker = 0;

    public HumanAnimation humanAnimation;
    public BowAnimator bowAnimator;
    public ArrowSpawning arrowSpawner;

    public TextMeshProUGUI scoreText;

    private bool handlingShooting = false;

    private void Start()
    {
        scoreText.text = score.ToString();
        StartCoroutine(HandleArrowShooting());
    }

    private void Update()
    {
        if (score > scoreTracker)
        {
            scoreTracker = score;
        }

        if (handlingShooting == false)
        {
            StartCoroutine(HandleArrowShooting());
        }
    }

    IEnumerator HandleArrowShooting()
    {
        handlingShooting = true;

        humanAnimation.PlayShootAnimation();
        bowAnimator.HandleAnimationStates(1);
        yield return new WaitForSeconds(2f);

        bowAnimator.HandleAnimationStates(2);
        GameObject arrow = arrowSpawner.SpawnArrow();
        yield return new WaitForSeconds(2f);

        Destroy(arrow);
        scoreText.text = score.ToString();

        handlingShooting = false;
    }
}
