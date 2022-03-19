using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameMnager : MonoBehaviour
{
   /// private TextMeshPro textt;
    public GameObject cube;
    public int column=8,row=8;
    public GameObject [,] twodarray;
    public string bird;
    //public Text birdnametext;
    public TextMesh textprint;
   //private TextMeshPro textmesh;
    
    public GameMnager (string birdname){
        bird=birdname;
    }

    // Start is called before the first frame update
     async void Awake()
    {
       // textmesh=gameObject.GetComponent<TextMeshPro>();
        List<string> birdslist=new List<string>();
        birdslist.Add(("sparow"));
        birdslist.Add(("Eagle"));
        birdslist.Add(("Hen"));
        birdslist.Add(("Crow"));
        birdslist.Add(("Parrot"));
        birdslist.Add(("Owl"));
       // textt=GameObject.FindGameObjectWithTag("textt").GetComponent<TextMeshPro>();
         Debug.Log(column+"row"+row);
        // twodarray=new GameObject[column][row];
        for(int i=0;i<column;i+=2){
          //  sparow.SetActive(true);  
            for (int j = 0; j < row; j+=2)
            {
              Instantiate(cube,new Vector3(i,0,j),Quaternion.identity);
              var r=Random.Range(0,birdslist.Count);
               textprint.text=birdslist[r].ToString();
               Instantiate(textprint,new Vector3(i-0.45f,0.5f,j+0f),textprint.transform.rotation);
               
               
               
                
                
                
               
                
                
               
            }
        }  
        
    }
    void Start(){
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
