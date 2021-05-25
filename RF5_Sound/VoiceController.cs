public class VoiceController : AudioSourceController<SoundID> // TypeDefIndex: 9869
{
	// Fields
	private SubtitleHandler handler; // 0x70

	// Properties
	public override SoundID EmptyValue { get; }
	public override bool IsLoopClip { get; }

	// Methods

	// RVA: 0x1DA9060 Offset: 0x1DA9161 VA: 0x1DA9060 Slot: 9
	public override SoundID get_EmptyValue() { }

	// RVA: 0x1DA9070 Offset: 0x1DA9171 VA: 0x1DA9070 Slot: 17
	public override bool get_IsLoopClip() { }

	// RVA: 0x1DA90D0 Offset: 0x1DA91D1 VA: 0x1DA90D0 Slot: 12
	protected override AudioMixerGroup GetOutputMixer(SoundID id) { }

	// RVA: 0x1DA9150 Offset: 0x1DA9251 VA: 0x1DA9150 Slot: 13
	protected override void SetupBeforePlayByDataTable() { }

	// RVA: 0x1DA9200 Offset: 0x1DA9301 VA: 0x1DA9200 Slot: 14
	protected override void Loading_Enter() { }

	// RVA: 0x1DA9310 Offset: 0x1DA9411 VA: 0x1DA9310 Slot: 15
	protected override void Play_Enter() { }

	// RVA: 0x1DA93E0 Offset: 0x1DA94E1 VA: 0x1DA93E0 Slot: 20
	protected override void Done_Enter() { }

	// RVA: 0x1DA9460 Offset: 0x1DA9561 VA: 0x1DA9460
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD2D0 Offset: 0x1AD3D1 VA: 0x1AD2D0
	// RVA: 0x1DA94D0 Offset: 0x1DA95D1 VA: 0x1DA94D0
	private void <Loading_Enter>b__6_0(int backid, AudioClip clip) { }
}

