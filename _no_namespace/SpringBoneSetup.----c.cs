[CompilerGeneratedAttribute] // RVA: 0x159AB0 Offset: 0x159BB1 VA: 0x159AB0
[Serializable]
private sealed class SpringBoneSetup.<>c // TypeDefIndex: 9148
{
	// Fields
	public static readonly SpringBoneSetup.<>c <>9; // 0x0
	public static Func<SpringBone, bool> <>9__8_0; // 0x8
	public static Func<SpringBone, Transform> <>9__8_1; // 0x10
	public static Func<Transform, GameObject> <>9__8_3; // 0x18
	public static Func<SkinnedMeshRenderer, Mesh> <>9__10_0; // 0x20
	public static Func<Mesh, bool> <>9__10_1; // 0x28
	public static Func<SpringBone, <>f__AnonymousType0<SpringBone, int>> <>9__13_0; // 0x30
	public static Comparison<<>f__AnonymousType0<SpringBone, int>> <>9__13_1; // 0x38
	public static Func<<>f__AnonymousType0<SpringBone, int>, SpringBone> <>9__13_2; // 0x40

	// Methods

	// RVA: 0x2398940 Offset: 0x2398A41 VA: 0x2398940
	private static void .cctor() { }

	// RVA: 0x23989B0 Offset: 0x2398AB1 VA: 0x23989B0
	public void .ctor() { }

	// RVA: 0x23989C0 Offset: 0x2398AC1 VA: 0x23989C0
	internal bool <DestroyPivotObjects>b__8_0(SpringBone springBone) { }

	// RVA: 0x2398A40 Offset: 0x2398B41 VA: 0x2398A40
	internal Transform <DestroyPivotObjects>b__8_1(SpringBone springBone) { }

	// RVA: 0x2398A60 Offset: 0x2398B61 VA: 0x2398A60
	internal GameObject <DestroyPivotObjects>b__8_3(Transform pivot) { }

	// RVA: 0x2398A80 Offset: 0x2398B81 VA: 0x2398A80
	internal Mesh <FindClosestMeshNormalToPoint>b__10_0(SkinnedMeshRenderer renderer) { }

	// RVA: 0x2398AA0 Offset: 0x2398BA1 VA: 0x2398AA0
	internal bool <FindClosestMeshNormalToPoint>b__10_1(Mesh mesh) { }

	// RVA: 0x2398B40 Offset: 0x2398C41 VA: 0x2398B40
	internal <>f__AnonymousType0<SpringBone, int> <GetSpringBonesSortedByDepth>b__13_0(SpringBone bone) { }

	// RVA: 0x2398BE0 Offset: 0x2398CE1 VA: 0x2398BE0
	internal int <GetSpringBonesSortedByDepth>b__13_1(<>f__AnonymousType0<SpringBone, int> a, <>f__AnonymousType0<SpringBone, int> b) { }

	// RVA: 0x2398C60 Offset: 0x2398D61 VA: 0x2398C60
	internal SpringBone <GetSpringBonesSortedByDepth>b__13_2(<>f__AnonymousType0<SpringBone, int> item) { }
}

