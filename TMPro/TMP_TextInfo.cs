[Serializable]
public class TMP_TextInfo // TypeDefIndex: 5873
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x159C710 Offset: 0x159C811 VA: 0x159C710
	public void .ctor() { }

	// RVA: 0x159C830 Offset: 0x159C931 VA: 0x159C830
	internal void .ctor(int characterCount) { }

	// RVA: 0x159C960 Offset: 0x159CA61 VA: 0x159C960
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x159CB00 Offset: 0x159CC01 VA: 0x159CB00
	public void Clear() { }

	// RVA: 0x159CB70 Offset: 0x159CC71 VA: 0x159CB70
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x159CBF0 Offset: 0x159CCF1 VA: 0x159CBF0
	public void ClearAllMeshInfo() { }

	// RVA: 0x159CC70 Offset: 0x159CD71 VA: 0x159CC70
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x159CD00 Offset: 0x159CE01 VA: 0x159CD00
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x159CD80 Offset: 0x159CE81 VA: 0x159CD80
	public void ClearLineInfo() { }

	// RVA: 0x159CFE0 Offset: 0x159D0E1 VA: 0x159CFE0
	internal void ClearPageInfo() { }

	// RVA: 0x159D130 Offset: 0x159D231 VA: 0x159D130
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1DF0 Offset: 0x23E1EF1 VA: 0x23E1DF0
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x23E2090 Offset: 0x23E2191 VA: 0x23E2090
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x23E2330 Offset: 0x23E2431 VA: 0x23E2330
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E1E90 Offset: 0x23E1F91 VA: 0x23E1E90
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<Material>
	|
	|-RVA: 0x23E1F90 Offset: 0x23E2091 VA: 0x23E1F90
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x23E2130 Offset: 0x23E2231 VA: 0x23E2130
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x23E2230 Offset: 0x23E2331 VA: 0x23E2230
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	// RVA: 0x159D560 Offset: 0x159D661 VA: 0x159D560
	private static void .cctor() { }
}

