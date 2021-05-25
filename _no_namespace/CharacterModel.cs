public class CharacterModel : MonoBehaviour // TypeDefIndex: 6614
{
	// Fields
	[SerializeField] // RVA: 0x15DE90 Offset: 0x15DF91 VA: 0x15DE90
	protected RuntimeAnimatorController m_RuntimeAnimatorController; // 0x18
	[SerializeField] // RVA: 0x15DEA0 Offset: 0x15DFA1 VA: 0x15DEA0
	protected Avatar m_Avatar; // 0x20
	[SerializeField] // RVA: 0x15DEB0 Offset: 0x15DFB1 VA: 0x15DEB0
	protected AudioSource m_AudioSource; // 0x28
	[SerializeField] // RVA: 0x15DEC0 Offset: 0x15DFC1 VA: 0x15DEC0
	protected MeshFadeController m_FadeController; // 0x30
	[SerializeField] // RVA: 0x15DED0 Offset: 0x15DFD1 VA: 0x15DED0
	protected CharacterNearCullingController m_NearCullingController; // 0x38
	[SerializeField] // RVA: 0x15DEE0 Offset: 0x15DFE1 VA: 0x15DEE0
	public Transform StatusEffect_Point; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15DEF0 Offset: 0x15DFF1 VA: 0x15DEF0
	private bool <FadeEnable>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15DF00 Offset: 0x15E001 VA: 0x15DF00
	private float <FadeAlpha>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x15DF10 Offset: 0x15E011 VA: 0x15DF10
	private float <FadeWeight>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15DF20 Offset: 0x15E021 VA: 0x15DF20
	private readonly Transform <LookPoint>k__BackingField; // 0x58
	private int LoaderId; // 0x60

	// Properties
	public RuntimeAnimatorController RuntimeAnimatorController { get; }
	public Avatar Avatar { get; }
	public AudioSource AudioSource { get; }
	public bool FadeEnable { get; set; }
	public float FadeAlpha { get; set; }
	public float FadeWeight { get; set; }
	public float CurrentFadeAlpha { get; }
	public virtual Transform LookPoint { get; }

	// Methods

	// RVA: 0x1E4E0C0 Offset: 0x1E4E1C1 VA: 0x1E4E0C0
	public RuntimeAnimatorController get_RuntimeAnimatorController() { }

	// RVA: 0x1E4E0D0 Offset: 0x1E4E1D1 VA: 0x1E4E0D0
	public Avatar get_Avatar() { }

	// RVA: 0x1E4E0E0 Offset: 0x1E4E1E1 VA: 0x1E4E0E0
	public AudioSource get_AudioSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD60 Offset: 0x19BE61 VA: 0x19BD60
	// RVA: 0x1E4E0F0 Offset: 0x1E4E1F1 VA: 0x1E4E0F0
	public bool get_FadeEnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD70 Offset: 0x19BE71 VA: 0x19BD70
	// RVA: 0x1E4E100 Offset: 0x1E4E201 VA: 0x1E4E100
	protected void set_FadeEnable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD80 Offset: 0x19BE81 VA: 0x19BD80
	// RVA: 0x1E4E110 Offset: 0x1E4E211 VA: 0x1E4E110
	public float get_FadeAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD90 Offset: 0x19BE91 VA: 0x19BD90
	// RVA: 0x1E4E120 Offset: 0x1E4E221 VA: 0x1E4E120
	protected void set_FadeAlpha(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDA0 Offset: 0x19BEA1 VA: 0x19BDA0
	// RVA: 0x1E4E130 Offset: 0x1E4E231 VA: 0x1E4E130
	public float get_FadeWeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDB0 Offset: 0x19BEB1 VA: 0x19BDB0
	// RVA: 0x1E4E140 Offset: 0x1E4E241 VA: 0x1E4E140
	protected void set_FadeWeight(float value) { }

	// RVA: 0x1E4E150 Offset: 0x1E4E251 VA: 0x1E4E150
	public float get_CurrentFadeAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BDC0 Offset: 0x19BEC1 VA: 0x19BDC0
	// RVA: 0x1E4E1E0 Offset: 0x1E4E2E1 VA: 0x1E4E1E0 Slot: 4
	public virtual Transform get_LookPoint() { }

	// RVA: 0x1E4E1F0 Offset: 0x1E4E2F1 VA: 0x1E4E1F0
	public void SetLoaderId(int id) { }

	// RVA: 0x1E4E200 Offset: 0x1E4E301 VA: 0x1E4E200
	public void RemoveAsset() { }

	// RVA: 0x1E4E280 Offset: 0x1E4E381 VA: 0x1E4E280 Slot: 5
	protected virtual void Awake() { }

	// RVA: 0x1E4E3C0 Offset: 0x1E4E4C1 VA: 0x1E4E3C0 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x1E4E3D0 Offset: 0x1E4E4D1 VA: 0x1E4E3D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E4E490 Offset: 0x1E4E591 VA: 0x1E4E490 Slot: 7
	protected virtual void OnDestroy() { }

	// RVA: 0x1E4E510 Offset: 0x1E4E611 VA: 0x1E4E510 Slot: 8
	public virtual void SetFadeEnable(bool enable) { }

	// RVA: 0x1E4E650 Offset: 0x1E4E751 VA: 0x1E4E650 Slot: 9
	public virtual void SetFadeAlpha(float alpha) { }

	// RVA: 0x1E4E7A0 Offset: 0x1E4E8A1 VA: 0x1E4E7A0 Slot: 10
	public virtual void SetFadeWeight(float weight) { }

	// RVA: 0x1E4E8F0 Offset: 0x1E4E9F1 VA: 0x1E4E8F0 Slot: 11
	public virtual void SetShadowState(ShadowCastingMode shadowCastingMode) { }

	// RVA: 0x1E4D590 Offset: 0x1E4D691 VA: 0x1E4D590
	public void SetNearCullingEnable(bool enable) { }

	// RVA: 0x1E4E9F0 Offset: 0x1E4EAF1 VA: 0x1E4E9F0
	public void .ctor() { }
}

