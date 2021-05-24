[DisallowMultipleComponent] // RVA: 0x149630 Offset: 0x149731 VA: 0x149630
[ExecuteInEditMode] // RVA: 0x149630 Offset: 0x149731 VA: 0x149630
[RequireComponent] // RVA: 0x149630 Offset: 0x149731 VA: 0x149630
public class SplineSmoother : MonoBehaviour // TypeDefIndex: 9739
{
	// Fields
	private Spline spline; // 0x18
	[RangeAttribute] // RVA: 0x17EE40 Offset: 0x17EF41 VA: 0x17EE40
	public float curvature; // 0x20

	// Properties
	private Spline Spline { get; }

	// Methods

	// RVA: 0x22464E0 Offset: 0x22465E1 VA: 0x22464E0
	private Spline get_Spline() { }

	// RVA: 0x2246590 Offset: 0x2246691 VA: 0x2246590
	private void OnValidate() { }

	// RVA: 0x2246730 Offset: 0x2246831 VA: 0x2246730
	private void OnEnable() { }

	// RVA: 0x2246AC0 Offset: 0x2246BC1 VA: 0x2246AC0
	private void OnDisable() { }

	// RVA: 0x2246E50 Offset: 0x2246F51 VA: 0x2246E50
	private void Spline_NodeListChanged(object sender, ListChangedEventArgs<SplineNode> args) { }

	// RVA: 0x22471C0 Offset: 0x22472C1 VA: 0x22471C0
	private void OnNodeChanged(object sender, EventArgs e) { }

	// RVA: 0x2247530 Offset: 0x2247631 VA: 0x2247530
	private void SmoothNode(SplineNode node) { }

	// RVA: 0x22465A0 Offset: 0x22466A1 VA: 0x22465A0
	private void SmoothAll() { }

	// RVA: 0x2247B00 Offset: 0x2247C01 VA: 0x2247B00
	public void .ctor() { }
}

