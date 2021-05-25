[NativeHeaderAttribute] // RVA: 0x108FB0 Offset: 0x1090B1 VA: 0x108FB0
[MovedFromAttribute] // RVA: 0x108FB0 Offset: 0x1090B1 VA: 0x108FB0
public sealed class NavMeshPath // TypeDefIndex: 3767
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

	// Properties
	public Vector3[] corners { get; }
	public NavMeshPathStatus status { get; }

	// Methods

	// RVA: 0x1BAD540 Offset: 0x1BAD641 VA: 0x1BAD540
	public void .ctor() { }

	// RVA: 0x1BB0470 Offset: 0x1BB0571 VA: 0x1BB0470 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x109610 Offset: 0x109711 VA: 0x109610
	// RVA: 0x1BB0430 Offset: 0x1BB0531 VA: 0x1BB0430
	private static IntPtr InitializeNavMeshPath() { }

	[FreeFunctionAttribute] // RVA: 0x109650 Offset: 0x109751 VA: 0x109650
	// RVA: 0x1BB0540 Offset: 0x1BB0641 VA: 0x1BB0540
	private static void DestroyNavMeshPath(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0x1096A0 Offset: 0x1097A1 VA: 0x1096A0
	// RVA: 0x1BB0590 Offset: 0x1BB0691 VA: 0x1BB0590
	public int GetCornersNonAlloc([Out] Vector3[] results) { }

	[FreeFunctionAttribute] // RVA: 0x1096F0 Offset: 0x1097F1 VA: 0x1096F0
	// RVA: 0x1BB05E0 Offset: 0x1BB06E1 VA: 0x1BB05E0
	private Vector3[] CalculateCornersInternal() { }

	[FreeFunctionAttribute] // RVA: 0x109740 Offset: 0x109841 VA: 0x109740
	// RVA: 0x1BB0630 Offset: 0x1BB0731 VA: 0x1BB0630
	private void ClearCornersInternal() { }

	// RVA: 0x1BAB4E0 Offset: 0x1BAB5E1 VA: 0x1BAB4E0
	public void ClearCorners() { }

	// RVA: 0x1BB0680 Offset: 0x1BB0781 VA: 0x1BB0680
	private void CalculateCorners() { }

	// RVA: 0x1BB0700 Offset: 0x1BB0801 VA: 0x1BB0700
	public Vector3[] get_corners() { }

	// RVA: 0x1BB0780 Offset: 0x1BB0881 VA: 0x1BB0780
	public NavMeshPathStatus get_status() { }
}

