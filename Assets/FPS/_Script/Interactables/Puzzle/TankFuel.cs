using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TankFuel : Interactable
{

    public Animator fadeOutIn;
    public TextMeshProUGUI task;
    public string newTask;
    private bool changeLevel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (changeLevel)
        {



        }

    }

    protected override void Interact()
    {

        fadeOutIn.SetBool("FadeIn", true);
        Invoke("OnFadeComplete", 2.5f);
        task.color = Color.green;
       

    }

    public void OnFadeComplete()
    {

        SceneManager.LoadScene(0);

    }

}
