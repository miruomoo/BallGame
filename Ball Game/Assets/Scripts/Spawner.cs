using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour{

public GameObject goldCoin;
public GameObject silverCoin;
public GameObject diamond;
private GameObject gc;
private GameObject sc;
private GameObject d;


public void spawnGold(){
        gc = Instantiate(goldCoin);
        gc.transform.position = new Vector3(Random.Range(-9f,9f), 1f, Random.Range(-9f,9f));
    }
    public void spawnSilver(){
        sc = Instantiate(silverCoin);
        sc.transform.position = new Vector3(Random.Range(-9f,9f), 1f, Random.Range(-9f,9f));
    }
    public void spawnDiamond(){
        d = Instantiate(diamond);
        d.transform.position = new Vector3(Random.Range(-9f,9f), 1f, Random.Range(-9f,9f));
    }

    // Start is called before the first frame update
    void Start()
    {
    Invoke("spawnSilver",1.0f);
    Invoke("spawnSilver",2.0f);
    Invoke("spawnSilver",3.0f);
    Invoke("spawnGold",4.0f);
    Invoke("spawnSilver",5.0f);
    Invoke("spawnSilver",6.0f);
    Invoke("spawnGold",7.0f);
    Invoke("spawnDiamond",8.0f);
    Invoke("spawnGold",9.0f);
    Invoke("spawnDiamond",10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
