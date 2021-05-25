public class CharaVoiceController<T> : ActorVoiceController // TypeDefIndex: 6610
{
	// Fields
	[SerializeField] // RVA: 0x15DAB0 Offset: 0x15DBB1 VA: 0x15DAB0
	protected T chara; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15DAC0 Offset: 0x15DBC1 VA: 0x15DAC0
	private readonly CharID <CharID>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15DAD0 Offset: 0x15DBD1 VA: 0x15DAD0
	private readonly int <Variation>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15DAE0 Offset: 0x15DBE1 VA: 0x15DAE0
	private Dictionary<VoiceGroup, CharaVoiceGroupData> <VoiceTable>k__BackingField; // 0x0

	// Properties
	protected virtual CharID CharID { get; }
	protected virtual int Variation { get; }
	public Dictionary<VoiceGroup, CharaVoiceGroupData> VoiceTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19BA40 Offset: 0x19BB41 VA: 0x19BA40
	// RVA: -1 Offset: -1 Slot: 22
	protected virtual CharID get_CharID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AB00 Offset: 0x257AC01 VA: 0x257AB00
	|-CharaVoiceController<object>.get_CharID
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19BA50 Offset: 0x19BB51 VA: 0x19BA50
	// RVA: -1 Offset: -1 Slot: 23
	protected virtual int get_Variation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AB10 Offset: 0x257AC11 VA: 0x257AB10
	|-CharaVoiceController<MonsterControllerBase>.get_Variation
	|-CharaVoiceController<object>.get_Variation
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19BA60 Offset: 0x19BB61 VA: 0x19BA60
	// RVA: -1 Offset: -1
	public Dictionary<VoiceGroup, CharaVoiceGroupData> get_VoiceTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AB20 Offset: 0x257AC21 VA: 0x257AB20
	|-CharaVoiceController<object>.get_VoiceTable
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19BA70 Offset: 0x19BB71 VA: 0x19BA70
	// RVA: -1 Offset: -1
	private void set_VoiceTable(Dictionary<VoiceGroup, CharaVoiceGroupData> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AB30 Offset: 0x257AC31 VA: 0x257AB30
	|-CharaVoiceController<object>.set_VoiceTable
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AB40 Offset: 0x257AC41 VA: 0x257AB40
	|-CharaVoiceController<HumanController>.Awake
	|-CharaVoiceController<MonsterControllerBase>.Awake
	|-CharaVoiceController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 24
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AC10 Offset: 0x257AD11 VA: 0x257AC10
	|-CharaVoiceController<HumanController>.OnEnable
	|-CharaVoiceController<MonsterControllerBase>.OnEnable
	|-CharaVoiceController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257ACF0 Offset: 0x257ADF1 VA: 0x257ACF0
	|-CharaVoiceController<HumanController>.OnDisable
	|-CharaVoiceController<MonsterControllerBase>.OnDisable
	|-CharaVoiceController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257ADC0 Offset: 0x257AEC1 VA: 0x257ADC0
	|-CharaVoiceController<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override AudioSource ReadyAudioSourceComponent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AEE0 Offset: 0x257AFE1 VA: 0x257AEE0
	|-CharaVoiceController<HumanController>.ReadyAudioSourceComponent
	|-CharaVoiceController<MonsterControllerBase>.ReadyAudioSourceComponent
	|-CharaVoiceController<object>.ReadyAudioSourceComponent
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public override void DoPlayGroupVoice(VoiceGroup group) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B070 Offset: 0x257B171 VA: 0x257B070
	|-CharaVoiceController<HumanController>.DoPlayGroupVoice
	|-CharaVoiceController<MonsterControllerBase>.DoPlayGroupVoice
	|-CharaVoiceController<object>.DoPlayGroupVoice
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257B1D0 Offset: 0x257B2D1 VA: 0x257B1D0
	|-CharaVoiceController<HumanController>..ctor
	|-CharaVoiceController<MonsterControllerBase>..ctor
	|-CharaVoiceController<object>..ctor
	*/
}

