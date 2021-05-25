public class WindVolume : ForceProvider // TypeDefIndex: 9122
{
	// Fields
	[RangeAttribute] // RVA: 0x177340 Offset: 0x177441 VA: 0x177340
	public float weight; // 0x18
	public float strength; // 0x1C
	public float amplitude; // 0x20
	public float period; // 0x24
	public float spinPeriod; // 0x28
	public float peakDistance; // 0x2C
	private const float PI2 = 6.2831855;
	private float positionalMultiplier; // 0x30
	private float currentTime; // 0x34
	private float timeFactor; // 0x38
	private float spinTime; // 0x3C
	private Vector3 offsetVector; // 0x40

	// Methods

	// RVA: 0x23A82B0 Offset: 0x23A83B1 VA: 0x23A82B0 Slot: 4
	public override Vector3 GetForceOnBone(SpringBone springBone) { }

	// RVA: 0x23A8540 Offset: 0x23A8641 VA: 0x23A8540
	private float GetPositionalFactor(float x, float y) { }

	// RVA: 0x23A85E0 Offset: 0x23A86E1 VA: 0x23A85E0
	private float AddPeriodically(float currentValue, float deltaValue, float period) { }

	// RVA: 0x23A8600 Offset: 0x23A8701 VA: 0x23A8600
	private void Update() { }

	// RVA: 0x23A88C0 Offset: 0x23A89C1 VA: 0x23A88C0
	private void OnDrawGizmos() { }

	// RVA: 0x23A8BF0 Offset: 0x23A8CF1 VA: 0x23A8BF0
	public void .ctor() { }
}

