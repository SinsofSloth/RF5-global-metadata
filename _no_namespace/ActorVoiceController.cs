public class ActorVoiceController : VoiceController // TypeDefIndex: 6609
{
	// Fields
	[SerializeField] // RVA: 0x15DA90 Offset: 0x15DB91 VA: 0x15DA90
	protected SoundID currentSoundID; // 0x78
	protected CharaVoiceDataTable m_VoiceDataTable; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x15DAA0 Offset: 0x15DBA1 VA: 0x15DAA0
	private static VoiceGroupDataTable <VoiceGroup>k__BackingField; // 0x0

	// Properties
	public static VoiceGroupDataTable VoiceGroup { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19BA20 Offset: 0x19BB21 VA: 0x19BA20
	// RVA: 0x1BF3E60 Offset: 0x1BF3F61 VA: 0x1BF3E60
	public static VoiceGroupDataTable get_VoiceGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BA30 Offset: 0x19BB31 VA: 0x19BA30
	// RVA: 0x1BF3EB0 Offset: 0x1BF3FB1 VA: 0x1BF3EB0
	private static void set_VoiceGroup(VoiceGroupDataTable value) { }

	// RVA: 0x1BF3F10 Offset: 0x1BF4011 VA: 0x1BF3F10 Slot: 21
	public virtual void DoPlayGroupVoice(VoiceGroup group) { }

	// RVA: 0x1BF3F20 Offset: 0x1BF4021 VA: 0x1BF3F20
	protected SoundID GetRandomSoundID(CharaVoiceGroupData table) { }

	// RVA: 0x1BF4120 Offset: 0x1BF4221 VA: 0x1BF4120
	public void .ctor() { }
}

