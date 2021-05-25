private class RopePersistManager.RopeData // TypeDefIndex: 9060
{
	// Fields
	public UltimateRope m_rope; // 0x10
	public bool m_bDeleted; // 0x18
	public Dictionary<string, object> m_hashFieldName2Value; // 0x20
	public bool m_bSkin; // 0x28
	public Vector3[] m_av3SkinVertices; // 0x30
	public Vector2[] m_av2SkinMapping; // 0x38
	public Vector4[] m_av4SkinTangents; // 0x40
	public BoneWeight[] m_aSkinBoneWeights; // 0x48
	public int[] m_anSkinTrianglesRope; // 0x50
	public int[] m_anSkinTrianglesSections; // 0x58
	public Matrix4x4[] m_amtxSkinBindPoses; // 0x60
	public RopePersistManager.RopeData.TransformInfo m_transformInfoRope; // 0x68
	public RopePersistManager.RopeData.TransformInfo[] m_aLinkTransformInfo; // 0x70
	public RopePersistManager.RopeData.TransformInfo m_transformInfoStart; // 0x78
	public RopePersistManager.RopeData.TransformInfo[] m_transformInfoSegments; // 0x80
	public bool[][] m_aaJointsProcessed; // 0x88
	public bool[][] m_aaJointsBroken; // 0x90

	// Methods

	// RVA: 0x1D69620 Offset: 0x1D69721 VA: 0x1D69620
	public void .ctor(UltimateRope rope) { }

	// RVA: 0x1D69A00 Offset: 0x1D69B01 VA: 0x1D69A00
	public static void MakeSkinDeepCopy(Vector3[] av3VerticesSource, Vector2[] av2MappingSource, Vector4[] av4TangentsSource, BoneWeight[] aBoneWeightsSource, int[] anTrianglesRopeSource, int[] anTrianglesSectionsSource, Matrix4x4[] aBindPosesSource, Vector3[] av3VerticesDestiny, Vector2[] av2MappingDestiny, Vector4[] av4TangentsDestiny, BoneWeight[] aBoneWeightsDestiny, int[] anTrianglesRopeDestiny, int[] anTrianglesSectionsDestiny, Matrix4x4[] aBindPosesDestiny) { }
}

