[NativeClassAttribute] // RVA: 0xC7310 Offset: 0xC7411 VA: 0xC7310
[NativeHeaderAttribute] // RVA: 0xC7310 Offset: 0xC7411 VA: 0xC7310
public sealed class RectTransform : Transform // TypeDefIndex: 3067
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xCA930 Offset: 0xCAA31 VA: 0xCA930
	[CompilerGeneratedAttribute] // RVA: 0xCA930 Offset: 0xCAA31 VA: 0xCA930
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }
	internal Object drivenByObject { get; set; }
	internal DrivenTransformProperties drivenProperties { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xD8400 Offset: 0xD8501 VA: 0xD8400
	// RVA: 0x2B780B0 Offset: 0x2B781B1 VA: 0x2B780B0
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD8410 Offset: 0xD8511 VA: 0xD8410
	// RVA: 0x2B78170 Offset: 0x2B78271 VA: 0x2B78170
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x2B78230 Offset: 0x2B78331 VA: 0x2B78230
	public Rect get_rect() { }

	// RVA: 0x2B782E0 Offset: 0x2B783E1 VA: 0x2B782E0
	public Vector2 get_anchorMin() { }

	// RVA: 0x2B78390 Offset: 0x2B78491 VA: 0x2B78390
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x2B78440 Offset: 0x2B78541 VA: 0x2B78440
	public Vector2 get_anchorMax() { }

	// RVA: 0x2B784F0 Offset: 0x2B785F1 VA: 0x2B784F0
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x2B785A0 Offset: 0x2B786A1 VA: 0x2B785A0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x2B78650 Offset: 0x2B78751 VA: 0x2B78650
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x2B78700 Offset: 0x2B78801 VA: 0x2B78700
	public Vector2 get_sizeDelta() { }

	// RVA: 0x2B787B0 Offset: 0x2B788B1 VA: 0x2B787B0
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x2B78860 Offset: 0x2B78961 VA: 0x2B78860
	public Vector2 get_pivot() { }

	// RVA: 0x2B78910 Offset: 0x2B78A11 VA: 0x2B78910
	public void set_pivot(Vector2 value) { }

	// RVA: 0x2B789C0 Offset: 0x2B78AC1 VA: 0x2B789C0
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x2B78A50 Offset: 0x2B78B51 VA: 0x2B78A50
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x2B78AE0 Offset: 0x2B78BE1 VA: 0x2B78AE0
	public Vector2 get_offsetMin() { }

	// RVA: 0x2B78C30 Offset: 0x2B78D31 VA: 0x2B78C30
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x2B78F10 Offset: 0x2B79011 VA: 0x2B78F10
	public Vector2 get_offsetMax() { }

	// RVA: 0x2B79080 Offset: 0x2B79181 VA: 0x2B79080
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x2B79350 Offset: 0x2B79451 VA: 0x2B79350
	internal Object get_drivenByObject() { }

	// RVA: 0x2B793A0 Offset: 0x2B794A1 VA: 0x2B793A0
	internal void set_drivenByObject(Object value) { }

	// RVA: 0x2B793F0 Offset: 0x2B794F1 VA: 0x2B793F0
	internal DrivenTransformProperties get_drivenProperties() { }

	// RVA: 0x2B79440 Offset: 0x2B79541 VA: 0x2B79440
	internal void set_drivenProperties(DrivenTransformProperties value) { }

	[NativeMethodAttribute] // RVA: 0xD8420 Offset: 0xD8521 VA: 0xD8420
	// RVA: 0x2B79490 Offset: 0x2B79591 VA: 0x2B79490
	public void ForceUpdateRectTransforms() { }

	// RVA: 0x2B794E0 Offset: 0x2B795E1 VA: 0x2B794E0
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2B796E0 Offset: 0x2B797E1 VA: 0x2B796E0
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x2B798B0 Offset: 0x2B799B1 VA: 0x2B798B0
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x2B79B90 Offset: 0x2B79C91 VA: 0x2B79B90
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD8460 Offset: 0xD8561 VA: 0xD8460
	// RVA: 0x2B79E60 Offset: 0x2B79F61 VA: 0x2B79E60
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x2B7A2A0 Offset: 0x2B7A3A1 VA: 0x2B7A2A0
	internal Rect GetRectInParentSpace() { }

	// RVA: 0x2B79D20 Offset: 0x2B79E21 VA: 0x2B79D20
	private Vector2 GetParentSize() { }

	// RVA: 0x2B7A5C0 Offset: 0x2B7A6C1 VA: 0x2B7A5C0
	public void .ctor() { }

	// RVA: 0x2B78290 Offset: 0x2B78391 VA: 0x2B78290
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2B78340 Offset: 0x2B78441 VA: 0x2B78340
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x2B783F0 Offset: 0x2B784F1 VA: 0x2B783F0
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x2B784A0 Offset: 0x2B785A1 VA: 0x2B784A0
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x2B78550 Offset: 0x2B78651 VA: 0x2B78550
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x2B78600 Offset: 0x2B78701 VA: 0x2B78600
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x2B786B0 Offset: 0x2B787B1 VA: 0x2B786B0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x2B78760 Offset: 0x2B78861 VA: 0x2B78760
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x2B78810 Offset: 0x2B78911 VA: 0x2B78810
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x2B788C0 Offset: 0x2B789C1 VA: 0x2B788C0
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x2B78970 Offset: 0x2B78A71 VA: 0x2B78970
	private void set_pivot_Injected(ref Vector2 value) { }
}

