public class WkiMove : MonoBehaviour // TypeDefIndex: 10311
{
	// Fields
	[SerializeField] // RVA: 0x181230 Offset: 0x181331 VA: 0x181230
	private Vector3 PosOffset; // 0x18
	[SerializeField] // RVA: 0x181240 Offset: 0x181341 VA: 0x181240
	private Vector3 _velocity; // 0x24
	private Vector3 localVelocity; // 0x30
	[SerializeField] // RVA: 0x181250 Offset: 0x181351 VA: 0x181250
	private Vector3 _gravity; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181260 Offset: 0x181361 VA: 0x181260
	private Vector3 <Velocity>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181270 Offset: 0x181371 VA: 0x181270
	private Vector3 <Gravity>k__BackingField; // 0x54

	// Properties
	public Vector3 Velocity { get; set; }
	public Vector3 Gravity { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AE170 Offset: 0x1AE271 VA: 0x1AE170
	// RVA: 0x1D4E000 Offset: 0x1D4E101 VA: 0x1D4E000
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE180 Offset: 0x1AE281 VA: 0x1AE180
	// RVA: 0x1D4E010 Offset: 0x1D4E111 VA: 0x1D4E010
	protected void set_Velocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE190 Offset: 0x1AE291 VA: 0x1AE190
	// RVA: 0x1D4E020 Offset: 0x1D4E121 VA: 0x1D4E020
	public Vector3 get_Gravity() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE1A0 Offset: 0x1AE2A1 VA: 0x1AE1A0
	// RVA: 0x1D4E030 Offset: 0x1D4E131 VA: 0x1D4E030
	protected void set_Gravity(Vector3 value) { }

	// RVA: 0x1D4D060 Offset: 0x1D4D161 VA: 0x1D4D060
	public void Reset(Vector3 pos, Quaternion dir) { }

	// RVA: 0x1D4D3A0 Offset: 0x1D4D4A1 VA: 0x1D4D3A0
	public void OnUpdate() { }

	// RVA: 0x1D4E040 Offset: 0x1D4E141 VA: 0x1D4E040
	private void UpdateAngle() { }

	// RVA: 0x1D4E1E0 Offset: 0x1D4E2E1 VA: 0x1D4E1E0
	private float getAngle(float x, float y) { }

	// RVA: 0x1D4E270 Offset: 0x1D4E371 VA: 0x1D4E270
	public void .ctor() { }
}

