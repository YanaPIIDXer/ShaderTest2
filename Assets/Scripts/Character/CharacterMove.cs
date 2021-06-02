using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    /// <summary>
    /// キャラ移動
    /// 色々全部この中に放り込んでるけど、本題ではないので許容とする
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Animator))]
    public class CharacterMove : MonoBehaviour
    {
        /// <summary>
        /// Rigidbody
        /// </summary>
        private Rigidbody Body = null;

        /// <summary>
        /// Animator
        /// </summary>
        private Animator AnimControl = null;

        /// <summary>
        /// 移動ベクトル
        /// </summary>
        private Vector2 MoveVec = Vector2.zero;

        void Awake()
        {
            Body = GetComponent<Rigidbody>();
            AnimControl = GetComponent<Animator>();
        }

        void Update()
        {
            MoveVec.x = Input.GetAxis("Horizontal");
            MoveVec.y = Input.GetAxis("Vertical");

            bool IsMoving = MoveVec.sqrMagnitude > 0.01f;
            AnimControl.SetBool("IsMoving", IsMoving);
        }

        void FixedUpdate()
        {
            Vector3 Vec = new Vector3(MoveVec.x, 0.0f, MoveVec.y);
            Body.velocity = Vec;
            transform.LookAt(transform.position + Vec);
        }
    }
}
