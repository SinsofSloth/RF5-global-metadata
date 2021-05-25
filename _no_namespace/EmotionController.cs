public class EmotionController : MonoBehaviour // TypeDefIndex: 8956
{
	// Fields
	protected const float DefaultPlayDuration = 1;
	private static readonly Dictionary<EmotionType, float> m_DurationList; // 0x0
	[SerializeField] // RVA: 0x174E90 Offset: 0x174F91 VA: 0x174E90
	protected Transform m_effectParent; // 0x18
	protected EmotionEffectController m_effect; // 0x20
	protected Action m_onStop; // 0x28
	protected float m_Duration; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x174EA0 Offset: 0x174FA1 VA: 0x174EA0
	private EmotionType <CurrentEmotionType>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x174EB0 Offset: 0x174FB1 VA: 0x174EB0
	private float <Elapsed>k__BackingField; // 0x38

	// Properties
	public EmotionType CurrentEmotionType { get; set; }
	public bool IsPlaying { get; }
	public float Elapsed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A93C0 Offset: 0x1A94C1 VA: 0x1A93C0
	// RVA: 0x20198F0 Offset: 0x20199F1 VA: 0x20198F0
	public EmotionType get_CurrentEmotionType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A93D0 Offset: 0x1A94D1 VA: 0x1A93D0
	// RVA: 0x2019900 Offset: 0x2019A01 VA: 0x2019900
	protected void set_CurrentEmotionType(EmotionType value) { }

	// RVA: 0x2019910 Offset: 0x2019A11 VA: 0x2019910
	public bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A93E0 Offset: 0x1A94E1 VA: 0x1A93E0
	// RVA: 0x2019920 Offset: 0x2019A21 VA: 0x2019920
	public float get_Elapsed() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A93F0 Offset: 0x1A94F1 VA: 0x1A93F0
	// RVA: 0x2019930 Offset: 0x2019A31 VA: 0x2019930
	protected void set_Elapsed(float value) { }

	// RVA: 0x2019940 Offset: 0x2019A41 VA: 0x2019940 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x2019980 Offset: 0x2019A81 VA: 0x2019980 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x2019AF0 Offset: 0x2019BF1 VA: 0x2019AF0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2019C70 Offset: 0x2019D71 VA: 0x2019C70 Slot: 7
	public virtual void OnUpdate() { }

	// RVA: 0x2019DA0 Offset: 0x2019EA1 VA: 0x2019DA0 Slot: 8
	public virtual void Init(Transform point) { }

	// RVA: 0x2019DB0 Offset: 0x2019EB1 VA: 0x2019DB0 Slot: 9
	public virtual bool DoPlay(EmotionType emotionType, Vector3 offset, Action onStop) { }

	// RVA: 0x201A310 Offset: 0x201A411 VA: 0x201A310
	public bool DoPlay(EmotionType emotionType, Action onStop) { }

	// RVA: 0x201A3A0 Offset: 0x201A4A1 VA: 0x201A3A0 Slot: 10
	public virtual bool DoStop() { }

	// RVA: 0x201A490 Offset: 0x201A591 VA: 0x201A490 Slot: 11
	public virtual bool DoDelete() { }

	// RVA: 0x201A660 Offset: 0x201A761 VA: 0x201A660
	public void .ctor() { }

	// RVA: 0x201A670 Offset: 0x201A771 VA: 0x201A670
	private static void .cctor() { }
}

