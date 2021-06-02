using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{
    /// <summary>
    /// プレイヤーカメラ
    /// </summary>
    public class PlayerCamera : MonoBehaviour
    {
        /// <summary>
        /// プレイヤーのTransform
        /// </summary>
        [SerializeField]
        private Transform PlayerTransform = null;

        /// <summary>
        /// プレイヤーからのオフセット座標
        /// </summary>
        private Vector3 PositionOffset = new Vector3(0.0f, 1.0f, -2.0f);

        void FixedUpdate()
        {
            transform.position = PlayerTransform.position + PositionOffset;
        }
    }
}
