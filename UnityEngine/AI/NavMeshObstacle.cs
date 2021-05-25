[NativeHeaderAttribute] // RVA: 0x109190 Offset: 0x109291 VA: 0x109190
[MovedFromAttribute] // RVA: 0x109190 Offset: 0x109291 VA: 0x109190
public sealed class NavMeshObstacle : Behaviour // TypeDefIndex: 3772
{
	// Properties
	public float height { get; set; }
	public float radius { get; set; }
	public Vector3 velocity { get; set; }
	public bool carving { get; set; }
	public bool carveOnlyStationary { get; set; }
	[NativePropertyAttribute] // RVA: 0x10A360 Offset: 0x10A461 VA: 0x10A360
	public float carvingMoveThreshold { get; set; }
	[NativePropertyAttribute] // RVA: 0x10A3A0 Offset: 0x10A4A1 VA: 0x10A3A0
	public float carvingTimeToStationary { get; set; }
	public NavMeshObstacleShape shape { get; set; }
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }

	// Methods

	// RVA: 0x1BAFB50 Offset: 0x1BAFC51 VA: 0x1BAFB50
	public float get_height() { }

	// RVA: 0x1BAFBA0 Offset: 0x1BAFCA1 VA: 0x1BAFBA0
	public void set_height(float value) { }

	// RVA: 0x1BAFBF0 Offset: 0x1BAFCF1 VA: 0x1BAFBF0
	public float get_radius() { }

	// RVA: 0x1BAFC40 Offset: 0x1BAFD41 VA: 0x1BAFC40
	public void set_radius(float value) { }

	// RVA: 0x1BAFC90 Offset: 0x1BAFD91 VA: 0x1BAFC90
	public Vector3 get_velocity() { }

	// RVA: 0x1BAFD40 Offset: 0x1BAFE41 VA: 0x1BAFD40
	public void set_velocity(Vector3 value) { }

	// RVA: 0x1BAFDF0 Offset: 0x1BAFEF1 VA: 0x1BAFDF0
	public bool get_carving() { }

	// RVA: 0x1BAFE40 Offset: 0x1BAFF41 VA: 0x1BAFE40
	public void set_carving(bool value) { }

	// RVA: 0x1BAFE90 Offset: 0x1BAFF91 VA: 0x1BAFE90
	public bool get_carveOnlyStationary() { }

	// RVA: 0x1BAFEE0 Offset: 0x1BAFFE1 VA: 0x1BAFEE0
	public void set_carveOnlyStationary(bool value) { }

	// RVA: 0x1BAFF30 Offset: 0x1BB0031 VA: 0x1BAFF30
	public float get_carvingMoveThreshold() { }

	// RVA: 0x1BAFF80 Offset: 0x1BB0081 VA: 0x1BAFF80
	public void set_carvingMoveThreshold(float value) { }

	// RVA: 0x1BAFFD0 Offset: 0x1BB00D1 VA: 0x1BAFFD0
	public float get_carvingTimeToStationary() { }

	// RVA: 0x1BB0020 Offset: 0x1BB0121 VA: 0x1BB0020
	public void set_carvingTimeToStationary(float value) { }

	// RVA: 0x1BB0070 Offset: 0x1BB0171 VA: 0x1BB0070
	public NavMeshObstacleShape get_shape() { }

	// RVA: 0x1BB00C0 Offset: 0x1BB01C1 VA: 0x1BB00C0
	public void set_shape(NavMeshObstacleShape value) { }

	// RVA: 0x1BB0110 Offset: 0x1BB0211 VA: 0x1BB0110
	public Vector3 get_center() { }

	// RVA: 0x1BB01C0 Offset: 0x1BB02C1 VA: 0x1BB01C0
	public void set_center(Vector3 value) { }

	[FreeFunctionAttribute] // RVA: 0x109CA0 Offset: 0x109DA1 VA: 0x109CA0
	// RVA: 0x1BB0270 Offset: 0x1BB0371 VA: 0x1BB0270
	public Vector3 get_size() { }

	[FreeFunctionAttribute] // RVA: 0x109CF0 Offset: 0x109DF1 VA: 0x109CF0
	// RVA: 0x1BB0320 Offset: 0x1BB0421 VA: 0x1BB0320
	public void set_size(Vector3 value) { }

	[FreeFunctionAttribute] // RVA: 0x109D40 Offset: 0x109E41 VA: 0x109D40
	// RVA: 0x1BB03D0 Offset: 0x1BB04D1 VA: 0x1BB03D0
	internal void FitExtents() { }

	// RVA: 0x1BB0420 Offset: 0x1BB0521 VA: 0x1BB0420
	public void .ctor() { }

	// RVA: 0x1BAFCF0 Offset: 0x1BAFDF1 VA: 0x1BAFCF0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x1BAFDA0 Offset: 0x1BAFEA1 VA: 0x1BAFDA0
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x1BB0170 Offset: 0x1BB0271 VA: 0x1BB0170
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x1BB0220 Offset: 0x1BB0321 VA: 0x1BB0220
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x1BB02D0 Offset: 0x1BB03D1 VA: 0x1BB02D0
	private void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x1BB0380 Offset: 0x1BB0481 VA: 0x1BB0380
	private void set_size_Injected(ref Vector3 value) { }
}

