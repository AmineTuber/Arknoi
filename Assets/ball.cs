using UnityEngine;
using UnityEngine.UI;


public class ball : MonoBehaviour
{
    public float speed = 100.0f;
    public Image lose;
    public int red = 3;
    public Text scoretext;
    int score;
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        lose.gameObject.SetActive(false);

    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
     {


            return (ballPos.x - racketPos.x) / racketWidth;
     }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
      else  if (collision.gameObject.tag == "square")
        {
            if (collision.gameObject.GetComponent<Brique>().nbrDeHits == 0)
            {
               
                   Destroy(collision.gameObject);
                score++;
                scoretext.text = score.ToString();
          
            }else
                collision.gameObject.GetComponent<Brique>().nbrDeHits--;




         
            
           








        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "lose")
        {
            lose.gameObject.SetActive(true);

        }

     }
}



