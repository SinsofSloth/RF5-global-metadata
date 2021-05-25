[ExecuteInEditMode] // RVA: 0x149970 Offset: 0x149A71 VA: 0x149970
[DisallowMultipleComponent] // RVA: 0x149970 Offset: 0x149A71 VA: 0x149970
[RequireComponent] // RVA: 0x149970 Offset: 0x149A71 VA: 0x149970
[RequireComponent] // RVA: 0x149970 Offset: 0x149A71 VA: 0x149970
public class ExtrusionSegment : MonoBehaviour // TypeDefIndex: 9750
{
	// Fields
	private bool isDirty; // 0x18
	private MeshFilter mf; // 0x20
	private Mesh result; // 0x28
	private bool useSpline; // 0x30
	private CubicBezierCurve curve; // 0x38
	private Spline spline; // 0x40
	private float intervalStart; // 0x48
	private float intervalEnd; // 0x4C
	private List<ExtrusionSegment.Vertex> shapeVertices; // 0x50
	private float textureScale; // 0x58
	private float textureOffset; // 0x5C
	private float sampleSpacing; // 0x60

	// Properties
	public List<ExtrusionSegment.Vertex> ShapeVertices { get; set; }
	public float TextureScale { get; set; }
	public float TextureOffset { get; set; }
	public float SampleSpacing { get; set; }

	// Methods

	// RVA: 0x2124010 Offset: 0x2124111 VA: 0x2124010
	public List<ExtrusionSegment.Vertex> get_ShapeVertices() { }

	// RVA: 0x2124020 Offset: 0x2124121 VA: 0x2124020
	public void set_ShapeVertices(List<ExtrusionSegment.Vertex> value) { }

	// RVA: 0x2124060 Offset: 0x2124161 VA: 0x2124060
	public float get_TextureScale() { }

	// RVA: 0x2124070 Offset: 0x2124171 VA: 0x2124070
	public void set_TextureScale(float value) { }

	// RVA: 0x2124090 Offset: 0x2124191 VA: 0x2124090
	public float get_TextureOffset() { }

	// RVA: 0x21240A0 Offset: 0x21241A1 VA: 0x21240A0
	public void set_TextureOffset(float value) { }

	// RVA: 0x21240C0 Offset: 0x21241C1 VA: 0x21240C0
	public float get_SampleSpacing() { }

	// RVA: 0x21240D0 Offset: 0x21241D1 VA: 0x21240D0
	public void set_SampleSpacing(float value) { }

	// RVA: 0x21241A0 Offset: 0x21242A1 VA: 0x21241A0
	private void OnEnable() { }

	// RVA: 0x2124290 Offset: 0x2124391 VA: 0x2124290
	public void SetInterval(CubicBezierCurve curve) { }

	// RVA: 0x21243F0 Offset: 0x21244F1 VA: 0x21243F0
	public void SetInterval(Spline spline, float intervalStart, float intervalEnd = 0) { }

	// RVA: 0x2124050 Offset: 0x2124151 VA: 0x2124050
	private void SetDirty() { }

	// RVA: 0x21246E0 Offset: 0x21247E1 VA: 0x21246E0
	private void Update() { }

	// RVA: 0x2124710 Offset: 0x2124811 VA: 0x2124710
	public void ComputeIfNeeded() { }

	// RVA: 0x21250F0 Offset: 0x21251F1 VA: 0x21250F0
	private List<CurveSample> GetPath() { }

	// RVA: 0x2124740 Offset: 0x2124841 VA: 0x2124740
	public void Compute() { }

	// RVA: 0x2125360 Offset: 0x2125461 VA: 0x2125360
	public void .ctor() { }
}

