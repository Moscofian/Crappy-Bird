using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public ScoreScript score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            score.addScore(1);
        }
    }
}
