using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Character
{
    /// <summary>
    /// マテリアルセット
    /// </summary>
    [Serializable]
    public class MaterialSet
    {
        [SerializeField]
        public Material Body = null;
        [SerializeField]
        public Material Hair = null;
        [SerializeField]
        public Material Cheek = null;
        [SerializeField]
        public Material Skin = null;
    }

    /// <summary>
    /// マテリアル切り替え
    /// </summary>
    public class MaterialSwitcher : MonoBehaviour
    {
        /// <summary>
        /// 初期マテリアルセット
        /// </summary>
        [SerializeField]
        private MaterialSet DefaultMaterialSet = new MaterialSet();

        /// <summary>
        /// Bodyマテリアルをアサインする対象リスト
        /// </summary>
        [SerializeField]
        private List<SkinnedMeshRenderer> BodyMaterialTargets = new List<SkinnedMeshRenderer>();

        /// <summary>
        /// Hairマテリアルをアサインする対象リスト
        /// </summary>
        [SerializeField]
        private List<SkinnedMeshRenderer> HairMaterialTargets = new List<SkinnedMeshRenderer>();

        /// <summary>
        /// Cheekマテリアルをアサインする対象
        /// </summary>
        [SerializeField]
        private SkinnedMeshRenderer CheekMaterialTarget = null;

        /// <summary>
        /// Skinマテリアルをアサインする対象
        /// </summary>
        [SerializeField]
        private SkinnedMeshRenderer SkinMaterialTarget = null;

        void Awake()
        {
            AssignDefaultMaterial();
        }

        /// <summary>
        /// デフォルトのマテリアルをアサイン
        /// </summary>
        private void AssignDefaultMaterial()
        {
            AssignMaterialSet(DefaultMaterialSet);
        }

        /// <summary>
        /// 指定したマテリアルセットをアサイン
        /// </summary>
        /// <param name="Set">マテリアルセット</param>
        public void AssignMaterialSet(MaterialSet Set)
        {
            foreach (var r in BodyMaterialTargets)
            {
                r.material = Set.Body;
            }

            foreach (var r in HairMaterialTargets)
            {
                r.material = Set.Hair;
            }

            CheekMaterialTarget.material = Set.Cheek;
            SkinMaterialTarget.material = Set.Skin;
        }
    }
}
