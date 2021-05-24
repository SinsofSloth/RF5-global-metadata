public class BGMController : AudioSourceController<BGMID> // TypeDefIndex: 9866
{
	// Properties
	public override BGMID EmptyValue { get; }
	public override bool IsLoopClip { get; }

	// Methods

	// RVA: 0x1DA7F80 Offset: 0x1DA8081 VA: 0x1DA7F80 Slot: 9
	public override BGMID get_EmptyValue() { }

	// RVA: 0x1DA7F90 Offset: 0x1DA8091 VA: 0x1DA7F90 Slot: 17
	public override bool get_IsLoopClip() { }

	// RVA: 0x1DA7FF0 Offset: 0x1DA80F1 VA: 0x1DA7FF0 Slot: 12
	protected override AudioMixerGroup GetOutputMixer(BGMID id) { }

	// RVA: 0x1DA8070 Offset: 0x1DA8171 VA: 0x1DA8070 Slot: 14
	protected override void Loading_Enter() { }

	// RVA: 0x1DA8180 Offset: 0x1DA8281 VA: 0x1DA8180 Slot: 13
	protected override void SetupBeforePlayByDataTable() { }

	// RVA: 0x1DA8190 Offset: 0x1DA8291 VA: 0x1DA8190
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD250 Offset: 0x1AD351 VA: 0x1AD250
	// RVA: 0x1DA8200 Offset: 0x1DA8301 VA: 0x1DA8200
	private void <Loading_Enter>b__5_0(int backid, AudioClip clip) { }
}

