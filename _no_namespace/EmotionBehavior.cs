[Serializable]
public class EmotionBehavior : PlayableBehaviour // TypeDefIndex: 8338
{
	// Fields
	public EmotionType EmotionType; // 0x10
	public Vector3 Offset; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x16EED0 Offset: 0x16EFD1 VA: 0x16EED0
	private GameObject <BindTarget>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16EEE0 Offset: 0x16EFE1 VA: 0x16EEE0
	private CharacterModel <CharaModel>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x16EEF0 Offset: 0x16EFF1 VA: 0x16EEF0
	private EmotionEffectController <Effect>k__BackingField; // 0x30

	// Properties
	public GameObject BindTarget { get; set; }
	public CharacterModel CharaModel { get; set; }
	public EmotionEffectController Effect { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6F10 Offset: 0x1A7011 VA: 0x1A6F10
	// RVA: 0x2019070 Offset: 0x2019171 VA: 0x2019070
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F20 Offset: 0x1A7021 VA: 0x1A6F20
	// RVA: 0x2019080 Offset: 0x2019181 VA: 0x2019080
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F30 Offset: 0x1A7031 VA: 0x1A6F30
	// RVA: 0x2019090 Offset: 0x2019191 VA: 0x2019090
	public CharacterModel get_CharaModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F40 Offset: 0x1A7041 VA: 0x1A6F40
	// RVA: 0x20190A0 Offset: 0x20191A1 VA: 0x20190A0
	public void set_CharaModel(CharacterModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F50 Offset: 0x1A7051 VA: 0x1A6F50
	// RVA: 0x20190B0 Offset: 0x20191B1 VA: 0x20190B0
	public EmotionEffectController get_Effect() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F60 Offset: 0x1A7061 VA: 0x1A6F60
	// RVA: 0x20190C0 Offset: 0x20191C1 VA: 0x20190C0
	public void set_Effect(EmotionEffectController value) { }

	// RVA: 0x20190D0 Offset: 0x20191D1 VA: 0x20190D0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x20191D0 Offset: 0x20192D1 VA: 0x20191D0 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2019640 Offset: 0x2019741 VA: 0x2019640 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2019700 Offset: 0x2019801 VA: 0x2019700
	public void .ctor() { }
}

