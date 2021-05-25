public class AvoidController : MonoBehaviour // TypeDefIndex: 6564
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15D600 Offset: 0x15D701 VA: 0x15D600
	private float <Elapsed>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15D610 Offset: 0x15D711 VA: 0x15D610
	private bool <IsPlaying>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x15D620 Offset: 0x15D721 VA: 0x15D620
	private bool <IsAnimation>k__BackingField; // 0x1D

	// Properties
	public float Elapsed { get; set; }
	public bool IsPlaying { get; set; }
	public bool IsAnimation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B700 Offset: 0x19B801 VA: 0x19B700
	// RVA: 0x2154BF0 Offset: 0x2154CF1 VA: 0x2154BF0
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B710 Offset: 0x19B811 VA: 0x19B710
	// RVA: 0x2154C00 Offset: 0x2154D01 VA: 0x2154C00
	protected void set_Elapsed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B720 Offset: 0x19B821 VA: 0x19B720
	// RVA: 0x2154C10 Offset: 0x2154D11 VA: 0x2154C10
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B730 Offset: 0x19B831 VA: 0x19B730
	// RVA: 0x2154C20 Offset: 0x2154D21 VA: 0x2154C20
	protected void set_IsPlaying(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B740 Offset: 0x19B841 VA: 0x19B740
	// RVA: 0x2154C30 Offset: 0x2154D31 VA: 0x2154C30
	public bool get_IsAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B750 Offset: 0x19B851 VA: 0x19B750
	// RVA: 0x2154C40 Offset: 0x2154D41 VA: 0x2154C40
	protected void set_IsAnimation(bool value) { }

	// RVA: 0x2154C50 Offset: 0x2154D51 VA: 0x2154C50 Slot: 4
	public virtual bool CanPlay() { }

	// RVA: 0x2154C60 Offset: 0x2154D61 VA: 0x2154C60 Slot: 5
	public virtual bool DoPlay() { }

	// RVA: 0x2154C80 Offset: 0x2154D81 VA: 0x2154C80 Slot: 6
	public virtual bool DoStop() { }

	// RVA: 0x2154C90 Offset: 0x2154D91 VA: 0x2154C90 Slot: 7
	public virtual void DoCancel() { }

	// RVA: 0x2154CA0 Offset: 0x2154DA1 VA: 0x2154CA0 Slot: 8
	public virtual void OnUpdate() { }

	// RVA: 0x2154CE0 Offset: 0x2154DE1 VA: 0x2154CE0
	public void .ctor() { }
}

