public class YawnController : MonoBehaviour // TypeDefIndex: 6801
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15FA70 Offset: 0x15FB71 VA: 0x15FA70
	private float <Elapsed>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15FA80 Offset: 0x15FB81 VA: 0x15FA80
	private float <Duration>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x15FA90 Offset: 0x15FB91 VA: 0x15FA90
	private bool <IsPlaying>k__BackingField; // 0x20

	// Properties
	public float Elapsed { get; set; }
	public float Duration { get; set; }
	public bool IsPlaying { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D270 Offset: 0x19D371 VA: 0x19D270
	// RVA: 0x26A2C90 Offset: 0x26A2D91 VA: 0x26A2C90
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D280 Offset: 0x19D381 VA: 0x19D280
	// RVA: 0x26A2CA0 Offset: 0x26A2DA1 VA: 0x26A2CA0
	protected void set_Elapsed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D290 Offset: 0x19D391 VA: 0x19D290
	// RVA: 0x26A2CB0 Offset: 0x26A2DB1 VA: 0x26A2CB0
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D2A0 Offset: 0x19D3A1 VA: 0x19D2A0
	// RVA: 0x26A2CC0 Offset: 0x26A2DC1 VA: 0x26A2CC0
	protected void set_Duration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D2B0 Offset: 0x19D3B1 VA: 0x19D2B0
	// RVA: 0x26A2CD0 Offset: 0x26A2DD1 VA: 0x26A2CD0
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D2C0 Offset: 0x19D3C1 VA: 0x19D2C0
	// RVA: 0x26A2CE0 Offset: 0x26A2DE1 VA: 0x26A2CE0
	protected void set_IsPlaying(bool value) { }

	// RVA: 0x26A2CF0 Offset: 0x26A2DF1 VA: 0x26A2CF0 Slot: 4
	public virtual bool CanPlay() { }

	// RVA: 0x26A2D00 Offset: 0x26A2E01 VA: 0x26A2D00 Slot: 5
	public virtual bool DoPlay(float duration) { }

	// RVA: 0x26A2D60 Offset: 0x26A2E61 VA: 0x26A2D60 Slot: 6
	public virtual bool DoStop() { }

	// RVA: 0x26A2D70 Offset: 0x26A2E71 VA: 0x26A2D70 Slot: 7
	public virtual void DoCancel() { }

	// RVA: 0x26A2D80 Offset: 0x26A2E81 VA: 0x26A2D80 Slot: 8
	public virtual void OnUpdate() { }

	// RVA: 0x26A2DF0 Offset: 0x26A2EF1 VA: 0x26A2DF0
	public void .ctor() { }
}

