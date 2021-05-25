public class DamageText : MonoBehaviour // TypeDefIndex: 8952
{
	// Fields
	private static DamageText.MoveType lastMoveType; // 0x0
	public Vector3 position; // 0x18
	public int DamageValue; // 0x24
	public Color TextColor; // 0x28
	public UIDamageType UIDamageType; // 0x38
	[SerializeField] // RVA: 0x174D80 Offset: 0x174E81 VA: 0x174D80
	private float dispTime; // 0x3C
	[SerializeField] // RVA: 0x174D90 Offset: 0x174E91 VA: 0x174D90
	private float fadeTime; // 0x40
	[SerializeField] // RVA: 0x174DA0 Offset: 0x174EA1 VA: 0x174DA0
	private float delayTimeForFriendlyPoint; // 0x44
	[SerializeField] // RVA: 0x174DB0 Offset: 0x174EB1 VA: 0x174DB0
	private float fadeMoveSpeed; // 0x48
	[SerializeField] // RVA: 0x174DC0 Offset: 0x174EC1 VA: 0x174DC0
	private AnimationCurve LRAnimationCurve; // 0x50
	private DamageText.MoveType moveType; // 0x58
	[SerializeField] // RVA: 0x174DD0 Offset: 0x174ED1 VA: 0x174DD0
	private TextMeshProUGUI TextMesh; // 0x60
	[SerializeField] // RVA: 0x174DE0 Offset: 0x174EE1 VA: 0x174DE0
	private TMP_SpriteAsset[] TMP_SpriteAsset; // 0x68
	private float lifeTime; // 0x70
	private float delaytime; // 0x74
	private RectTransform rectTransform; // 0x78
	private Vector3 addPos; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x174DF0 Offset: 0x174EF1 VA: 0x174DF0
	private bool <IsCritical>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x174E00 Offset: 0x174F01 VA: 0x174E00
	private bool <IsWeakAtk>k__BackingField; // 0x8D
	[CompilerGeneratedAttribute] // RVA: 0x174E10 Offset: 0x174F11 VA: 0x174E10
	private bool <IsResistAtk>k__BackingField; // 0x8E
	private float expandMax; // 0x90
	private float animTimeCount; // 0x94

	// Properties
	public bool IsCritical { get; set; }
	public bool IsWeakAtk { get; set; }
	public bool IsResistAtk { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9360 Offset: 0x1A9461 VA: 0x1A9360
	// RVA: 0x1CAAFA0 Offset: 0x1CAB0A1 VA: 0x1CAAFA0
	public bool get_IsCritical() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9370 Offset: 0x1A9471 VA: 0x1A9370
	// RVA: 0x1CAAFB0 Offset: 0x1CAB0B1 VA: 0x1CAAFB0
	public void set_IsCritical(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9380 Offset: 0x1A9481 VA: 0x1A9380
	// RVA: 0x1CAAFC0 Offset: 0x1CAB0C1 VA: 0x1CAAFC0
	public bool get_IsWeakAtk() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9390 Offset: 0x1A9491 VA: 0x1A9390
	// RVA: 0x1CAAFD0 Offset: 0x1CAB0D1 VA: 0x1CAAFD0
	public void set_IsWeakAtk(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A93A0 Offset: 0x1A94A1 VA: 0x1A93A0
	// RVA: 0x1CAAFE0 Offset: 0x1CAB0E1 VA: 0x1CAAFE0
	public bool get_IsResistAtk() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A93B0 Offset: 0x1A94B1 VA: 0x1A93B0
	// RVA: 0x1CAAFF0 Offset: 0x1CAB0F1 VA: 0x1CAAFF0
	public void set_IsResistAtk(bool value) { }

	// RVA: 0x1CAB000 Offset: 0x1CAB101 VA: 0x1CAB000
	public void Init() { }

	// RVA: 0x1CAB060 Offset: 0x1CAB161 VA: 0x1CAB060
	public void UseDelay() { }

	// RVA: 0x1CAB070 Offset: 0x1CAB171 VA: 0x1CAB070
	public void ShowDamage(Vector3 _position, float _damage, UIDamageType _type, bool _is_crit, bool _is_weak, bool _is_resist) { }

	// RVA: 0x1CAB170 Offset: 0x1CAB271 VA: 0x1CAB170
	private void InitParameter() { }

	// RVA: 0x1CAB2B0 Offset: 0x1CAB3B1 VA: 0x1CAB2B0
	private void SetShowParameter() { }

	// RVA: 0x1CAB600 Offset: 0x1CAB701 VA: 0x1CAB600
	private void SetPos(Vector3 addForce) { }

	// RVA: 0x1CAB870 Offset: 0x1CAB971 VA: 0x1CAB870
	private void Update() { }

	// RVA: 0x1CABDD0 Offset: 0x1CABED1 VA: 0x1CABDD0
	private void EndShow() { }

	// RVA: 0x1CABE30 Offset: 0x1CABF31 VA: 0x1CABE30
	public void .ctor() { }
}

