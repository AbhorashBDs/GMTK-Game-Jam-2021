using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    private static SceneManager p_instance = null;
    public static SceneManager Instance { get { return p_instance; } }

    [SerializeField] public List<Scene> listScene;

    void Awake()
    {
        //Check if instance already exists
        if (p_instance == null)
            //if not, set instance to this
            p_instance = this;
        //If instance already exists and it's not this:
        else if (p_instance != this)
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        listScene = new List<Scene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(int index)
    {
        Instance.LoadScene(index);
    }

    public void LoadScene(string __nom_scene)
    {
        Instance.LoadScene(__nom_scene);
    }
}
