using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class Player : MonoBehaviour
{
    // score van speler
    [SerializeField] private int zoro = 0;

    // text waar score op staat
     public TMP_Text Zwins;
     
    //  snelheid van speler
    public float moveSpeed = 5f;

    // de body2D die je kan aanraken
    private Rigidbody2D m_Rigidbody;
 
 

    private void Start()

    {
        // de rigidbody2D voorbereiden om te kunnen gebruiken
        m_Rigidbody = GetComponent<Rigidbody2D>();

 
    }
 
    void Update()

    {
        // bewegen
        transform.position += new Vector3(Input.GetAxis("Horizontal1") * moveSpeed * Time.deltaTime, 0);
        transform.position += new Vector3(0, Input.GetAxis("Vertical1") * moveSpeed * Time.deltaTime);

        // laat op de text zien wat je score is
        Zwins.SetText(zoro.ToString());
 
    }
 
    private void FixedUpdate()
    {
 
        if(zoro >= 10)
        {
            // speler heeft gewonnen
            winning();
        }
        // speler draait hele tijd om
        m_Rigidbody.rotation += 2;
 
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // plaats speler terug bij start
        transform.position = new Vector3(7.3f, 0f);

    }


       public void OnTriggerEnter2D(Collider2D collision)
       {
        if (collision.gameObject.name == "sake")
        {
            // geef punt aan speler
            zoro += 1;
        {
        // plaats speler terug bij start
        transform.position = new Vector3(7.3f, 0f);
        }
        }
        
        if (collision.gameObject.name == "bounty")
        {
            zoro += 1;
        {
        transform.position = new Vector3(7.3f, 0f);
        }
        }
       }
       
        public void winning()
        {
            // ga naar winscreen
            SceneManager.LoadScene("winZ");
        }
 
}

 