using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private Boss boss = new Boss();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] array = {1, 2, 3, 4, 5};
        for(int i = 0; i < array.Length; i++){
            Debug.Log (array[i]);
        }
        for(int i = array.Length-1; i >= 0; i--){
            Debug.Log (array[i]);            
        }

        for(int i = 0; i < 11; i++){
            this.boss.Magic();
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Boss{

    private int mp = 53;

    public void Magic(){
        if(this.mp - 5 >= 0){
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。"); 
        }else{
            Debug.Log("MPが足りないため、魔法が使えない。"); 
        }
    }
}