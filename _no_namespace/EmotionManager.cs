public class EmotionManager : SingletonMonoBehaviour<EmotionManager> // TypeDefIndex: 6707
{
	// Fields
	private static readonly Dictionary<EmotionType, Prefab> m_EmotionLoaderIds; // 0x0
	private List<EmotionType> m_EntryList; // 0x18
	private Register<EmotionController> m_Register; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15EF80 Offset: 0x15F081 VA: 0x15EF80
	private bool <InitCompleted>k__BackingField; // 0x28

	// Properties
	public bool InitCompleted { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CA40 Offset: 0x19CB41 VA: 0x19CA40
	// RVA: 0x201ADB0 Offset: 0x201AEB1 VA: 0x201ADB0
	public bool get_InitCompleted() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CA50 Offset: 0x19CB51 VA: 0x19CA50
	// RVA: 0x201ADC0 Offset: 0x201AEC1 VA: 0x201ADC0
	private void set_InitCompleted(bool value) { }

	// RVA: 0x201ADD0 Offset: 0x201AED1 VA: 0x201ADD0
	public void Init() { }

	// RVA: 0x201AF10 Offset: 0x201B011 VA: 0x201AF10
	public void LoadReasource(EmotionType type, Prefab id) { }

	// RVA: 0x201B040 Offset: 0x201B141 VA: 0x201B040
	public void RemoveAll() { }

	// RVA: 0x201A090 Offset: 0x201A191 VA: 0x201A090
	public bool Create(EmotionType type, Vector3 position, Transform parent, out EmotionEffectController effect) { }

	// RVA: 0x2019A80 Offset: 0x2019B81 VA: 0x2019A80
	public bool Regist(EmotionController controller) { }

	// RVA: 0x2019C00 Offset: 0x2019D01 VA: 0x2019C00
	public bool Remove(EmotionController controller) { }

	// RVA: 0x201B1B0 Offset: 0x201B2B1 VA: 0x201B1B0
	private void OnDestroy() { }

	// RVA: 0x201B1C0 Offset: 0x201B2C1 VA: 0x201B1C0
	private void Update() { }

	// RVA: 0x201B2E0 Offset: 0x201B3E1 VA: 0x201B2E0
	public void DoStopAll() { }

	// RVA: 0x2019470 Offset: 0x2019571 VA: 0x2019470
	public static EmotionEffectController Timeline_OnBehaviourPlay(EmotionType type, Transform parent, Vector3 position) { }

	// RVA: 0x201B400 Offset: 0x201B501 VA: 0x201B400
	public void .ctor() { }

	// RVA: 0x201B4C0 Offset: 0x201B5C1 VA: 0x201B4C0
	private static void .cctor() { }
}

