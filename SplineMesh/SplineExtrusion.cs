[ExecuteInEditMode] // RVA: 0x149AB0 Offset: 0x149BB1 VA: 0x149AB0
[RequireComponent] // RVA: 0x149AB0 Offset: 0x149BB1 VA: 0x149AB0
public class SplineExtrusion : MonoBehaviour // TypeDefIndex: 9758
{
	// Fields
	private Spline spline; // 0x18
	private bool toUpdate; // 0x20
	private GameObject generated; // 0x28
	public List<ExtrusionSegment.Vertex> shapeVertices; // 0x30
	public Material material; // 0x38
	public float textureScale; // 0x40
	public float sampleSpacing; // 0x44

	// Methods

	// RVA: 0x2244330 Offset: 0x2244431 VA: 0x2244330
	private void Reset() { }

	// RVA: 0x22447E0 Offset: 0x22448E1 VA: 0x22447E0
	private void OnValidate() { }

	// RVA: 0x2244550 Offset: 0x2244651 VA: 0x2244550
	private void OnEnable() { }

	// RVA: 0x22447F0 Offset: 0x22448F1 VA: 0x22447F0
	private void Update() { }

	// RVA: 0x2244820 Offset: 0x2244921 VA: 0x2244820
	private void GenerateMesh() { }

	// RVA: 0x2244F80 Offset: 0x2245081 VA: 0x2244F80
	public void SetToUpdate() { }

	// RVA: 0x2244F90 Offset: 0x2245091 VA: 0x2244F90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFA0 Offset: 0x1AD0A1 VA: 0x1ACFA0
	// RVA: 0x2245030 Offset: 0x2245131 VA: 0x2245030
	private void <OnEnable>b__9_0(object s, ListChangedEventArgs<SplineNode> e) { }
}

