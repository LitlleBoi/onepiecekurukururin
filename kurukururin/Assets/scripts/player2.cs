using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
 
public class Player2 : MonoBehaviour
{
    [SerializeField] private int luffy = 0;
     public TMP_Text Lwins;

    public float moveSpeed = 5f;

    private Rigidbody2D m_Rigidbody;
 
 
  

 
 
    private void Start()
    {

        m_Rigidbody = GetComponent<Rigidbody2D>();

 
    }
 
    void Update()
    {

        transform.position += new Vector3(Input.GetAxis("Horizontal2") * moveSpeed * Time.deltaTime, 0);

        transform.position += new Vector3(0, Input.GetAxis("Vertical2") * moveSpeed * Time.deltaTime);
 
 
        Lwins.SetText(luffy.ToString());

    }
    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("doei luffy");
        transform.position = new Vector3(-7.3f, 0f);
    }
 
    private void FixedUpdate()
    {
        if(luffy >= 10)
        {
            winning();
        }

        m_Rigidbody.rotation += 2;
    }
 
        public void OnTriggerEnter2D(Collider2D collision)
       {
        if (collision.gameObject.name == "meat")
        {
         luffy += 1;
        {
        Debug.Log("luffy");
        transform.position = new Vector3(-7.3f, 0f);
        }
        }
       
        if (collision.gameObject.name == "bounty")
        {
         luffy += 1;
        {
        Debug.Log("luffy");
        transform.position = new Vector3(-7.3f, 0f);
        }
        }
       }

        public void winning()
        {
            SceneManager.LoadScene("winL");
            Debug.Log("winL");
        }
       

}

 