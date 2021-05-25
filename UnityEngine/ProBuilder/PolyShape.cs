[DisallowMultipleComponent] // RVA: 0x1414B0 Offset: 0x1415B1 VA: 0x1414B0
[AddComponentMenu] // RVA: 0x1414B0 Offset: 0x1415B1 VA: 0x1414B0
[ExcludeFromObjectFactoryAttribute] // RVA: 0x1414B0 Offset: 0x1415B1 VA: 0x1414B0
[ExcludeFromPresetAttribute] // RVA: 0x1414B0 Offset: 0x1415B1 VA: 0x1414B0
[ProGridsConditionalSnapAttribute] // RVA: 0x1414B0 Offset: 0x1415B1 VA: 0x1414B0
public sealed class PolyShape : MonoBehaviour // TypeDefIndex: 5959
{
	// Fields
	private ProBuilderMesh m_Mesh; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x141BF0 Offset: 0x141CF1 VA: 0x141BF0
	[SerializeField] // RVA: 0x141BF0 Offset: 0x141CF1 VA: 0x141BF0
	internal List<Vector3> m_Points; // 0x20
	[SerializeField] // RVA: 0x141C40 Offset: 0x141D41 VA: 0x141C40
	[FormerlySerializedAsAttribute] // RVA: 0x141C40 Offset: 0x141D41 VA: 0x141C40
	private float m_Extrude; // 0x28
	[SerializeField] // RVA: 0x141C90 Offset: 0x141D91 VA: 0x141C90
	[FormerlySerializedAsAttribute] // RVA: 0x141C90 Offset: 0x141D91 VA: 0x141C90
	private PolyShape.PolyEditMode m_EditMode; // 0x2C
	[FormerlySerializedAsAttribute] // RVA: 0x141CE0 Offset: 0x141DE1 VA: 0x141CE0
	[SerializeField] // RVA: 0x141CE0 Offset: 0x141DE1 VA: 0x141CE0
	private bool m_FlipNormals; // 0x30
	[SerializeField] // RVA: 0x141D30 Offset: 0x141E31 VA: 0x141D30
	internal bool isOnGrid; // 0x31

	// Properties
	public ReadOnlyCollection<Vector3> controlPoints { get; }
	public float extrude { get; set; }
	internal PolyShape.PolyEditMode polyEditMode { get; set; }
	public bool flipNormals { get; set; }
	internal ProBuilderMesh mesh { get; set; }

	// Methods

	// RVA: 0x1A972E0 Offset: 0x1A973E1 VA: 0x1A972E0
	public ReadOnlyCollection<Vector3> get_controlPoints() { }

	// RVA: 0x1A97350 Offset: 0x1A97451 VA: 0x1A97350
	public void SetControlPoints(IList<Vector3> points) { }

	// RVA: 0x1A973C0 Offset: 0x1A974C1 VA: 0x1A973C0
	public float get_extrude() { }

	// RVA: 0x1A973D0 Offset: 0x1A974D1 VA: 0x1A973D0
	public void set_extrude(float value) { }

	// RVA: 0x1A973E0 Offset: 0x1A974E1 VA: 0x1A973E0
	internal PolyShape.PolyEditMode get_polyEditMode() { }

	// RVA: 0x1A973F0 Offset: 0x1A974F1 VA: 0x1A973F0
	internal void set_polyEditMode(PolyShape.PolyEditMode value) { }

	// RVA: 0x1A97400 Offset: 0x1A97501 VA: 0x1A97400
	public bool get_flipNormals() { }

	// RVA: 0x1A97410 Offset: 0x1A97511 VA: 0x1A97410
	public void set_flipNormals(bool value) { }

	// RVA: 0x1A97420 Offset: 0x1A97521 VA: 0x1A97420
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x1A974D0 Offset: 0x1A975D1 VA: 0x1A974D0
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x1A974E0 Offset: 0x1A975E1 VA: 0x1A974E0
	private bool IsSnapEnabled() { }

	// RVA: 0x1A974F0 Offset: 0x1A975F1 VA: 0x1A974F0
	public void .ctor() { }
}

