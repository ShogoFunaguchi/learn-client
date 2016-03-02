using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

CharacterController controller;

Vector3 moveDirection = Vector3.zero;


public float gravity;
public float speedZ;
public float upCounter;

	// Use this for initialization
	void Start () {
    //プレイヤーのコントローラーの取得
	controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
    moveDirection.z = 1;
    if(Input.GetAxis("Vertical")>0.0f){
      moveDirection.z = Input.GetAxis("Vertical") * speedZ;
    }else{
      moveDirection.z = 0.1f;
    }

    //方向転換
    transform.Rotate(0,Input.GetAxis("Horizontal")*3,0);

    //フレームごとの重力加算
    //moveDirection.y -=gravity * Time.deltaTime;

    //移動の実行
    Vector3 globalDirection = transform.TransformDirection(moveDirection);

    controller.Move(globalDirection);

    if(Input.GetAxis("Jump")>0.0f){
      StartCoroutine(PlayerUp());
      
      
    }

	}

  IEnumerator PlayerUp(){
    upCounter = 0.1f;
    while(upCounter < 2.0f ){
       transform.Rotate(-(Input.GetAxis("Jump")*0.3f),0,0);
       yield return new WaitForSeconds(0);
       upCounter += 0.1f;
    }
    transform.Rotate((Input.GetAxis("Jump")*0.3f),0,0);
    transform.rotation = Quaternion.identity;
  }
}
