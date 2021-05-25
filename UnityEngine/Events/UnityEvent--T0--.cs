[Serializable]
public abstract class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 3109
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD93D0 Offset: 0xD94D1 VA: 0xD93D0
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA540 Offset: 0x2CBA641 VA: 0x2CBA540
	|-UnityEvent<Behavior>..ctor
	|-UnityEvent<BossStageManager>..ctor
	|-UnityEvent<BulletBase>..ctor
	|-UnityEvent<CinemachineBrain>..ctor
	|-UnityEvent<GateController>..ctor
	|-UnityEvent<HumanController>..ctor
	|-UnityEvent<MonsterControllerBase>..ctor
	|-UnityEvent<PartnerNPCBehaviorController>..ctor
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>..ctor
	|-UnityEvent<object>..ctor
	|-UnityEvent<string>..ctor
	|-UnityEvent<Camera>..ctor
	|-UnityEvent<Collider>..ctor
	|-UnityEvent<BaseEventData>..ctor
	|-UnityEvent<MessageEventArgs>..ctor
	|
	|-RVA: 0x2CB9FE0 Offset: 0x2CBA0E1 VA: 0x2CB9FE0
	|-UnityEvent<GroundType>..ctor
	|-UnityEvent<Int32Enum>..ctor
	|-UnityEvent<TouchScreenKeyboard.Status>..ctor
	|
	|-RVA: 0x2CB9510 Offset: 0x2CB9611 VA: 0x2CB9510
	|-UnityEvent<bool>..ctor
	|
	|-RVA: 0x2CB9A80 Offset: 0x2CB9B81 VA: 0x2CB9A80
	|-UnityEvent<int>..ctor
	|
	|-RVA: 0x2CBAA70 Offset: 0x2CBAB71 VA: 0x2CBAA70
	|-UnityEvent<float>..ctor
	|
	|-RVA: 0x2CBAFE0 Offset: 0x2CBB0E1 VA: 0x2CBAFE0
	|-UnityEvent<Color>..ctor
	|
	|-RVA: 0x2CBB570 Offset: 0x2CBB671 VA: 0x2CBB570
	|-UnityEvent<Vector2>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA580 Offset: 0x2CBA681 VA: 0x2CBA580
	|-UnityEvent<BossStageManager>.AddListener
	|-UnityEvent<BulletBase>.AddListener
	|-UnityEvent<CinemachineBrain>.AddListener
	|-UnityEvent<GateController>.AddListener
	|-UnityEvent<HumanController>.AddListener
	|-UnityEvent<MonsterControllerBase>.AddListener
	|-UnityEvent<PartnerNPCBehaviorController>.AddListener
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>.AddListener
	|-UnityEvent<object>.AddListener
	|-UnityEvent<string>.AddListener
	|-UnityEvent<Camera>.AddListener
	|-UnityEvent<Collider>.AddListener
	|-UnityEvent<BaseEventData>.AddListener
	|-UnityEvent<MessageEventArgs>.AddListener
	|
	|-RVA: 0x2CBA020 Offset: 0x2CBA121 VA: 0x2CBA020
	|-UnityEvent<GroundType>.AddListener
	|-UnityEvent<Int32Enum>.AddListener
	|
	|-RVA: 0x2CB9550 Offset: 0x2CB9651 VA: 0x2CB9550
	|-UnityEvent<bool>.AddListener
	|
	|-RVA: 0x2CB9AC0 Offset: 0x2CB9BC1 VA: 0x2CB9AC0
	|-UnityEvent<int>.AddListener
	|
	|-RVA: 0x2CBAAB0 Offset: 0x2CBABB1 VA: 0x2CBAAB0
	|-UnityEvent<float>.AddListener
	|
	|-RVA: 0x2CBB020 Offset: 0x2CBB121 VA: 0x2CBB020
	|-UnityEvent<Color>.AddListener
	|
	|-RVA: 0x2CBB5B0 Offset: 0x2CBB6B1 VA: 0x2CBB5B0
	|-UnityEvent<Vector2>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA5D0 Offset: 0x2CBA6D1 VA: 0x2CBA5D0
	|-UnityEvent<CinemachineBrain>.RemoveListener
	|-UnityEvent<MonsterControllerBase>.RemoveListener
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>.RemoveListener
	|-UnityEvent<object>.RemoveListener
	|-UnityEvent<Camera>.RemoveListener
	|-UnityEvent<Collider>.RemoveListener
	|-UnityEvent<MessageEventArgs>.RemoveListener
	|
	|-RVA: 0x2CB95A0 Offset: 0x2CB96A1 VA: 0x2CB95A0
	|-UnityEvent<bool>.RemoveListener
	|
	|-RVA: 0x2CB9B10 Offset: 0x2CB9C11 VA: 0x2CB9B10
	|-UnityEvent<int>.RemoveListener
	|
	|-RVA: 0x2CBA070 Offset: 0x2CBA171 VA: 0x2CBA070
	|-UnityEvent<Int32Enum>.RemoveListener
	|
	|-RVA: 0x2CBAB00 Offset: 0x2CBAC01 VA: 0x2CBAB00
	|-UnityEvent<float>.RemoveListener
	|
	|-RVA: 0x2CBB070 Offset: 0x2CBB171 VA: 0x2CBB070
	|-UnityEvent<Color>.RemoveListener
	|
	|-RVA: 0x2CBB600 Offset: 0x2CBB701 VA: 0x2CBB600
	|-UnityEvent<Vector2>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, object targetObj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA620 Offset: 0x2CBA721 VA: 0x2CBA620
	|-UnityEvent<Behavior>.FindMethod_Impl
	|-UnityEvent<BossStageManager>.FindMethod_Impl
	|-UnityEvent<BulletBase>.FindMethod_Impl
	|-UnityEvent<CinemachineBrain>.FindMethod_Impl
	|-UnityEvent<GateController>.FindMethod_Impl
	|-UnityEvent<HumanController>.FindMethod_Impl
	|-UnityEvent<MonsterControllerBase>.FindMethod_Impl
	|-UnityEvent<PartnerNPCBehaviorController>.FindMethod_Impl
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>.FindMethod_Impl
	|-UnityEvent<object>.FindMethod_Impl
	|-UnityEvent<string>.FindMethod_Impl
	|-UnityEvent<Camera>.FindMethod_Impl
	|-UnityEvent<Collider>.FindMethod_Impl
	|-UnityEvent<BaseEventData>.FindMethod_Impl
	|-UnityEvent<MessageEventArgs>.FindMethod_Impl
	|
	|-RVA: 0x2CBA0C0 Offset: 0x2CBA1C1 VA: 0x2CBA0C0
	|-UnityEvent<GroundType>.FindMethod_Impl
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|-UnityEvent<TouchScreenKeyboard.Status>.FindMethod_Impl
	|
	|-RVA: 0x2CB95F0 Offset: 0x2CB96F1 VA: 0x2CB95F0
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x2CB9B60 Offset: 0x2CB9C61 VA: 0x2CB9B60
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x2CBAB50 Offset: 0x2CBAC51 VA: 0x2CBAB50
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x2CBB0C0 Offset: 0x2CBB1C1 VA: 0x2CBB0C0
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x2CBB650 Offset: 0x2CBB751 VA: 0x2CBB650
	|-UnityEvent<Vector2>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA730 Offset: 0x2CBA831 VA: 0x2CBA730
	|-UnityEvent<Behavior>.GetDelegate
	|-UnityEvent<BossStageManager>.GetDelegate
	|-UnityEvent<BulletBase>.GetDelegate
	|-UnityEvent<CinemachineBrain>.GetDelegate
	|-UnityEvent<GateController>.GetDelegate
	|-UnityEvent<HumanController>.GetDelegate
	|-UnityEvent<MonsterControllerBase>.GetDelegate
	|-UnityEvent<PartnerNPCBehaviorController>.GetDelegate
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>.GetDelegate
	|-UnityEvent<object>.GetDelegate
	|-UnityEvent<string>.GetDelegate
	|-UnityEvent<Camera>.GetDelegate
	|-UnityEvent<Collider>.GetDelegate
	|-UnityEvent<BaseEventData>.GetDelegate
	|-UnityEvent<MessageEventArgs>.GetDelegate
	|
	|-RVA: 0x2CBA1D0 Offset: 0x2CBA2D1 VA: 0x2CBA1D0
	|-UnityEvent<GroundType>.GetDelegate
	|-UnityEvent<Int32Enum>.GetDelegate
	|-UnityEvent<TouchScreenKeyboard.Status>.GetDelegate
	|
	|-RVA: 0x2CB9700 Offset: 0x2CB9801 VA: 0x2CB9700
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x2CB9C70 Offset: 0x2CB9D71 VA: 0x2CB9C70
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2CBAC60 Offset: 0x2CBAD61 VA: 0x2CBAC60
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x2CBB1D0 Offset: 0x2CBB2D1 VA: 0x2CBB1D0
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x2CBB760 Offset: 0x2CBB861 VA: 0x2CBB760
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CB9780 Offset: 0x2CB9881 VA: 0x2CB9780
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x2CB9CF0 Offset: 0x2CB9DF1 VA: 0x2CB9CF0
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x2CBA250 Offset: 0x2CBA351 VA: 0x2CBA250
	|-UnityEvent<Int32Enum>.GetDelegate
	|
	|-RVA: 0x2CBA7B0 Offset: 0x2CBA8B1 VA: 0x2CBA7B0
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x2CBACE0 Offset: 0x2CBADE1 VA: 0x2CBACE0
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x2CBB250 Offset: 0x2CBB351 VA: 0x2CBB250
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x2CBB7E0 Offset: 0x2CBB8E1 VA: 0x2CBB7E0
	|-UnityEvent<Vector2>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBA870 Offset: 0x2CBA971 VA: 0x2CBA870
	|-UnityEvent<BossStageManager>.Invoke
	|-UnityEvent<BulletBase>.Invoke
	|-UnityEvent<CinemachineBrain>.Invoke
	|-UnityEvent<GateController>.Invoke
	|-UnityEvent<HumanController>.Invoke
	|-UnityEvent<MonsterControllerBase>.Invoke
	|-UnityEvent<PartnerNPCBehaviorController>.Invoke
	|-UnityEvent<Dictionary<EquipSlotType, HumanEquipItem>>.Invoke
	|-UnityEvent<object>.Invoke
	|-UnityEvent<string>.Invoke
	|-UnityEvent<Camera>.Invoke
	|-UnityEvent<Collider>.Invoke
	|-UnityEvent<BaseEventData>.Invoke
	|-UnityEvent<MessageEventArgs>.Invoke
	|
	|-RVA: 0x2CBA310 Offset: 0x2CBA411 VA: 0x2CBA310
	|-UnityEvent<GroundType>.Invoke
	|-UnityEvent<Int32Enum>.Invoke
	|-UnityEvent<TouchScreenKeyboard.Status>.Invoke
	|
	|-RVA: 0x2CB9840 Offset: 0x2CB9941 VA: 0x2CB9840
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x2CB9DB0 Offset: 0x2CB9EB1 VA: 0x2CB9DB0
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x2CBADA0 Offset: 0x2CBAEA1 VA: 0x2CBADA0
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x2CBB310 Offset: 0x2CBB411 VA: 0x2CBB310
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x2CBB8A0 Offset: 0x2CBB9A1 VA: 0x2CBB8A0
	|-UnityEvent<Vector2>.Invoke
	*/
}

