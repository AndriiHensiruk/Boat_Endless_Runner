using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float leftRightSpeed = 150f;
   
   private Vector3 oldPos;

    
    private void Update () {
        
      var angles = transform.rotation.eulerAngles;
       
       
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            angles.y = Time.deltaTime * -500;
           
         
            if(this.gameObject.transform.position.x > OceanBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime *leftRightSpeed, Space.World);
                
            }
        }else angles.y =0;
            
        

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
             angles.y = Time.deltaTime * 500;
            if(this.gameObject.transform.position.x < OceanBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime *leftRightSpeed * -1, Space.World);
                
            }
        }

         transform.rotation = Quaternion.Euler(angles);
    }


     
}
    