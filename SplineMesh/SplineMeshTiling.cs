[ExecuteInEditMode] // RVA: 0x149B30 Offset: 0x149C31 VA: 0x149B30
[SelectionBaseAttribute] // RVA: 0x149B30 Offset: 0x149C31 VA: 0x149B30
[DisallowMultipleComponent] // RVA: 0x149B30 Offset: 0x149C31 VA: 0x149B30
public class SplineMeshTiling : MonoBehaviour // TypeDefIndex: 9759
{
	// Fields
	private GameObject generated; // 0x18
	private Spline spline; // 0x20
	private bool toUpdate; // 0x28
	[TooltipAttribute] // RVA: 0x17EE90 Offset: 0x17EF91 VA: 0x17EE90
	public Mesh mesh; // 0x30
	[TooltipAttribute] // RVA: 0x17EED0 Offset: 0x17EFD1 VA: 0x17EED0
	public Material material; // 0x38
	[TooltipAttribute] // RVA: 0x17EF10 Offset: 0x17F011 VA: 0x17EF10
	public PhysicMaterial physicMaterial; // 0x40
	[TooltipAttribute] // RVA: 0x17EF50 Offset: 0x17F051 VA: 0x17EF50
	public Vector3 translation; // 0x48
	[TooltipAttribute] // RVA: 0x17EF90 Offset: 0x17F091 VA: 0x17EF90
	public Vector3 rotation; // 0x54
	[TooltipAttribute] // RVA: 0x17EFD0 Offset: 0x17F0D1 VA: 0x17EFD0
	public Vector3 scale; // 0x60
	[TooltipAttribute] // RVA: 0x17F010 Offset: 0x17F111 VA: 0x17F010
	public bool generateCollider; // 0x6C
	[TooltipAttribute] // RVA: 0x17F050 Offset: 0x17F151 VA: 0x17F050
	public bool updateInPlayMode; // 0x6D
	[TooltipAttribute] // RVA: 0x17F090 Offset: 0x17F191 VA: 0x17F090
	public bool curveSpace; // 0x6E
	[TooltipAttribute] // RVA: 0x17F0D0 Offset: 0x17F1D1 VA: 0x17F0D0
	public MeshBender.FillingMode mode; // 0x70

	// Methods

	// RVA: 0x2245040 Offset: 0x2245141 VA: 0x2245040
	private void OnEnable() { }

	// RVA: 0x22452E0 Offset: 0x22453E1 VA: 0x22452E0
	private void OnValidate() { }

	// RVA: 0x2245360 Offset: 0x2245461 VA: 0x2245360
	private void Update() { }

	// RVA: 0x22453B0 Offset: 0x22454B1 VA: 0x22453B0
	public void CreateMeshes() { }

	// RVA: 0x2245BC0 Offset: 0x2245CC1 VA: 0x2245BC0
	private GameObject FindOrCreate(string name) { }

	// RVA: 0x2246350 Offset: 0x2246451 VA: 0x2246350
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACFB0 Offset: 0x1AD0B1 VA: 0x1ACFB0
	// RVA: 0x22463E0 Offset: 0x22464E1 VA: 0x22463E0
	private void <OnEnable>b__13_0(object s, ListChangedEventArgs<SplineNode> e) { }
}

