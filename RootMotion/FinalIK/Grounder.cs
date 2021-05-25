public abstract class Grounder : MonoBehaviour // TypeDefIndex: 9423
{
	// Fields
	[TooltipAttribute] // RVA: 0x1791D0 Offset: 0x1792D1 VA: 0x1791D0
	[RangeAttribute] // RVA: 0x1791D0 Offset: 0x1792D1 VA: 0x1791D0
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x179230 Offset: 0x179331 VA: 0x179230
	public Grounding solver; // 0x20
	public Grounder.GrounderDelegate OnPreGrounder; // 0x28
	public Grounder.GrounderDelegate OnPostGrounder; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x179270 Offset: 0x179371 VA: 0x179270
	private bool <initiated>k__BackingField; // 0x38

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ResetPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA3B0 Offset: 0x1AA4B1 VA: 0x1AA3B0
	// RVA: 0x2B2FF00 Offset: 0x2B30001 VA: 0x2B2FF00
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AA3C0 Offset: 0x1AA4C1 VA: 0x1AA3C0
	// RVA: 0x2B2FF10 Offset: 0x2B30011 VA: 0x2B2FF10
	protected void set_initiated(bool value) { }

	// RVA: 0x2B2FF20 Offset: 0x2B30021 VA: 0x2B2FF20
	protected Vector3 GetSpineOffsetTarget() { }

	// RVA: 0x2B30200 Offset: 0x2B30301 VA: 0x2B30200
	protected void LogWarning(string message) { }

	// RVA: 0x2B30070 Offset: 0x2B30171 VA: 0x2B30070
	private Vector3 GetLegSpineBendVector(Grounding.Leg leg) { }

	// RVA: 0x2B30240 Offset: 0x2B30341 VA: 0x2B30240
	private Vector3 GetLegSpineTangent(Grounding.Leg leg) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OpenUserManual() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OpenScriptReference() { }

	// RVA: 0x2B30450 Offset: 0x2B30551 VA: 0x2B30450
	protected void .ctor() { }
}

