public class MovementVelocity // TypeDefIndex: 6756
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15F390 Offset: 0x15F491 VA: 0x15F390
	private Vector3 <current>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x15F3A0 Offset: 0x15F4A1 VA: 0x15F3A0
	private float <maxSpeed>k__BackingField; // 0x1C
	private Vector3 force; // 0x20
	private Vector3 inpulse; // 0x2C
	private Vector3 velocityChange; // 0x38
	private Vector3 acceleration; // 0x44
	private bool isClearForce; // 0x50

	// Properties
	public Vector3 current { get; set; }
	public float maxSpeed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CCD0 Offset: 0x19CDD1 VA: 0x19CCD0
	// RVA: 0x1CDB9C0 Offset: 0x1CDBAC1 VA: 0x1CDB9C0
	public Vector3 get_current() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CCE0 Offset: 0x19CDE1 VA: 0x19CCE0
	// RVA: 0x1CDB9D0 Offset: 0x1CDBAD1 VA: 0x1CDB9D0
	public void set_current(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CCF0 Offset: 0x19CDF1 VA: 0x19CCF0
	// RVA: 0x1CDB9E0 Offset: 0x1CDBAE1 VA: 0x1CDB9E0
	public float get_maxSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CD00 Offset: 0x19CE01 VA: 0x19CD00
	// RVA: 0x1CDB9F0 Offset: 0x1CDBAF1 VA: 0x1CDB9F0
	public void set_maxSpeed(float value) { }

	// RVA: 0x1CDBA00 Offset: 0x1CDBB01 VA: 0x1CDBA00
	public void ClearForce() { }

	// RVA: 0x1CDBAC0 Offset: 0x1CDBBC1 VA: 0x1CDBAC0
	public void AddForce(Vector3 _force, ForceMode mode = 0) { }

	// RVA: 0x1CDBCB0 Offset: 0x1CDBDB1 VA: 0x1CDBCB0
	public void ApplyForce(float mass, float deltaTime) { }

	// RVA: 0x1CDBE60 Offset: 0x1CDBF61 VA: 0x1CDBE60
	public void .ctor() { }
}

