public abstract class ItemEquip : MonoBehaviour // TypeDefIndex: 7653
{
	// Fields
	[SerializeField] // RVA: 0x1687D0 Offset: 0x1688D1 VA: 0x1687D0
	public ItemID m_EquipItemID; // 0x18
	[SerializeField] // RVA: 0x1687E0 Offset: 0x1688E1 VA: 0x1687E0
	public Transform m_effectPoint; // 0x20
	private EffectID m_CurrentEffectID; // 0x28
	private ParticleSystem m_effect; // 0x30
	[SerializeField] // RVA: 0x1687F0 Offset: 0x1688F1 VA: 0x1687F0
	public List<EffectID> m_EffectID; // 0x38
	[SerializeField] // RVA: 0x168800 Offset: 0x168901 VA: 0x168800
	private MeshFadeController m_FadeController; // 0x40
	protected HumanController m_Human; // 0x48
	private HumanAttachIDEnum m_AttachID; // 0x50
	protected Dictionary<int, ParticleSystem> m_Effects; // 0x58

	// Properties
	public Transform EffectPoint { get; }
	public float FadeAlpha { get; }

	// Methods

	// RVA: 0x20D23B0 Offset: 0x20D24B1 VA: 0x20D23B0
	public Transform get_EffectPoint() { }

	// RVA: 0x20D23C0 Offset: 0x20D24C1 VA: 0x20D23C0 Slot: 4
	public virtual void Awake() { }

	// RVA: 0x20D23D0 Offset: 0x20D24D1 VA: 0x20D23D0 Slot: 5
	public virtual bool Attach(HumanController human, HumanAttachIDEnum attachId) { }

	// RVA: 0x20D2500 Offset: 0x20D2601 VA: 0x20D2500 Slot: 6
	public virtual bool Detach() { }

	// RVA: 0x20D2680 Offset: 0x20D2781 VA: 0x20D2680
	public void EraseOn() { }

	// RVA: 0x20D27A0 Offset: 0x20D28A1 VA: 0x20D27A0
	public void EraseOff() { }

	// RVA: 0x20D28C0 Offset: 0x20D29C1 VA: 0x20D28C0
	public bool ReAttach() { }

	// RVA: 0x20D28E0 Offset: 0x20D29E1 VA: 0x20D28E0 Slot: 7
	public virtual void SetVisible(bool visible) { }

	// RVA: 0x20D2970 Offset: 0x20D2A71 VA: 0x20D2970 Slot: 8
	protected virtual void OnEnable() { }

	// RVA: 0x20D2980 Offset: 0x20D2A81 VA: 0x20D2980 Slot: 9
	protected virtual void OnDisable() { }

	// RVA: 0x20D2990 Offset: 0x20D2A91 VA: 0x20D2990 Slot: 10
	protected virtual void OnDestroy() { }

	// RVA: 0x20D29A0 Offset: 0x20D2AA1 VA: 0x20D29A0
	public void Play(EffectID effectID, float scale, bool loop) { }

	// RVA: 0x20D2AD0 Offset: 0x20D2BD1 VA: 0x20D2AD0
	public void Stop() { }

	// RVA: 0x20D2BC0 Offset: 0x20D2CC1 VA: 0x20D2BC0 Slot: 11
	public virtual void PlayEffect(int no, float scale) { }

	// RVA: 0x20D2C70 Offset: 0x20D2D71 VA: 0x20D2C70 Slot: 12
	public virtual void StopEffect(int no) { }

	// RVA: 0x20D2960 Offset: 0x20D2A61 VA: 0x20D2960
	public void StopAllEffects() { }

	// RVA: 0x20D2C80 Offset: 0x20D2D81 VA: 0x20D2C80
	public float get_FadeAlpha() { }

	// RVA: 0x20D2D30 Offset: 0x20D2E31 VA: 0x20D2D30
	public void SetAlpha(float alpha) { }

	// RVA: 0x20D2DF0 Offset: 0x20D2EF1 VA: 0x20D2DF0 Slot: 13
	public virtual void SetShadowState(ShadowCastingMode shadowCastingMode) { }

	// RVA: 0x20D2EF0 Offset: 0x20D2FF1 VA: 0x20D2EF0
	protected void .ctor() { }
}

