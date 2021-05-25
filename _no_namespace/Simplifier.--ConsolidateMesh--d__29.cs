[CompilerGeneratedAttribute] // RVA: 0x159C60 Offset: 0x159D61 VA: 0x159C60
private sealed class Simplifier.<ConsolidateMesh>d__29 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9219
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Mesh meshIn; // 0x20
	public Simplifier.TriangleList[] aListTriangles; // 0x28
	public Simplifier.ProgressDelegate progress; // 0x30
	public string strProgressDisplayObjectName; // 0x38
	public Mesh meshOut; // 0x40
	public GameObject gameObject; // 0x48
	private Vector3[] <av3NormalsIn>5__2; // 0x50
	private Vector4[] <av4TangentsIn>5__3; // 0x58
	private Vector2[] <av2Mapping1In>5__4; // 0x60
	private Vector2[] <av2Mapping2In>5__5; // 0x68
	private Color[] <acolColorsIn>5__6; // 0x70
	private Color32[] <aColors32In>5__7; // 0x78
	private List<List<int>> <listlistIndicesOut>5__8; // 0x80
	private List<Vector3> <listVerticesOut>5__9; // 0x88
	private List<Vector3> <listNormalsOut>5__10; // 0x90
	private List<Vector4> <listTangentsOut>5__11; // 0x98
	private List<Vector2> <listMapping1Out>5__12; // 0xA0
	private List<Vector2> <listMapping2Out>5__13; // 0xA8
	private List<Color32> <listColors32Out>5__14; // 0xB0
	private List<BoneWeight> <listBoneWeightsOut>5__15; // 0xB8
	private Dictionary<Simplifier.VertexDataHash, int> <dicVertexDataHash2Index>5__16; // 0xC0
	private bool <bUV1>5__17; // 0xC8
	private bool <bUV2>5__18; // 0xC9
	private bool <bNormal>5__19; // 0xCA
	private bool <bTangent>5__20; // 0xCB
	private int <nSubMesh>5__21; // 0xCC
	private List<int> <listIndicesOut>5__22; // 0xD0
	private string <strMesh>5__23; // 0xD8
	private int <i>5__24; // 0xE0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x1B5070 Offset: 0x1B5171 VA: 0x1B5070
	// RVA: 0x1F58780 Offset: 0x1F58881 VA: 0x1F58780
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x1B5080 Offset: 0x1B5181 VA: 0x1B5080
	// RVA: 0x1F5CC90 Offset: 0x1F5CD91 VA: 0x1F5CC90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F5CCA0 Offset: 0x1F5CDA1 VA: 0x1F5CCA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x1B5090 Offset: 0x1B5191 VA: 0x1B5090
	// RVA: 0x1F5DF70 Offset: 0x1F5E071 VA: 0x1F5DF70 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x1B50A0 Offset: 0x1B51A1 VA: 0x1B50A0
	// RVA: 0x1F5DF80 Offset: 0x1F5E081 VA: 0x1F5DF80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x1B50B0 Offset: 0x1B51B1 VA: 0x1B50B0
	// RVA: 0x1F5DFE0 Offset: 0x1F5E0E1 VA: 0x1F5DFE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

