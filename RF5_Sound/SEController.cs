public class SEController : AudioSourceController<SoundID> // TypeDefIndex: 9868
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17F990 Offset: 0x17FA91 VA: 0x17F990
	private bool <IsLoopMode>k__BackingField; // 0x6F
	[CompilerGeneratedAttribute] // RVA: 0x17F9A0 Offset: 0x17FAA1 VA: 0x17F9A0
	private bool <IsOverrideLoop>k__BackingField; // 0x70

	// Properties
	public override SoundID EmptyValue { get; }
	public override bool IsLoopClip { get; }
	private bool IsLoopMode { get; set; }
	private bool IsOverrideLoop { get; set; }

	// Methods

	// RVA: 0x1DA8B80 Offset: 0x1DA8C81 VA: 0x1DA8B80 Slot: 9
	public override SoundID get_EmptyValue() { }

	// RVA: 0x1DA8B90 Offset: 0x1DA8C91 VA: 0x1DA8B90 Slot: 17
	public override bool get_IsLoopClip() { }

	// RVA: 0x1DA85C0 Offset: 0x1DA86C1 VA: 0x1DA85C0 Slot: 10
	public override void DoPlay(SoundID id, int priority = 0) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD280 Offset: 0x1AD381 VA: 0x1AD280
	// RVA: 0x1DA8C10 Offset: 0x1DA8D11 VA: 0x1DA8C10
	private bool get_IsLoopMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD290 Offset: 0x1AD391 VA: 0x1AD290
	// RVA: 0x1DA8C20 Offset: 0x1DA8D21 VA: 0x1DA8C20
	private void set_IsLoopMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD2A0 Offset: 0x1AD3A1 VA: 0x1AD2A0
	// RVA: 0x1DA8C30 Offset: 0x1DA8D31 VA: 0x1DA8C30
	private bool get_IsOverrideLoop() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD2B0 Offset: 0x1AD3B1 VA: 0x1AD2B0
	// RVA: 0x1DA8C40 Offset: 0x1DA8D41 VA: 0x1DA8C40
	private void set_IsOverrideLoop(bool value) { }

	// RVA: 0x1DA8C50 Offset: 0x1DA8D51 VA: 0x1DA8C50
	public void OverrideLoopMode(bool isLoop) { }

	// RVA: 0x1DA8CD0 Offset: 0x1DA8DD1 VA: 0x1DA8CD0 Slot: 12
	protected override AudioMixerGroup GetOutputMixer(SoundID id) { }

	// RVA: 0x1DA8DE0 Offset: 0x1DA8EE1 VA: 0x1DA8DE0 Slot: 13
	protected override void SetupBeforePlayByDataTable() { }

	// RVA: 0x1DA8950 Offset: 0x1DA8A51 VA: 0x1DA8950 Slot: 20
	protected override void Done_Enter() { }

	// RVA: 0x1DA8E90 Offset: 0x1DA8F91 VA: 0x1DA8E90 Slot: 14
	protected override void Loading_Enter() { }

	// RVA: 0x1DA8B10 Offset: 0x1DA8C11 VA: 0x1DA8B10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD2C0 Offset: 0x1AD3C1 VA: 0x1AD2C0
	// RVA: 0x1DA8FA0 Offset: 0x1DA90A1 VA: 0x1DA8FA0
	private void <Loading_Enter>b__17_0(int backid, AudioClip clip) { }
}

