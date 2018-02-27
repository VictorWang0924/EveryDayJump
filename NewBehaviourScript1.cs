using System.Collections;
using System.Collections.Generic;
using UnityEngine;
阿瑟大时代
namespace Game
{
	public class NewBehaviourScript1 : MonoBehaviour 
	{

        #region 界面属性

        #endregion

        #region 私有属性

        #endregion

        #region unity生命周期\
        Rigidbody body;
        Quaternion oldQua;
        private void Start()
        {
            body = GetComponent<Rigidbody>();
            body.centerOfMass = new Vector3(0, 0, 0);
        }
        private void Update()
        {
            //y=-x2  
            //0,0
            //1,-1 -1
            //2,-2 -4
            if (Input.GetKeyDown(KeyCode.W))
            {
                oldQua = transform.transform.rotation;
                body.AddForce((Vector3.forward * 2 + Vector3.up * 5), ForceMode.Impulse);
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            transform.transform.rotation = oldQua;
        }
            #endregion

            #region 共有属性

            #endregion

            #region 共有函数

            #endregion

            #region 私有函数

            #endregion
        }
}