public class Grounding.Pelvis // TypeDefIndex: 9435
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1963B0 Offset: 0x1964B1 VA: 0x1963B0
	private Vector3 <IKOffset>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1963C0 Offset: 0x1964C1 VA: 0x1963C0
	private float <heightOffset>k__BackingField; // 0x1C
	private Grounding grounding; // 0x20
	private Vector3 lastRootPosition; // 0x28
	private float damperF; // 0x34
	private bool initiated; // 0x38
	private float lastTime; // 0x3C

	// Properties
	public Vector3 IKOffset { get; set; }
	public float heightOffset { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1B54A0 Offset: 0x1B55A1 VA: 0x1B54A0
	// RVA: 0x2B3AD80 Offset: 0x2B3AE81 VA: 0x2B3AD80
	public Vector3 get_IKOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B54B0 Offset: 0x1B55B1 VA: 0x1B54B0
	// RVA: 0x2B3AD90 Offset: 0x2B3AE91 VA: 0x2B3AD90
	private void set_IKOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1B54C0 Offset: 0x1B55C1 VA: 0x1B54C0
	// RVA: 0x2B3ADA0 Offset: 0x2B3AEA1 VA: 0x2B3ADA0
	public float get_heightOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x1B54D0 Offset: 0x1B55D1 VA: 0x1B54D0
	// RVA: 0x2B3ADB0 Offset: 0x2B3AEB1 VA: 0x2B3ADB0
	private void set_heightOffset(float value) { }

	// RVA: 0x2B38620 Offset: 0x2B38721 VA: 0x2B38620
	public void Initiate(Grounding grounding) { }

	// RVA: 0x2B39320 Offset: 0x2B39421 VA: 0x2B39320
	public void Reset() { }

	// RVA: 0x2B3ADC0 Offset: 0x2B3AEC1 VA: 0x2B3ADC0
	public void OnEnable() { }

	// RVA: 0x2B390A0 Offset: 0x2B391A1 VA: 0x2B390A0
	public void Process(float lowestOffset, float highestOffset, bool isGrounded) { }

	// RVA: 0x2B384F0 Offset: 0x2B385F1 VA: 0x2B384F0
	public void .ctor() { }
}

