[DisallowMultipleComponent] // RVA: 0x1495F0 Offset: 0x1496F1 VA: 0x1495F0
[ExecuteInEditMode] // RVA: 0x1495F0 Offset: 0x1496F1 VA: 0x1495F0
public class Spline : MonoBehaviour // TypeDefIndex: 9734
{
	// Fields
	public List<SplineNode> nodes; // 0x18
	[HideInInspector] // RVA: 0x17EDA0 Offset: 0x17EEA1 VA: 0x17EDA0
	public List<CubicBezierCurve> curves; // 0x20
	public float Length; // 0x28
	[SerializeField] // RVA: 0x17EDB0 Offset: 0x17EEB1 VA: 0x17EDB0
	private bool isLoop; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x17EDC0 Offset: 0x17EEC1 VA: 0x17EDC0
	private ListChangeHandler<SplineNode> NodeListChanged; // 0x30
	[HideInInspector] // RVA: 0x17EDD0 Offset: 0x17EED1 VA: 0x17EDD0
	public UnityEvent CurveChanged; // 0x38
	private SplineNode start; // 0x40
	private SplineNode end; // 0x48

	// Properties
	public bool IsLoop { get; set; }

	// Methods

	// RVA: 0x22420B0 Offset: 0x22421B1 VA: 0x22420B0
	public bool get_IsLoop() { }

	// RVA: 0x22420C0 Offset: 0x22421C1 VA: 0x22420C0
	public void set_IsLoop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACF10 Offset: 0x1AD011 VA: 0x1ACF10
	// RVA: 0x2242450 Offset: 0x2242551 VA: 0x2242450
	public void add_NodeListChanged(ListChangeHandler<SplineNode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1ACF20 Offset: 0x1AD021 VA: 0x1ACF20
	// RVA: 0x2242500 Offset: 0x2242601 VA: 0x2242500
	public void remove_NodeListChanged(ListChangeHandler<SplineNode> value) { }

	// RVA: 0x22425B0 Offset: 0x22426B1 VA: 0x22425B0
	private void Reset() { }

	// RVA: 0x2242950 Offset: 0x2242A51 VA: 0x2242950
	private void OnEnable() { }

	// RVA: 0x2242B60 Offset: 0x2242C61 VA: 0x2242B60
	public ReadOnlyCollection<CubicBezierCurve> GetCurves() { }

	// RVA: 0x22427B0 Offset: 0x22428B1 VA: 0x22427B0
	private void RaiseNodeListChanged(ListChangedEventArgs<SplineNode> args) { }

	// RVA: 0x2242830 Offset: 0x2242931 VA: 0x2242830
	private void UpdateAfterCurveChanged() { }

	// RVA: 0x2242BC0 Offset: 0x2242CC1 VA: 0x2242BC0
	public CurveSample GetSample(float t) { }

	// RVA: 0x2242DD0 Offset: 0x2242ED1 VA: 0x2242DD0
	public CubicBezierCurve GetCurve(float t) { }

	// RVA: 0x2242C70 Offset: 0x2242D71 VA: 0x2242C70
	private int GetNodeIndexForTime(float t) { }

	// RVA: 0x2242960 Offset: 0x2242A61 VA: 0x2242960
	public void RefreshCurves() { }

	// RVA: 0x223EA20 Offset: 0x223EB21 VA: 0x223EA20
	public CurveSample GetSampleAtDistance(float d) { }

	// RVA: 0x2240760 Offset: 0x2240861 VA: 0x2240760
	public void AddNode(SplineNode node) { }

	// RVA: 0x2242E60 Offset: 0x2242F61 VA: 0x2242E60
	public void InsertNode(int index, SplineNode node) { }

	// RVA: 0x2240970 Offset: 0x2240A71 VA: 0x2240970
	public void RemoveNode(SplineNode node) { }

	// RVA: 0x22420D0 Offset: 0x22421D1 VA: 0x22420D0
	private void updateLoopBinding() { }

	// RVA: 0x2243280 Offset: 0x2243381 VA: 0x2243280
	private void StartNodeChanged(object sender, EventArgs e) { }

	// RVA: 0x22439A0 Offset: 0x2243AA1 VA: 0x22439A0
	private void EndNodeChanged(object sender, EventArgs e) { }

	// RVA: 0x2243E50 Offset: 0x2243F51 VA: 0x2243E50
	public CurveSample GetProjectionSample(Vector3 pointToProject) { }

	// RVA: 0x2244250 Offset: 0x2244351 VA: 0x2244250
	public void .ctor() { }
}

