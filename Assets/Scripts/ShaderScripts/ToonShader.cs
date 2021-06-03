using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;

namespace ShaderScripts
{
    /// <summary>
    /// トゥーンシェーダ
    /// </summary>
    [RequireComponent(typeof(MaterialSwitcher))]
    public class ToonShader : MonoBehaviour
    {
        /// <summary>
        /// マテリアルセット
        /// </summary>
        [SerializeField]
        private MaterialSet Materials = new MaterialSet();

        /// <summary>
        /// マテリアル切り替え
        /// </summary>
        private MaterialSwitcher Switcher = null;

        void Awake()
        {
            Switcher = GetComponent<MaterialSwitcher>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Switcher.AssignMaterialSet(Materials);
            }
        }
    }
}
