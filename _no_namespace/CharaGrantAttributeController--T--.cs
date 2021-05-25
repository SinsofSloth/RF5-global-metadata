public abstract class CharaGrantAttributeController<T> : GrantAttributeController // TypeDefIndex: 6632
{
	// Fields
	[SerializeField] // RVA: 0x15E3B0 Offset: 0x15E4B1 VA: 0x15E3B0
	protected T m_chara; // 0x0
	[SerializeField] // RVA: 0x15E3C0 Offset: 0x15E4C1 VA: 0x15E3C0
	[RangeAttribute] // RVA: 0x15E3C0 Offset: 0x15E4C1 VA: 0x15E3C0
	protected float m_effectScale; // 0x0

	// Properties
	protected override Transform EffectPoint { get; }
	protected override float EffectScale { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override Transform get_EffectPoint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25751F0 Offset: 0x25752F1 VA: 0x25751F0
	|-CharaGrantAttributeController<HumanController>.get_EffectPoint
	|-CharaGrantAttributeController<object>.get_EffectPoint
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override float get_EffectScale() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575210 Offset: 0x2575311 VA: 0x2575210
	|-CharaGrantAttributeController<HumanController>.get_EffectScale
	|-CharaGrantAttributeController<object>.get_EffectScale
	*/

	// RVA: -1 Offset: -1
	protected void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575220 Offset: 0x2575321 VA: 0x2575220
	|-CharaGrantAttributeController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25752E0 Offset: 0x25753E1 VA: 0x25752E0
	|-CharaGrantAttributeController<HumanController>.OnEnable
	|-CharaGrantAttributeController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25753B0 Offset: 0x25754B1 VA: 0x25753B0
	|-CharaGrantAttributeController<HumanController>.OnDisable
	|-CharaGrantAttributeController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575480 Offset: 0x2575581 VA: 0x2575480
	|-CharaGrantAttributeController<HumanController>..ctor
	|-CharaGrantAttributeController<object>..ctor
	*/
}

