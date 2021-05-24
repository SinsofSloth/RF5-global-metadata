public abstract class SharedVariable<T> : SharedVariable // TypeDefIndex: 4711
{
	// Fields
	private Func<T> mGetter; // 0x0
	private Action<T> mSetter; // 0x0
	[SerializeField] // RVA: 0x12D830 Offset: 0x12D931 VA: 0x12D830
	protected T mValue; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567150 Offset: 0x2567251 VA: 0x2567150
	|-SharedVariable<AIInput.Action>..ctor
	|-SharedVariable<Alliance>..ctor
	|-SharedVariable<AttackAttribute>..ctor
	|-SharedVariable<EmotionType>..ctor
	|-SharedVariable<FarmMonsterHutState>..ctor
	|-SharedVariable<FarmMonsterState>..ctor
	|-SharedVariable<FarmMonsterWorkState>..ctor
	|-SharedVariable<ToolChargeLevel>..ctor
	|-SharedVariable<EnemyBehaviorTreeState>..ctor
	|-SharedVariable<MonsterActionBehaviorType>..ctor
	|-SharedVariable<MonsterActionCategory>..ctor
	|-SharedVariable<MovementBehaviorType>..ctor
	|-SharedVariable<PartnerMovementOrderType>..ctor
	|-SharedVariable<PartnerNPCActionBehaviorType>..ctor
	|-SharedVariable<Int32Enum>..ctor
	|
	|-RVA: 0x2567C00 Offset: 0x2567D01 VA: 0x2567C00
	|-SharedVariable<AIInput>..ctor
	|-SharedVariable<GenericVariable>..ctor
	|-SharedVariable<NamedVariable>..ctor
	|-SharedVariable<EnemyBehaviorController>..ctor
	|-SharedVariable<MonsterBehaviorController>..ctor
	|-SharedVariable<PartnerMonsterBehaviorController>..ctor
	|-SharedVariable<PartnerNPCBehaviorController>..ctor
	|-SharedVariable<List<CharacterBase>>..ctor
	|-SharedVariable<List<GameObject>>..ctor
	|-SharedVariable<List<Object>>..ctor
	|-SharedVariable<List<Transform>>..ctor
	|-SharedVariable<List<Vector3>>..ctor
	|-SharedVariable<object>..ctor
	|-SharedVariable<string>..ctor
	|-SharedVariable<AnimationCurve>..ctor
	|-SharedVariable<Behaviour>..ctor
	|-SharedVariable<Collider>..ctor
	|-SharedVariable<GameObject>..ctor
	|-SharedVariable<Material>..ctor
	|-SharedVariable<Object>..ctor
	|-SharedVariable<Transform>..ctor
	|
	|-RVA: 0x2565CC0 Offset: 0x2565DC1 VA: 0x2565CC0
	|-SharedVariable<bool>..ctor
	|
	|-RVA: 0x2566710 Offset: 0x2566811 VA: 0x2566710
	|-SharedVariable<int>..ctor
	|
	|-RVA: 0x2568600 Offset: 0x2568701 VA: 0x2568600
	|-SharedVariable<float>..ctor
	|
	|-RVA: 0x2569040 Offset: 0x2569141 VA: 0x2569040
	|-SharedVariable<uint>..ctor
	|
	|-RVA: 0x2569A80 Offset: 0x2569B81 VA: 0x2569A80
	|-SharedVariable<Color>..ctor
	|
	|-RVA: 0x256A520 Offset: 0x256A621 VA: 0x256A520
	|-SharedVariable<LayerMask>..ctor
	|
	|-RVA: 0x256B000 Offset: 0x256B101 VA: 0x256B000
	|-SharedVariable<Quaternion>..ctor
	|
	|-RVA: 0x256BAA0 Offset: 0x256BBA1 VA: 0x256BAA0
	|-SharedVariable<Rect>..ctor
	|
	|-RVA: 0x256C540 Offset: 0x256C641 VA: 0x256C540
	|-SharedVariable<Vector2>..ctor
	|
	|-RVA: 0x256CFA0 Offset: 0x256D0A1 VA: 0x256CFA0
	|-SharedVariable<Vector2Int>..ctor
	|
	|-RVA: 0x256D9E0 Offset: 0x256DAE1 VA: 0x256D9E0
	|-SharedVariable<Vector3>..ctor
	|
	|-RVA: 0x256E480 Offset: 0x256E581 VA: 0x256E480
	|-SharedVariable<Vector3Int>..ctor
	|
	|-RVA: 0x256EF20 Offset: 0x256F021 VA: 0x256EF20
	|-SharedVariable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void InitializePropertyMapping(BehaviorSource behaviorSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567170 Offset: 0x2567271 VA: 0x2567170
	|-SharedVariable<AIInput.Action>.InitializePropertyMapping
	|-SharedVariable<Alliance>.InitializePropertyMapping
	|-SharedVariable<AttackAttribute>.InitializePropertyMapping
	|-SharedVariable<EmotionType>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterHutState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterWorkState>.InitializePropertyMapping
	|-SharedVariable<ToolChargeLevel>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorTreeState>.InitializePropertyMapping
	|-SharedVariable<MonsterActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<MonsterActionCategory>.InitializePropertyMapping
	|-SharedVariable<MovementBehaviorType>.InitializePropertyMapping
	|-SharedVariable<PartnerMovementOrderType>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<Int32Enum>.InitializePropertyMapping
	|
	|-RVA: 0x2567C20 Offset: 0x2567D21 VA: 0x2567C20
	|-SharedVariable<AIInput>.InitializePropertyMapping
	|-SharedVariable<GenericVariable>.InitializePropertyMapping
	|-SharedVariable<NamedVariable>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorController>.InitializePropertyMapping
	|-SharedVariable<MonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerMonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCBehaviorController>.InitializePropertyMapping
	|-SharedVariable<List<CharacterBase>>.InitializePropertyMapping
	|-SharedVariable<List<GameObject>>.InitializePropertyMapping
	|-SharedVariable<List<Object>>.InitializePropertyMapping
	|-SharedVariable<List<Transform>>.InitializePropertyMapping
	|-SharedVariable<List<Vector3>>.InitializePropertyMapping
	|-SharedVariable<object>.InitializePropertyMapping
	|-SharedVariable<string>.InitializePropertyMapping
	|-SharedVariable<AnimationCurve>.InitializePropertyMapping
	|-SharedVariable<Behaviour>.InitializePropertyMapping
	|-SharedVariable<Collider>.InitializePropertyMapping
	|-SharedVariable<GameObject>.InitializePropertyMapping
	|-SharedVariable<Material>.InitializePropertyMapping
	|-SharedVariable<Object>.InitializePropertyMapping
	|-SharedVariable<Transform>.InitializePropertyMapping
	|
	|-RVA: 0x2565CE0 Offset: 0x2565DE1 VA: 0x2565CE0
	|-SharedVariable<bool>.InitializePropertyMapping
	|
	|-RVA: 0x2566730 Offset: 0x2566831 VA: 0x2566730
	|-SharedVariable<int>.InitializePropertyMapping
	|
	|-RVA: 0x2568620 Offset: 0x2568721 VA: 0x2568620
	|-SharedVariable<float>.InitializePropertyMapping
	|
	|-RVA: 0x2569060 Offset: 0x2569161 VA: 0x2569060
	|-SharedVariable<uint>.InitializePropertyMapping
	|
	|-RVA: 0x2569AA0 Offset: 0x2569BA1 VA: 0x2569AA0
	|-SharedVariable<Color>.InitializePropertyMapping
	|
	|-RVA: 0x256A540 Offset: 0x256A641 VA: 0x256A540
	|-SharedVariable<LayerMask>.InitializePropertyMapping
	|
	|-RVA: 0x256B020 Offset: 0x256B121 VA: 0x256B020
	|-SharedVariable<Quaternion>.InitializePropertyMapping
	|
	|-RVA: 0x256BAC0 Offset: 0x256BBC1 VA: 0x256BAC0
	|-SharedVariable<Rect>.InitializePropertyMapping
	|
	|-RVA: 0x256C560 Offset: 0x256C661 VA: 0x256C560
	|-SharedVariable<Vector2>.InitializePropertyMapping
	|
	|-RVA: 0x256CFC0 Offset: 0x256D0C1 VA: 0x256CFC0
	|-SharedVariable<Vector2Int>.InitializePropertyMapping
	|
	|-RVA: 0x256DA00 Offset: 0x256DB01 VA: 0x256DA00
	|-SharedVariable<Vector3>.InitializePropertyMapping
	|
	|-RVA: 0x256E4A0 Offset: 0x256E5A1 VA: 0x256E4A0
	|-SharedVariable<Vector3Int>.InitializePropertyMapping
	|
	|-RVA: 0x256EF40 Offset: 0x256F041 VA: 0x256EF40
	|-SharedVariable<Vector4>.InitializePropertyMapping
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568330 Offset: 0x2568431 VA: 0x2568330
	|-SharedVariable<AIInput>.get_Value
	|-SharedVariable<EnemyBehaviorController>.get_Value
	|-SharedVariable<MonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerMonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerNPCBehaviorController>.get_Value
	|-SharedVariable<List<GameObject>>.get_Value
	|-SharedVariable<List<Object>>.get_Value
	|-SharedVariable<List<Transform>>.get_Value
	|-SharedVariable<List<Vector3>>.get_Value
	|-SharedVariable<string>.get_Value
	|-SharedVariable<Behaviour>.get_Value
	|-SharedVariable<Collider>.get_Value
	|-SharedVariable<GameObject>.get_Value
	|-SharedVariable<Material>.get_Value
	|-SharedVariable<Object>.get_Value
	|-SharedVariable<Transform>.get_Value
	|-SharedVariable<GenericVariable>.get_Value
	|-SharedVariable<NamedVariable>.get_Value
	|-SharedVariable<object>.get_Value
	|
	|-RVA: 0x2567880 Offset: 0x2567981 VA: 0x2567880
	|-SharedVariable<AttackAttribute>.get_Value
	|-SharedVariable<EmotionType>.get_Value
	|-SharedVariable<FarmMonsterHutState>.get_Value
	|-SharedVariable<FarmMonsterState>.get_Value
	|-SharedVariable<FarmMonsterWorkState>.get_Value
	|-SharedVariable<ToolChargeLevel>.get_Value
	|-SharedVariable<EnemyBehaviorTreeState>.get_Value
	|-SharedVariable<MonsterActionBehaviorType>.get_Value
	|-SharedVariable<MonsterActionCategory>.get_Value
	|-SharedVariable<MovementBehaviorType>.get_Value
	|-SharedVariable<PartnerMovementOrderType>.get_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.get_Value
	|-SharedVariable<Int32Enum>.get_Value
	|
	|-RVA: 0x25663F0 Offset: 0x25664F1 VA: 0x25663F0
	|-SharedVariable<bool>.get_Value
	|
	|-RVA: 0x2566E40 Offset: 0x2566F41 VA: 0x2566E40
	|-SharedVariable<int>.get_Value
	|
	|-RVA: 0x2568D30 Offset: 0x2568E31 VA: 0x2568D30
	|-SharedVariable<float>.get_Value
	|
	|-RVA: 0x256A1B0 Offset: 0x256A2B1 VA: 0x256A1B0
	|-SharedVariable<Color>.get_Value
	|
	|-RVA: 0x256B730 Offset: 0x256B831 VA: 0x256B730
	|-SharedVariable<Quaternion>.get_Value
	|
	|-RVA: 0x256C1D0 Offset: 0x256C2D1 VA: 0x256C1D0
	|-SharedVariable<Rect>.get_Value
	|
	|-RVA: 0x256CC70 Offset: 0x256CD71 VA: 0x256CC70
	|-SharedVariable<Vector2>.get_Value
	|
	|-RVA: 0x256E110 Offset: 0x256E211 VA: 0x256E110
	|-SharedVariable<Vector3>.get_Value
	|
	|-RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	|-SharedVariable<Vector4>.get_Value
	|
	|-RVA: 0x2569770 Offset: 0x2569871 VA: 0x2569770
	|-SharedVariable<uint>.get_Value
	|
	|-RVA: 0x256AC50 Offset: 0x256AD51 VA: 0x256AC50
	|-SharedVariable<LayerMask>.get_Value
	|
	|-RVA: 0x256D6D0 Offset: 0x256D7D1 VA: 0x256D6D0
	|-SharedVariable<Vector2Int>.get_Value
	|
	|-RVA: 0x256EBB0 Offset: 0x256ECB1 VA: 0x256EBB0
	|-SharedVariable<Vector3Int>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568360 Offset: 0x2568461 VA: 0x2568360
	|-SharedVariable<AIInput>.set_Value
	|-SharedVariable<EnemyBehaviorController>.set_Value
	|-SharedVariable<MonsterBehaviorController>.set_Value
	|-SharedVariable<PartnerNPCBehaviorController>.set_Value
	|-SharedVariable<List<CharacterBase>>.set_Value
	|-SharedVariable<List<GameObject>>.set_Value
	|-SharedVariable<List<Object>>.set_Value
	|-SharedVariable<List<Transform>>.set_Value
	|-SharedVariable<List<Vector3>>.set_Value
	|-SharedVariable<object>.set_Value
	|-SharedVariable<string>.set_Value
	|-SharedVariable<Behaviour>.set_Value
	|-SharedVariable<Collider>.set_Value
	|-SharedVariable<GameObject>.set_Value
	|-SharedVariable<Object>.set_Value
	|-SharedVariable<Transform>.set_Value
	|
	|-RVA: 0x25678B0 Offset: 0x25679B1 VA: 0x25678B0
	|-SharedVariable<AttackAttribute>.set_Value
	|-SharedVariable<EmotionType>.set_Value
	|-SharedVariable<FarmMonsterHutState>.set_Value
	|-SharedVariable<FarmMonsterState>.set_Value
	|-SharedVariable<FarmMonsterWorkState>.set_Value
	|-SharedVariable<ToolChargeLevel>.set_Value
	|-SharedVariable<EnemyBehaviorTreeState>.set_Value
	|-SharedVariable<MonsterActionBehaviorType>.set_Value
	|-SharedVariable<MonsterActionCategory>.set_Value
	|-SharedVariable<MovementBehaviorType>.set_Value
	|-SharedVariable<PartnerMovementOrderType>.set_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.set_Value
	|-SharedVariable<Int32Enum>.set_Value
	|
	|-RVA: 0x2566420 Offset: 0x2566521 VA: 0x2566420
	|-SharedVariable<bool>.set_Value
	|
	|-RVA: 0x2566E70 Offset: 0x2566F71 VA: 0x2566E70
	|-SharedVariable<int>.set_Value
	|
	|-RVA: 0x2568D60 Offset: 0x2568E61 VA: 0x2568D60
	|-SharedVariable<float>.set_Value
	|
	|-RVA: 0x25697A0 Offset: 0x25698A1 VA: 0x25697A0
	|-SharedVariable<uint>.set_Value
	|
	|-RVA: 0x256A1F0 Offset: 0x256A2F1 VA: 0x256A1F0
	|-SharedVariable<Color>.set_Value
	|
	|-RVA: 0x256AC90 Offset: 0x256AD91 VA: 0x256AC90
	|-SharedVariable<LayerMask>.set_Value
	|
	|-RVA: 0x256B770 Offset: 0x256B871 VA: 0x256B770
	|-SharedVariable<Quaternion>.set_Value
	|
	|-RVA: 0x256C210 Offset: 0x256C311 VA: 0x256C210
	|-SharedVariable<Rect>.set_Value
	|
	|-RVA: 0x256CCB0 Offset: 0x256CDB1 VA: 0x256CCB0
	|-SharedVariable<Vector2>.set_Value
	|
	|-RVA: 0x256D700 Offset: 0x256D801 VA: 0x256D700
	|-SharedVariable<Vector2Int>.set_Value
	|
	|-RVA: 0x256E150 Offset: 0x256E251 VA: 0x256E150
	|-SharedVariable<Vector3>.set_Value
	|
	|-RVA: 0x256EC00 Offset: 0x256ED01 VA: 0x256EC00
	|-SharedVariable<Vector3Int>.set_Value
	|
	|-RVA: 0x256F690 Offset: 0x256F791 VA: 0x256F690
	|-SharedVariable<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25679C0 Offset: 0x2567AC1 VA: 0x25679C0
	|-SharedVariable<AIInput.Action>.GetValue
	|-SharedVariable<Alliance>.GetValue
	|-SharedVariable<AttackAttribute>.GetValue
	|-SharedVariable<EmotionType>.GetValue
	|-SharedVariable<FarmMonsterHutState>.GetValue
	|-SharedVariable<FarmMonsterState>.GetValue
	|-SharedVariable<FarmMonsterWorkState>.GetValue
	|-SharedVariable<ToolChargeLevel>.GetValue
	|-SharedVariable<EnemyBehaviorTreeState>.GetValue
	|-SharedVariable<MonsterActionBehaviorType>.GetValue
	|-SharedVariable<MonsterActionCategory>.GetValue
	|-SharedVariable<MovementBehaviorType>.GetValue
	|-SharedVariable<PartnerMovementOrderType>.GetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.GetValue
	|-SharedVariable<Int32Enum>.GetValue
	|
	|-RVA: 0x2568420 Offset: 0x2568521 VA: 0x2568420
	|-SharedVariable<AIInput>.GetValue
	|-SharedVariable<GenericVariable>.GetValue
	|-SharedVariable<NamedVariable>.GetValue
	|-SharedVariable<EnemyBehaviorController>.GetValue
	|-SharedVariable<MonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerNPCBehaviorController>.GetValue
	|-SharedVariable<List<CharacterBase>>.GetValue
	|-SharedVariable<List<GameObject>>.GetValue
	|-SharedVariable<List<Object>>.GetValue
	|-SharedVariable<List<Transform>>.GetValue
	|-SharedVariable<List<Vector3>>.GetValue
	|-SharedVariable<object>.GetValue
	|-SharedVariable<string>.GetValue
	|-SharedVariable<AnimationCurve>.GetValue
	|-SharedVariable<Behaviour>.GetValue
	|-SharedVariable<Collider>.GetValue
	|-SharedVariable<GameObject>.GetValue
	|-SharedVariable<Material>.GetValue
	|-SharedVariable<Object>.GetValue
	|-SharedVariable<Transform>.GetValue
	|
	|-RVA: 0x2566500 Offset: 0x2566601 VA: 0x2566500
	|-SharedVariable<bool>.GetValue
	|
	|-RVA: 0x2566F40 Offset: 0x2567041 VA: 0x2566F40
	|-SharedVariable<int>.GetValue
	|
	|-RVA: 0x2568E30 Offset: 0x2568F31 VA: 0x2568E30
	|-SharedVariable<float>.GetValue
	|
	|-RVA: 0x2569870 Offset: 0x2569971 VA: 0x2569870
	|-SharedVariable<uint>.GetValue
	|
	|-RVA: 0x256A2F0 Offset: 0x256A3F1 VA: 0x256A2F0
	|-SharedVariable<Color>.GetValue
	|
	|-RVA: 0x256ADB0 Offset: 0x256AEB1 VA: 0x256ADB0
	|-SharedVariable<LayerMask>.GetValue
	|
	|-RVA: 0x256B870 Offset: 0x256B971 VA: 0x256B870
	|-SharedVariable<Quaternion>.GetValue
	|
	|-RVA: 0x256C310 Offset: 0x256C411 VA: 0x256C310
	|-SharedVariable<Rect>.GetValue
	|
	|-RVA: 0x256CD90 Offset: 0x256CE91 VA: 0x256CD90
	|-SharedVariable<Vector2>.GetValue
	|
	|-RVA: 0x256D7D0 Offset: 0x256D8D1 VA: 0x256D7D0
	|-SharedVariable<Vector2Int>.GetValue
	|
	|-RVA: 0x256E250 Offset: 0x256E351 VA: 0x256E250
	|-SharedVariable<Vector3>.GetValue
	|
	|-RVA: 0x256ECF0 Offset: 0x256EDF1 VA: 0x256ECF0
	|-SharedVariable<Vector3Int>.GetValue
	|
	|-RVA: 0x256F790 Offset: 0x256F891 VA: 0x256F790
	|-SharedVariable<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567A30 Offset: 0x2567B31 VA: 0x2567A30
	|-SharedVariable<AIInput.Action>.SetValue
	|-SharedVariable<Alliance>.SetValue
	|-SharedVariable<AttackAttribute>.SetValue
	|-SharedVariable<EmotionType>.SetValue
	|-SharedVariable<FarmMonsterHutState>.SetValue
	|-SharedVariable<FarmMonsterState>.SetValue
	|-SharedVariable<FarmMonsterWorkState>.SetValue
	|-SharedVariable<ToolChargeLevel>.SetValue
	|-SharedVariable<EnemyBehaviorTreeState>.SetValue
	|-SharedVariable<MonsterActionBehaviorType>.SetValue
	|-SharedVariable<MonsterActionCategory>.SetValue
	|-SharedVariable<MovementBehaviorType>.SetValue
	|-SharedVariable<PartnerMovementOrderType>.SetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.SetValue
	|-SharedVariable<Int32Enum>.SetValue
	|
	|-RVA: 0x2568450 Offset: 0x2568551 VA: 0x2568450
	|-SharedVariable<AIInput>.SetValue
	|-SharedVariable<GenericVariable>.SetValue
	|-SharedVariable<NamedVariable>.SetValue
	|-SharedVariable<EnemyBehaviorController>.SetValue
	|-SharedVariable<MonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerNPCBehaviorController>.SetValue
	|-SharedVariable<List<CharacterBase>>.SetValue
	|-SharedVariable<List<GameObject>>.SetValue
	|-SharedVariable<List<Object>>.SetValue
	|-SharedVariable<List<Transform>>.SetValue
	|-SharedVariable<List<Vector3>>.SetValue
	|-SharedVariable<object>.SetValue
	|-SharedVariable<string>.SetValue
	|-SharedVariable<AnimationCurve>.SetValue
	|-SharedVariable<Behaviour>.SetValue
	|-SharedVariable<Collider>.SetValue
	|-SharedVariable<GameObject>.SetValue
	|-SharedVariable<Material>.SetValue
	|-SharedVariable<Object>.SetValue
	|-SharedVariable<Transform>.SetValue
	|
	|-RVA: 0x2566570 Offset: 0x2566671 VA: 0x2566570
	|-SharedVariable<bool>.SetValue
	|
	|-RVA: 0x2566FB0 Offset: 0x25670B1 VA: 0x2566FB0
	|-SharedVariable<int>.SetValue
	|
	|-RVA: 0x2568EA0 Offset: 0x2568FA1 VA: 0x2568EA0
	|-SharedVariable<float>.SetValue
	|
	|-RVA: 0x25698E0 Offset: 0x25699E1 VA: 0x25698E0
	|-SharedVariable<uint>.SetValue
	|
	|-RVA: 0x256A360 Offset: 0x256A461 VA: 0x256A360
	|-SharedVariable<Color>.SetValue
	|
	|-RVA: 0x256AE20 Offset: 0x256AF21 VA: 0x256AE20
	|-SharedVariable<LayerMask>.SetValue
	|
	|-RVA: 0x256B8E0 Offset: 0x256B9E1 VA: 0x256B8E0
	|-SharedVariable<Quaternion>.SetValue
	|
	|-RVA: 0x256C380 Offset: 0x256C481 VA: 0x256C380
	|-SharedVariable<Rect>.SetValue
	|
	|-RVA: 0x256CE00 Offset: 0x256CF01 VA: 0x256CE00
	|-SharedVariable<Vector2>.SetValue
	|
	|-RVA: 0x256D840 Offset: 0x256D941 VA: 0x256D840
	|-SharedVariable<Vector2Int>.SetValue
	|
	|-RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	|-SharedVariable<Vector3>.SetValue
	|
	|-RVA: 0x256ED60 Offset: 0x256EE61 VA: 0x256ED60
	|-SharedVariable<Vector3Int>.SetValue
	|
	|-RVA: 0x256F800 Offset: 0x256F901 VA: 0x256F800
	|-SharedVariable<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568550 Offset: 0x2568651 VA: 0x2568550
	|-SharedVariable<AIInput>.ToString
	|-SharedVariable<GenericVariable>.ToString
	|-SharedVariable<NamedVariable>.ToString
	|-SharedVariable<EnemyBehaviorController>.ToString
	|-SharedVariable<MonsterBehaviorController>.ToString
	|-SharedVariable<PartnerNPCBehaviorController>.ToString
	|-SharedVariable<List<CharacterBase>>.ToString
	|-SharedVariable<List<GameObject>>.ToString
	|-SharedVariable<List<Object>>.ToString
	|-SharedVariable<List<Transform>>.ToString
	|-SharedVariable<List<Vector3>>.ToString
	|-SharedVariable<object>.ToString
	|-SharedVariable<string>.ToString
	|-SharedVariable<AnimationCurve>.ToString
	|-SharedVariable<Behaviour>.ToString
	|-SharedVariable<Collider>.ToString
	|-SharedVariable<GameObject>.ToString
	|-SharedVariable<Material>.ToString
	|-SharedVariable<Object>.ToString
	|-SharedVariable<Transform>.ToString
	|
	|-RVA: 0x2567B30 Offset: 0x2567C31 VA: 0x2567B30
	|-SharedVariable<EnemyBehaviorTreeState>.ToString
	|-SharedVariable<MonsterActionCategory>.ToString
	|-SharedVariable<MovementBehaviorType>.ToString
	|-SharedVariable<Int32Enum>.ToString
	|
	|-RVA: 0x2566670 Offset: 0x2566771 VA: 0x2566670
	|-SharedVariable<bool>.ToString
	|
	|-RVA: 0x25670B0 Offset: 0x25671B1 VA: 0x25670B0
	|-SharedVariable<int>.ToString
	|
	|-RVA: 0x2568FA0 Offset: 0x25690A1 VA: 0x2568FA0
	|-SharedVariable<float>.ToString
	|
	|-RVA: 0x25699E0 Offset: 0x2569AE1 VA: 0x25699E0
	|-SharedVariable<uint>.ToString
	|
	|-RVA: 0x256A470 Offset: 0x256A571 VA: 0x256A470
	|-SharedVariable<Color>.ToString
	|
	|-RVA: 0x256AF20 Offset: 0x256B021 VA: 0x256AF20
	|-SharedVariable<LayerMask>.ToString
	|
	|-RVA: 0x256B9F0 Offset: 0x256BAF1 VA: 0x256B9F0
	|-SharedVariable<Quaternion>.ToString
	|
	|-RVA: 0x256C490 Offset: 0x256C591 VA: 0x256C490
	|-SharedVariable<Rect>.ToString
	|
	|-RVA: 0x256CF00 Offset: 0x256D001 VA: 0x256CF00
	|-SharedVariable<Vector2>.ToString
	|
	|-RVA: 0x256D940 Offset: 0x256DA41 VA: 0x256D940
	|-SharedVariable<Vector2Int>.ToString
	|
	|-RVA: 0x256E3D0 Offset: 0x256E4D1 VA: 0x256E3D0
	|-SharedVariable<Vector3>.ToString
	|
	|-RVA: 0x256EE70 Offset: 0x256EF71 VA: 0x256EE70
	|-SharedVariable<Vector3Int>.ToString
	|
	|-RVA: 0x256F910 Offset: 0x256FA11 VA: 0x256F910
	|-SharedVariable<Vector4>.ToString
	*/
}

public abstract class SharedVariable<T> : SharedVariable // TypeDefIndex: 4711
{
	// Fields
	private Func<T> mGetter; // 0x0
	private Action<T> mSetter; // 0x0
	[SerializeField] // RVA: 0x12D830 Offset: 0x12D931 VA: 0x12D830
	protected T mValue; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567150 Offset: 0x2567251 VA: 0x2567150
	|-SharedVariable<AIInput.Action>..ctor
	|-SharedVariable<Alliance>..ctor
	|-SharedVariable<AttackAttribute>..ctor
	|-SharedVariable<EmotionType>..ctor
	|-SharedVariable<FarmMonsterHutState>..ctor
	|-SharedVariable<FarmMonsterState>..ctor
	|-SharedVariable<FarmMonsterWorkState>..ctor
	|-SharedVariable<ToolChargeLevel>..ctor
	|-SharedVariable<EnemyBehaviorTreeState>..ctor
	|-SharedVariable<MonsterActionBehaviorType>..ctor
	|-SharedVariable<MonsterActionCategory>..ctor
	|-SharedVariable<MovementBehaviorType>..ctor
	|-SharedVariable<PartnerMovementOrderType>..ctor
	|-SharedVariable<PartnerNPCActionBehaviorType>..ctor
	|-SharedVariable<Int32Enum>..ctor
	|
	|-RVA: 0x2567C00 Offset: 0x2567D01 VA: 0x2567C00
	|-SharedVariable<AIInput>..ctor
	|-SharedVariable<GenericVariable>..ctor
	|-SharedVariable<NamedVariable>..ctor
	|-SharedVariable<EnemyBehaviorController>..ctor
	|-SharedVariable<MonsterBehaviorController>..ctor
	|-SharedVariable<PartnerMonsterBehaviorController>..ctor
	|-SharedVariable<PartnerNPCBehaviorController>..ctor
	|-SharedVariable<List<CharacterBase>>..ctor
	|-SharedVariable<List<GameObject>>..ctor
	|-SharedVariable<List<Object>>..ctor
	|-SharedVariable<List<Transform>>..ctor
	|-SharedVariable<List<Vector3>>..ctor
	|-SharedVariable<object>..ctor
	|-SharedVariable<string>..ctor
	|-SharedVariable<AnimationCurve>..ctor
	|-SharedVariable<Behaviour>..ctor
	|-SharedVariable<Collider>..ctor
	|-SharedVariable<GameObject>..ctor
	|-SharedVariable<Material>..ctor
	|-SharedVariable<Object>..ctor
	|-SharedVariable<Transform>..ctor
	|
	|-RVA: 0x2565CC0 Offset: 0x2565DC1 VA: 0x2565CC0
	|-SharedVariable<bool>..ctor
	|
	|-RVA: 0x2566710 Offset: 0x2566811 VA: 0x2566710
	|-SharedVariable<int>..ctor
	|
	|-RVA: 0x2568600 Offset: 0x2568701 VA: 0x2568600
	|-SharedVariable<float>..ctor
	|
	|-RVA: 0x2569040 Offset: 0x2569141 VA: 0x2569040
	|-SharedVariable<uint>..ctor
	|
	|-RVA: 0x2569A80 Offset: 0x2569B81 VA: 0x2569A80
	|-SharedVariable<Color>..ctor
	|
	|-RVA: 0x256A520 Offset: 0x256A621 VA: 0x256A520
	|-SharedVariable<LayerMask>..ctor
	|
	|-RVA: 0x256B000 Offset: 0x256B101 VA: 0x256B000
	|-SharedVariable<Quaternion>..ctor
	|
	|-RVA: 0x256BAA0 Offset: 0x256BBA1 VA: 0x256BAA0
	|-SharedVariable<Rect>..ctor
	|
	|-RVA: 0x256C540 Offset: 0x256C641 VA: 0x256C540
	|-SharedVariable<Vector2>..ctor
	|
	|-RVA: 0x256CFA0 Offset: 0x256D0A1 VA: 0x256CFA0
	|-SharedVariable<Vector2Int>..ctor
	|
	|-RVA: 0x256D9E0 Offset: 0x256DAE1 VA: 0x256D9E0
	|-SharedVariable<Vector3>..ctor
	|
	|-RVA: 0x256E480 Offset: 0x256E581 VA: 0x256E480
	|-SharedVariable<Vector3Int>..ctor
	|
	|-RVA: 0x256EF20 Offset: 0x256F021 VA: 0x256EF20
	|-SharedVariable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void InitializePropertyMapping(BehaviorSource behaviorSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567170 Offset: 0x2567271 VA: 0x2567170
	|-SharedVariable<AIInput.Action>.InitializePropertyMapping
	|-SharedVariable<Alliance>.InitializePropertyMapping
	|-SharedVariable<AttackAttribute>.InitializePropertyMapping
	|-SharedVariable<EmotionType>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterHutState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterWorkState>.InitializePropertyMapping
	|-SharedVariable<ToolChargeLevel>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorTreeState>.InitializePropertyMapping
	|-SharedVariable<MonsterActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<MonsterActionCategory>.InitializePropertyMapping
	|-SharedVariable<MovementBehaviorType>.InitializePropertyMapping
	|-SharedVariable<PartnerMovementOrderType>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<Int32Enum>.InitializePropertyMapping
	|
	|-RVA: 0x2567C20 Offset: 0x2567D21 VA: 0x2567C20
	|-SharedVariable<AIInput>.InitializePropertyMapping
	|-SharedVariable<GenericVariable>.InitializePropertyMapping
	|-SharedVariable<NamedVariable>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorController>.InitializePropertyMapping
	|-SharedVariable<MonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerMonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCBehaviorController>.InitializePropertyMapping
	|-SharedVariable<List<CharacterBase>>.InitializePropertyMapping
	|-SharedVariable<List<GameObject>>.InitializePropertyMapping
	|-SharedVariable<List<Object>>.InitializePropertyMapping
	|-SharedVariable<List<Transform>>.InitializePropertyMapping
	|-SharedVariable<List<Vector3>>.InitializePropertyMapping
	|-SharedVariable<object>.InitializePropertyMapping
	|-SharedVariable<string>.InitializePropertyMapping
	|-SharedVariable<AnimationCurve>.InitializePropertyMapping
	|-SharedVariable<Behaviour>.InitializePropertyMapping
	|-SharedVariable<Collider>.InitializePropertyMapping
	|-SharedVariable<GameObject>.InitializePropertyMapping
	|-SharedVariable<Material>.InitializePropertyMapping
	|-SharedVariable<Object>.InitializePropertyMapping
	|-SharedVariable<Transform>.InitializePropertyMapping
	|
	|-RVA: 0x2565CE0 Offset: 0x2565DE1 VA: 0x2565CE0
	|-SharedVariable<bool>.InitializePropertyMapping
	|
	|-RVA: 0x2566730 Offset: 0x2566831 VA: 0x2566730
	|-SharedVariable<int>.InitializePropertyMapping
	|
	|-RVA: 0x2568620 Offset: 0x2568721 VA: 0x2568620
	|-SharedVariable<float>.InitializePropertyMapping
	|
	|-RVA: 0x2569060 Offset: 0x2569161 VA: 0x2569060
	|-SharedVariable<uint>.InitializePropertyMapping
	|
	|-RVA: 0x2569AA0 Offset: 0x2569BA1 VA: 0x2569AA0
	|-SharedVariable<Color>.InitializePropertyMapping
	|
	|-RVA: 0x256A540 Offset: 0x256A641 VA: 0x256A540
	|-SharedVariable<LayerMask>.InitializePropertyMapping
	|
	|-RVA: 0x256B020 Offset: 0x256B121 VA: 0x256B020
	|-SharedVariable<Quaternion>.InitializePropertyMapping
	|
	|-RVA: 0x256BAC0 Offset: 0x256BBC1 VA: 0x256BAC0
	|-SharedVariable<Rect>.InitializePropertyMapping
	|
	|-RVA: 0x256C560 Offset: 0x256C661 VA: 0x256C560
	|-SharedVariable<Vector2>.InitializePropertyMapping
	|
	|-RVA: 0x256CFC0 Offset: 0x256D0C1 VA: 0x256CFC0
	|-SharedVariable<Vector2Int>.InitializePropertyMapping
	|
	|-RVA: 0x256DA00 Offset: 0x256DB01 VA: 0x256DA00
	|-SharedVariable<Vector3>.InitializePropertyMapping
	|
	|-RVA: 0x256E4A0 Offset: 0x256E5A1 VA: 0x256E4A0
	|-SharedVariable<Vector3Int>.InitializePropertyMapping
	|
	|-RVA: 0x256EF40 Offset: 0x256F041 VA: 0x256EF40
	|-SharedVariable<Vector4>.InitializePropertyMapping
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568330 Offset: 0x2568431 VA: 0x2568330
	|-SharedVariable<AIInput>.get_Value
	|-SharedVariable<EnemyBehaviorController>.get_Value
	|-SharedVariable<MonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerMonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerNPCBehaviorController>.get_Value
	|-SharedVariable<List<GameObject>>.get_Value
	|-SharedVariable<List<Object>>.get_Value
	|-SharedVariable<List<Transform>>.get_Value
	|-SharedVariable<List<Vector3>>.get_Value
	|-SharedVariable<string>.get_Value
	|-SharedVariable<Behaviour>.get_Value
	|-SharedVariable<Collider>.get_Value
	|-SharedVariable<GameObject>.get_Value
	|-SharedVariable<Material>.get_Value
	|-SharedVariable<Object>.get_Value
	|-SharedVariable<Transform>.get_Value
	|-SharedVariable<GenericVariable>.get_Value
	|-SharedVariable<NamedVariable>.get_Value
	|-SharedVariable<object>.get_Value
	|
	|-RVA: 0x2567880 Offset: 0x2567981 VA: 0x2567880
	|-SharedVariable<AttackAttribute>.get_Value
	|-SharedVariable<EmotionType>.get_Value
	|-SharedVariable<FarmMonsterHutState>.get_Value
	|-SharedVariable<FarmMonsterState>.get_Value
	|-SharedVariable<FarmMonsterWorkState>.get_Value
	|-SharedVariable<ToolChargeLevel>.get_Value
	|-SharedVariable<EnemyBehaviorTreeState>.get_Value
	|-SharedVariable<MonsterActionBehaviorType>.get_Value
	|-SharedVariable<MonsterActionCategory>.get_Value
	|-SharedVariable<MovementBehaviorType>.get_Value
	|-SharedVariable<PartnerMovementOrderType>.get_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.get_Value
	|-SharedVariable<Int32Enum>.get_Value
	|
	|-RVA: 0x25663F0 Offset: 0x25664F1 VA: 0x25663F0
	|-SharedVariable<bool>.get_Value
	|
	|-RVA: 0x2566E40 Offset: 0x2566F41 VA: 0x2566E40
	|-SharedVariable<int>.get_Value
	|
	|-RVA: 0x2568D30 Offset: 0x2568E31 VA: 0x2568D30
	|-SharedVariable<float>.get_Value
	|
	|-RVA: 0x256A1B0 Offset: 0x256A2B1 VA: 0x256A1B0
	|-SharedVariable<Color>.get_Value
	|
	|-RVA: 0x256B730 Offset: 0x256B831 VA: 0x256B730
	|-SharedVariable<Quaternion>.get_Value
	|
	|-RVA: 0x256C1D0 Offset: 0x256C2D1 VA: 0x256C1D0
	|-SharedVariable<Rect>.get_Value
	|
	|-RVA: 0x256CC70 Offset: 0x256CD71 VA: 0x256CC70
	|-SharedVariable<Vector2>.get_Value
	|
	|-RVA: 0x256E110 Offset: 0x256E211 VA: 0x256E110
	|-SharedVariable<Vector3>.get_Value
	|
	|-RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	|-SharedVariable<Vector4>.get_Value
	|
	|-RVA: 0x2569770 Offset: 0x2569871 VA: 0x2569770
	|-SharedVariable<uint>.get_Value
	|
	|-RVA: 0x256AC50 Offset: 0x256AD51 VA: 0x256AC50
	|-SharedVariable<LayerMask>.get_Value
	|
	|-RVA: 0x256D6D0 Offset: 0x256D7D1 VA: 0x256D6D0
	|-SharedVariable<Vector2Int>.get_Value
	|
	|-RVA: 0x256EBB0 Offset: 0x256ECB1 VA: 0x256EBB0
	|-SharedVariable<Vector3Int>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568360 Offset: 0x2568461 VA: 0x2568360
	|-SharedVariable<AIInput>.set_Value
	|-SharedVariable<EnemyBehaviorController>.set_Value
	|-SharedVariable<MonsterBehaviorController>.set_Value
	|-SharedVariable<PartnerNPCBehaviorController>.set_Value
	|-SharedVariable<List<CharacterBase>>.set_Value
	|-SharedVariable<List<GameObject>>.set_Value
	|-SharedVariable<List<Object>>.set_Value
	|-SharedVariable<List<Transform>>.set_Value
	|-SharedVariable<List<Vector3>>.set_Value
	|-SharedVariable<object>.set_Value
	|-SharedVariable<string>.set_Value
	|-SharedVariable<Behaviour>.set_Value
	|-SharedVariable<Collider>.set_Value
	|-SharedVariable<GameObject>.set_Value
	|-SharedVariable<Object>.set_Value
	|-SharedVariable<Transform>.set_Value
	|
	|-RVA: 0x25678B0 Offset: 0x25679B1 VA: 0x25678B0
	|-SharedVariable<AttackAttribute>.set_Value
	|-SharedVariable<EmotionType>.set_Value
	|-SharedVariable<FarmMonsterHutState>.set_Value
	|-SharedVariable<FarmMonsterState>.set_Value
	|-SharedVariable<FarmMonsterWorkState>.set_Value
	|-SharedVariable<ToolChargeLevel>.set_Value
	|-SharedVariable<EnemyBehaviorTreeState>.set_Value
	|-SharedVariable<MonsterActionBehaviorType>.set_Value
	|-SharedVariable<MonsterActionCategory>.set_Value
	|-SharedVariable<MovementBehaviorType>.set_Value
	|-SharedVariable<PartnerMovementOrderType>.set_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.set_Value
	|-SharedVariable<Int32Enum>.set_Value
	|
	|-RVA: 0x2566420 Offset: 0x2566521 VA: 0x2566420
	|-SharedVariable<bool>.set_Value
	|
	|-RVA: 0x2566E70 Offset: 0x2566F71 VA: 0x2566E70
	|-SharedVariable<int>.set_Value
	|
	|-RVA: 0x2568D60 Offset: 0x2568E61 VA: 0x2568D60
	|-SharedVariable<float>.set_Value
	|
	|-RVA: 0x25697A0 Offset: 0x25698A1 VA: 0x25697A0
	|-SharedVariable<uint>.set_Value
	|
	|-RVA: 0x256A1F0 Offset: 0x256A2F1 VA: 0x256A1F0
	|-SharedVariable<Color>.set_Value
	|
	|-RVA: 0x256AC90 Offset: 0x256AD91 VA: 0x256AC90
	|-SharedVariable<LayerMask>.set_Value
	|
	|-RVA: 0x256B770 Offset: 0x256B871 VA: 0x256B770
	|-SharedVariable<Quaternion>.set_Value
	|
	|-RVA: 0x256C210 Offset: 0x256C311 VA: 0x256C210
	|-SharedVariable<Rect>.set_Value
	|
	|-RVA: 0x256CCB0 Offset: 0x256CDB1 VA: 0x256CCB0
	|-SharedVariable<Vector2>.set_Value
	|
	|-RVA: 0x256D700 Offset: 0x256D801 VA: 0x256D700
	|-SharedVariable<Vector2Int>.set_Value
	|
	|-RVA: 0x256E150 Offset: 0x256E251 VA: 0x256E150
	|-SharedVariable<Vector3>.set_Value
	|
	|-RVA: 0x256EC00 Offset: 0x256ED01 VA: 0x256EC00
	|-SharedVariable<Vector3Int>.set_Value
	|
	|-RVA: 0x256F690 Offset: 0x256F791 VA: 0x256F690
	|-SharedVariable<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25679C0 Offset: 0x2567AC1 VA: 0x25679C0
	|-SharedVariable<AIInput.Action>.GetValue
	|-SharedVariable<Alliance>.GetValue
	|-SharedVariable<AttackAttribute>.GetValue
	|-SharedVariable<EmotionType>.GetValue
	|-SharedVariable<FarmMonsterHutState>.GetValue
	|-SharedVariable<FarmMonsterState>.GetValue
	|-SharedVariable<FarmMonsterWorkState>.GetValue
	|-SharedVariable<ToolChargeLevel>.GetValue
	|-SharedVariable<EnemyBehaviorTreeState>.GetValue
	|-SharedVariable<MonsterActionBehaviorType>.GetValue
	|-SharedVariable<MonsterActionCategory>.GetValue
	|-SharedVariable<MovementBehaviorType>.GetValue
	|-SharedVariable<PartnerMovementOrderType>.GetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.GetValue
	|-SharedVariable<Int32Enum>.GetValue
	|
	|-RVA: 0x2568420 Offset: 0x2568521 VA: 0x2568420
	|-SharedVariable<AIInput>.GetValue
	|-SharedVariable<GenericVariable>.GetValue
	|-SharedVariable<NamedVariable>.GetValue
	|-SharedVariable<EnemyBehaviorController>.GetValue
	|-SharedVariable<MonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerNPCBehaviorController>.GetValue
	|-SharedVariable<List<CharacterBase>>.GetValue
	|-SharedVariable<List<GameObject>>.GetValue
	|-SharedVariable<List<Object>>.GetValue
	|-SharedVariable<List<Transform>>.GetValue
	|-SharedVariable<List<Vector3>>.GetValue
	|-SharedVariable<object>.GetValue
	|-SharedVariable<string>.GetValue
	|-SharedVariable<AnimationCurve>.GetValue
	|-SharedVariable<Behaviour>.GetValue
	|-SharedVariable<Collider>.GetValue
	|-SharedVariable<GameObject>.GetValue
	|-SharedVariable<Material>.GetValue
	|-SharedVariable<Object>.GetValue
	|-SharedVariable<Transform>.GetValue
	|
	|-RVA: 0x2566500 Offset: 0x2566601 VA: 0x2566500
	|-SharedVariable<bool>.GetValue
	|
	|-RVA: 0x2566F40 Offset: 0x2567041 VA: 0x2566F40
	|-SharedVariable<int>.GetValue
	|
	|-RVA: 0x2568E30 Offset: 0x2568F31 VA: 0x2568E30
	|-SharedVariable<float>.GetValue
	|
	|-RVA: 0x2569870 Offset: 0x2569971 VA: 0x2569870
	|-SharedVariable<uint>.GetValue
	|
	|-RVA: 0x256A2F0 Offset: 0x256A3F1 VA: 0x256A2F0
	|-SharedVariable<Color>.GetValue
	|
	|-RVA: 0x256ADB0 Offset: 0x256AEB1 VA: 0x256ADB0
	|-SharedVariable<LayerMask>.GetValue
	|
	|-RVA: 0x256B870 Offset: 0x256B971 VA: 0x256B870
	|-SharedVariable<Quaternion>.GetValue
	|
	|-RVA: 0x256C310 Offset: 0x256C411 VA: 0x256C310
	|-SharedVariable<Rect>.GetValue
	|
	|-RVA: 0x256CD90 Offset: 0x256CE91 VA: 0x256CD90
	|-SharedVariable<Vector2>.GetValue
	|
	|-RVA: 0x256D7D0 Offset: 0x256D8D1 VA: 0x256D7D0
	|-SharedVariable<Vector2Int>.GetValue
	|
	|-RVA: 0x256E250 Offset: 0x256E351 VA: 0x256E250
	|-SharedVariable<Vector3>.GetValue
	|
	|-RVA: 0x256ECF0 Offset: 0x256EDF1 VA: 0x256ECF0
	|-SharedVariable<Vector3Int>.GetValue
	|
	|-RVA: 0x256F790 Offset: 0x256F891 VA: 0x256F790
	|-SharedVariable<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567A30 Offset: 0x2567B31 VA: 0x2567A30
	|-SharedVariable<AIInput.Action>.SetValue
	|-SharedVariable<Alliance>.SetValue
	|-SharedVariable<AttackAttribute>.SetValue
	|-SharedVariable<EmotionType>.SetValue
	|-SharedVariable<FarmMonsterHutState>.SetValue
	|-SharedVariable<FarmMonsterState>.SetValue
	|-SharedVariable<FarmMonsterWorkState>.SetValue
	|-SharedVariable<ToolChargeLevel>.SetValue
	|-SharedVariable<EnemyBehaviorTreeState>.SetValue
	|-SharedVariable<MonsterActionBehaviorType>.SetValue
	|-SharedVariable<MonsterActionCategory>.SetValue
	|-SharedVariable<MovementBehaviorType>.SetValue
	|-SharedVariable<PartnerMovementOrderType>.SetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.SetValue
	|-SharedVariable<Int32Enum>.SetValue
	|
	|-RVA: 0x2568450 Offset: 0x2568551 VA: 0x2568450
	|-SharedVariable<AIInput>.SetValue
	|-SharedVariable<GenericVariable>.SetValue
	|-SharedVariable<NamedVariable>.SetValue
	|-SharedVariable<EnemyBehaviorController>.SetValue
	|-SharedVariable<MonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerNPCBehaviorController>.SetValue
	|-SharedVariable<List<CharacterBase>>.SetValue
	|-SharedVariable<List<GameObject>>.SetValue
	|-SharedVariable<List<Object>>.SetValue
	|-SharedVariable<List<Transform>>.SetValue
	|-SharedVariable<List<Vector3>>.SetValue
	|-SharedVariable<object>.SetValue
	|-SharedVariable<string>.SetValue
	|-SharedVariable<AnimationCurve>.SetValue
	|-SharedVariable<Behaviour>.SetValue
	|-SharedVariable<Collider>.SetValue
	|-SharedVariable<GameObject>.SetValue
	|-SharedVariable<Material>.SetValue
	|-SharedVariable<Object>.SetValue
	|-SharedVariable<Transform>.SetValue
	|
	|-RVA: 0x2566570 Offset: 0x2566671 VA: 0x2566570
	|-SharedVariable<bool>.SetValue
	|
	|-RVA: 0x2566FB0 Offset: 0x25670B1 VA: 0x2566FB0
	|-SharedVariable<int>.SetValue
	|
	|-RVA: 0x2568EA0 Offset: 0x2568FA1 VA: 0x2568EA0
	|-SharedVariable<float>.SetValue
	|
	|-RVA: 0x25698E0 Offset: 0x25699E1 VA: 0x25698E0
	|-SharedVariable<uint>.SetValue
	|
	|-RVA: 0x256A360 Offset: 0x256A461 VA: 0x256A360
	|-SharedVariable<Color>.SetValue
	|
	|-RVA: 0x256AE20 Offset: 0x256AF21 VA: 0x256AE20
	|-SharedVariable<LayerMask>.SetValue
	|
	|-RVA: 0x256B8E0 Offset: 0x256B9E1 VA: 0x256B8E0
	|-SharedVariable<Quaternion>.SetValue
	|
	|-RVA: 0x256C380 Offset: 0x256C481 VA: 0x256C380
	|-SharedVariable<Rect>.SetValue
	|
	|-RVA: 0x256CE00 Offset: 0x256CF01 VA: 0x256CE00
	|-SharedVariable<Vector2>.SetValue
	|
	|-RVA: 0x256D840 Offset: 0x256D941 VA: 0x256D840
	|-SharedVariable<Vector2Int>.SetValue
	|
	|-RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	|-SharedVariable<Vector3>.SetValue
	|
	|-RVA: 0x256ED60 Offset: 0x256EE61 VA: 0x256ED60
	|-SharedVariable<Vector3Int>.SetValue
	|
	|-RVA: 0x256F800 Offset: 0x256F901 VA: 0x256F800
	|-SharedVariable<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568550 Offset: 0x2568651 VA: 0x2568550
	|-SharedVariable<AIInput>.ToString
	|-SharedVariable<GenericVariable>.ToString
	|-SharedVariable<NamedVariable>.ToString
	|-SharedVariable<EnemyBehaviorController>.ToString
	|-SharedVariable<MonsterBehaviorController>.ToString
	|-SharedVariable<PartnerNPCBehaviorController>.ToString
	|-SharedVariable<List<CharacterBase>>.ToString
	|-SharedVariable<List<GameObject>>.ToString
	|-SharedVariable<List<Object>>.ToString
	|-SharedVariable<List<Transform>>.ToString
	|-SharedVariable<List<Vector3>>.ToString
	|-SharedVariable<object>.ToString
	|-SharedVariable<string>.ToString
	|-SharedVariable<AnimationCurve>.ToString
	|-SharedVariable<Behaviour>.ToString
	|-SharedVariable<Collider>.ToString
	|-SharedVariable<GameObject>.ToString
	|-SharedVariable<Material>.ToString
	|-SharedVariable<Object>.ToString
	|-SharedVariable<Transform>.ToString
	|
	|-RVA: 0x2567B30 Offset: 0x2567C31 VA: 0x2567B30
	|-SharedVariable<EnemyBehaviorTreeState>.ToString
	|-SharedVariable<MonsterActionCategory>.ToString
	|-SharedVariable<MovementBehaviorType>.ToString
	|-SharedVariable<Int32Enum>.ToString
	|
	|-RVA: 0x2566670 Offset: 0x2566771 VA: 0x2566670
	|-SharedVariable<bool>.ToString
	|
	|-RVA: 0x25670B0 Offset: 0x25671B1 VA: 0x25670B0
	|-SharedVariable<int>.ToString
	|
	|-RVA: 0x2568FA0 Offset: 0x25690A1 VA: 0x2568FA0
	|-SharedVariable<float>.ToString
	|
	|-RVA: 0x25699E0 Offset: 0x2569AE1 VA: 0x25699E0
	|-SharedVariable<uint>.ToString
	|
	|-RVA: 0x256A470 Offset: 0x256A571 VA: 0x256A470
	|-SharedVariable<Color>.ToString
	|
	|-RVA: 0x256AF20 Offset: 0x256B021 VA: 0x256AF20
	|-SharedVariable<LayerMask>.ToString
	|
	|-RVA: 0x256B9F0 Offset: 0x256BAF1 VA: 0x256B9F0
	|-SharedVariable<Quaternion>.ToString
	|
	|-RVA: 0x256C490 Offset: 0x256C591 VA: 0x256C490
	|-SharedVariable<Rect>.ToString
	|
	|-RVA: 0x256CF00 Offset: 0x256D001 VA: 0x256CF00
	|-SharedVariable<Vector2>.ToString
	|
	|-RVA: 0x256D940 Offset: 0x256DA41 VA: 0x256D940
	|-SharedVariable<Vector2Int>.ToString
	|
	|-RVA: 0x256E3D0 Offset: 0x256E4D1 VA: 0x256E3D0
	|-SharedVariable<Vector3>.ToString
	|
	|-RVA: 0x256EE70 Offset: 0x256EF71 VA: 0x256EE70
	|-SharedVariable<Vector3Int>.ToString
	|
	|-RVA: 0x256F910 Offset: 0x256FA11 VA: 0x256F910
	|-SharedVariable<Vector4>.ToString
	*/
}

public abstract class SharedVariable<T> : SharedVariable // TypeDefIndex: 4711
{
	// Fields
	private Func<T> mGetter; // 0x0
	private Action<T> mSetter; // 0x0
	[SerializeField] // RVA: 0x12D830 Offset: 0x12D931 VA: 0x12D830
	protected T mValue; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567150 Offset: 0x2567251 VA: 0x2567150
	|-SharedVariable<AIInput.Action>..ctor
	|-SharedVariable<Alliance>..ctor
	|-SharedVariable<AttackAttribute>..ctor
	|-SharedVariable<EmotionType>..ctor
	|-SharedVariable<FarmMonsterHutState>..ctor
	|-SharedVariable<FarmMonsterState>..ctor
	|-SharedVariable<FarmMonsterWorkState>..ctor
	|-SharedVariable<ToolChargeLevel>..ctor
	|-SharedVariable<EnemyBehaviorTreeState>..ctor
	|-SharedVariable<MonsterActionBehaviorType>..ctor
	|-SharedVariable<MonsterActionCategory>..ctor
	|-SharedVariable<MovementBehaviorType>..ctor
	|-SharedVariable<PartnerMovementOrderType>..ctor
	|-SharedVariable<PartnerNPCActionBehaviorType>..ctor
	|-SharedVariable<Int32Enum>..ctor
	|
	|-RVA: 0x2567C00 Offset: 0x2567D01 VA: 0x2567C00
	|-SharedVariable<AIInput>..ctor
	|-SharedVariable<GenericVariable>..ctor
	|-SharedVariable<NamedVariable>..ctor
	|-SharedVariable<EnemyBehaviorController>..ctor
	|-SharedVariable<MonsterBehaviorController>..ctor
	|-SharedVariable<PartnerMonsterBehaviorController>..ctor
	|-SharedVariable<PartnerNPCBehaviorController>..ctor
	|-SharedVariable<List<CharacterBase>>..ctor
	|-SharedVariable<List<GameObject>>..ctor
	|-SharedVariable<List<Object>>..ctor
	|-SharedVariable<List<Transform>>..ctor
	|-SharedVariable<List<Vector3>>..ctor
	|-SharedVariable<object>..ctor
	|-SharedVariable<string>..ctor
	|-SharedVariable<AnimationCurve>..ctor
	|-SharedVariable<Behaviour>..ctor
	|-SharedVariable<Collider>..ctor
	|-SharedVariable<GameObject>..ctor
	|-SharedVariable<Material>..ctor
	|-SharedVariable<Object>..ctor
	|-SharedVariable<Transform>..ctor
	|
	|-RVA: 0x2565CC0 Offset: 0x2565DC1 VA: 0x2565CC0
	|-SharedVariable<bool>..ctor
	|
	|-RVA: 0x2566710 Offset: 0x2566811 VA: 0x2566710
	|-SharedVariable<int>..ctor
	|
	|-RVA: 0x2568600 Offset: 0x2568701 VA: 0x2568600
	|-SharedVariable<float>..ctor
	|
	|-RVA: 0x2569040 Offset: 0x2569141 VA: 0x2569040
	|-SharedVariable<uint>..ctor
	|
	|-RVA: 0x2569A80 Offset: 0x2569B81 VA: 0x2569A80
	|-SharedVariable<Color>..ctor
	|
	|-RVA: 0x256A520 Offset: 0x256A621 VA: 0x256A520
	|-SharedVariable<LayerMask>..ctor
	|
	|-RVA: 0x256B000 Offset: 0x256B101 VA: 0x256B000
	|-SharedVariable<Quaternion>..ctor
	|
	|-RVA: 0x256BAA0 Offset: 0x256BBA1 VA: 0x256BAA0
	|-SharedVariable<Rect>..ctor
	|
	|-RVA: 0x256C540 Offset: 0x256C641 VA: 0x256C540
	|-SharedVariable<Vector2>..ctor
	|
	|-RVA: 0x256CFA0 Offset: 0x256D0A1 VA: 0x256CFA0
	|-SharedVariable<Vector2Int>..ctor
	|
	|-RVA: 0x256D9E0 Offset: 0x256DAE1 VA: 0x256D9E0
	|-SharedVariable<Vector3>..ctor
	|
	|-RVA: 0x256E480 Offset: 0x256E581 VA: 0x256E480
	|-SharedVariable<Vector3Int>..ctor
	|
	|-RVA: 0x256EF20 Offset: 0x256F021 VA: 0x256EF20
	|-SharedVariable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void InitializePropertyMapping(BehaviorSource behaviorSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567170 Offset: 0x2567271 VA: 0x2567170
	|-SharedVariable<AIInput.Action>.InitializePropertyMapping
	|-SharedVariable<Alliance>.InitializePropertyMapping
	|-SharedVariable<AttackAttribute>.InitializePropertyMapping
	|-SharedVariable<EmotionType>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterHutState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterWorkState>.InitializePropertyMapping
	|-SharedVariable<ToolChargeLevel>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorTreeState>.InitializePropertyMapping
	|-SharedVariable<MonsterActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<MonsterActionCategory>.InitializePropertyMapping
	|-SharedVariable<MovementBehaviorType>.InitializePropertyMapping
	|-SharedVariable<PartnerMovementOrderType>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<Int32Enum>.InitializePropertyMapping
	|
	|-RVA: 0x2567C20 Offset: 0x2567D21 VA: 0x2567C20
	|-SharedVariable<AIInput>.InitializePropertyMapping
	|-SharedVariable<GenericVariable>.InitializePropertyMapping
	|-SharedVariable<NamedVariable>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorController>.InitializePropertyMapping
	|-SharedVariable<MonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerMonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCBehaviorController>.InitializePropertyMapping
	|-SharedVariable<List<CharacterBase>>.InitializePropertyMapping
	|-SharedVariable<List<GameObject>>.InitializePropertyMapping
	|-SharedVariable<List<Object>>.InitializePropertyMapping
	|-SharedVariable<List<Transform>>.InitializePropertyMapping
	|-SharedVariable<List<Vector3>>.InitializePropertyMapping
	|-SharedVariable<object>.InitializePropertyMapping
	|-SharedVariable<string>.InitializePropertyMapping
	|-SharedVariable<AnimationCurve>.InitializePropertyMapping
	|-SharedVariable<Behaviour>.InitializePropertyMapping
	|-SharedVariable<Collider>.InitializePropertyMapping
	|-SharedVariable<GameObject>.InitializePropertyMapping
	|-SharedVariable<Material>.InitializePropertyMapping
	|-SharedVariable<Object>.InitializePropertyMapping
	|-SharedVariable<Transform>.InitializePropertyMapping
	|
	|-RVA: 0x2565CE0 Offset: 0x2565DE1 VA: 0x2565CE0
	|-SharedVariable<bool>.InitializePropertyMapping
	|
	|-RVA: 0x2566730 Offset: 0x2566831 VA: 0x2566730
	|-SharedVariable<int>.InitializePropertyMapping
	|
	|-RVA: 0x2568620 Offset: 0x2568721 VA: 0x2568620
	|-SharedVariable<float>.InitializePropertyMapping
	|
	|-RVA: 0x2569060 Offset: 0x2569161 VA: 0x2569060
	|-SharedVariable<uint>.InitializePropertyMapping
	|
	|-RVA: 0x2569AA0 Offset: 0x2569BA1 VA: 0x2569AA0
	|-SharedVariable<Color>.InitializePropertyMapping
	|
	|-RVA: 0x256A540 Offset: 0x256A641 VA: 0x256A540
	|-SharedVariable<LayerMask>.InitializePropertyMapping
	|
	|-RVA: 0x256B020 Offset: 0x256B121 VA: 0x256B020
	|-SharedVariable<Quaternion>.InitializePropertyMapping
	|
	|-RVA: 0x256BAC0 Offset: 0x256BBC1 VA: 0x256BAC0
	|-SharedVariable<Rect>.InitializePropertyMapping
	|
	|-RVA: 0x256C560 Offset: 0x256C661 VA: 0x256C560
	|-SharedVariable<Vector2>.InitializePropertyMapping
	|
	|-RVA: 0x256CFC0 Offset: 0x256D0C1 VA: 0x256CFC0
	|-SharedVariable<Vector2Int>.InitializePropertyMapping
	|
	|-RVA: 0x256DA00 Offset: 0x256DB01 VA: 0x256DA00
	|-SharedVariable<Vector3>.InitializePropertyMapping
	|
	|-RVA: 0x256E4A0 Offset: 0x256E5A1 VA: 0x256E4A0
	|-SharedVariable<Vector3Int>.InitializePropertyMapping
	|
	|-RVA: 0x256EF40 Offset: 0x256F041 VA: 0x256EF40
	|-SharedVariable<Vector4>.InitializePropertyMapping
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568330 Offset: 0x2568431 VA: 0x2568330
	|-SharedVariable<AIInput>.get_Value
	|-SharedVariable<EnemyBehaviorController>.get_Value
	|-SharedVariable<MonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerMonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerNPCBehaviorController>.get_Value
	|-SharedVariable<List<GameObject>>.get_Value
	|-SharedVariable<List<Object>>.get_Value
	|-SharedVariable<List<Transform>>.get_Value
	|-SharedVariable<List<Vector3>>.get_Value
	|-SharedVariable<string>.get_Value
	|-SharedVariable<Behaviour>.get_Value
	|-SharedVariable<Collider>.get_Value
	|-SharedVariable<GameObject>.get_Value
	|-SharedVariable<Material>.get_Value
	|-SharedVariable<Object>.get_Value
	|-SharedVariable<Transform>.get_Value
	|-SharedVariable<GenericVariable>.get_Value
	|-SharedVariable<NamedVariable>.get_Value
	|-SharedVariable<object>.get_Value
	|
	|-RVA: 0x2567880 Offset: 0x2567981 VA: 0x2567880
	|-SharedVariable<AttackAttribute>.get_Value
	|-SharedVariable<EmotionType>.get_Value
	|-SharedVariable<FarmMonsterHutState>.get_Value
	|-SharedVariable<FarmMonsterState>.get_Value
	|-SharedVariable<FarmMonsterWorkState>.get_Value
	|-SharedVariable<ToolChargeLevel>.get_Value
	|-SharedVariable<EnemyBehaviorTreeState>.get_Value
	|-SharedVariable<MonsterActionBehaviorType>.get_Value
	|-SharedVariable<MonsterActionCategory>.get_Value
	|-SharedVariable<MovementBehaviorType>.get_Value
	|-SharedVariable<PartnerMovementOrderType>.get_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.get_Value
	|-SharedVariable<Int32Enum>.get_Value
	|
	|-RVA: 0x25663F0 Offset: 0x25664F1 VA: 0x25663F0
	|-SharedVariable<bool>.get_Value
	|
	|-RVA: 0x2566E40 Offset: 0x2566F41 VA: 0x2566E40
	|-SharedVariable<int>.get_Value
	|
	|-RVA: 0x2568D30 Offset: 0x2568E31 VA: 0x2568D30
	|-SharedVariable<float>.get_Value
	|
	|-RVA: 0x256A1B0 Offset: 0x256A2B1 VA: 0x256A1B0
	|-SharedVariable<Color>.get_Value
	|
	|-RVA: 0x256B730 Offset: 0x256B831 VA: 0x256B730
	|-SharedVariable<Quaternion>.get_Value
	|
	|-RVA: 0x256C1D0 Offset: 0x256C2D1 VA: 0x256C1D0
	|-SharedVariable<Rect>.get_Value
	|
	|-RVA: 0x256CC70 Offset: 0x256CD71 VA: 0x256CC70
	|-SharedVariable<Vector2>.get_Value
	|
	|-RVA: 0x256E110 Offset: 0x256E211 VA: 0x256E110
	|-SharedVariable<Vector3>.get_Value
	|
	|-RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	|-SharedVariable<Vector4>.get_Value
	|
	|-RVA: 0x2569770 Offset: 0x2569871 VA: 0x2569770
	|-SharedVariable<uint>.get_Value
	|
	|-RVA: 0x256AC50 Offset: 0x256AD51 VA: 0x256AC50
	|-SharedVariable<LayerMask>.get_Value
	|
	|-RVA: 0x256D6D0 Offset: 0x256D7D1 VA: 0x256D6D0
	|-SharedVariable<Vector2Int>.get_Value
	|
	|-RVA: 0x256EBB0 Offset: 0x256ECB1 VA: 0x256EBB0
	|-SharedVariable<Vector3Int>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568360 Offset: 0x2568461 VA: 0x2568360
	|-SharedVariable<AIInput>.set_Value
	|-SharedVariable<EnemyBehaviorController>.set_Value
	|-SharedVariable<MonsterBehaviorController>.set_Value
	|-SharedVariable<PartnerNPCBehaviorController>.set_Value
	|-SharedVariable<List<CharacterBase>>.set_Value
	|-SharedVariable<List<GameObject>>.set_Value
	|-SharedVariable<List<Object>>.set_Value
	|-SharedVariable<List<Transform>>.set_Value
	|-SharedVariable<List<Vector3>>.set_Value
	|-SharedVariable<object>.set_Value
	|-SharedVariable<string>.set_Value
	|-SharedVariable<Behaviour>.set_Value
	|-SharedVariable<Collider>.set_Value
	|-SharedVariable<GameObject>.set_Value
	|-SharedVariable<Object>.set_Value
	|-SharedVariable<Transform>.set_Value
	|
	|-RVA: 0x25678B0 Offset: 0x25679B1 VA: 0x25678B0
	|-SharedVariable<AttackAttribute>.set_Value
	|-SharedVariable<EmotionType>.set_Value
	|-SharedVariable<FarmMonsterHutState>.set_Value
	|-SharedVariable<FarmMonsterState>.set_Value
	|-SharedVariable<FarmMonsterWorkState>.set_Value
	|-SharedVariable<ToolChargeLevel>.set_Value
	|-SharedVariable<EnemyBehaviorTreeState>.set_Value
	|-SharedVariable<MonsterActionBehaviorType>.set_Value
	|-SharedVariable<MonsterActionCategory>.set_Value
	|-SharedVariable<MovementBehaviorType>.set_Value
	|-SharedVariable<PartnerMovementOrderType>.set_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.set_Value
	|-SharedVariable<Int32Enum>.set_Value
	|
	|-RVA: 0x2566420 Offset: 0x2566521 VA: 0x2566420
	|-SharedVariable<bool>.set_Value
	|
	|-RVA: 0x2566E70 Offset: 0x2566F71 VA: 0x2566E70
	|-SharedVariable<int>.set_Value
	|
	|-RVA: 0x2568D60 Offset: 0x2568E61 VA: 0x2568D60
	|-SharedVariable<float>.set_Value
	|
	|-RVA: 0x25697A0 Offset: 0x25698A1 VA: 0x25697A0
	|-SharedVariable<uint>.set_Value
	|
	|-RVA: 0x256A1F0 Offset: 0x256A2F1 VA: 0x256A1F0
	|-SharedVariable<Color>.set_Value
	|
	|-RVA: 0x256AC90 Offset: 0x256AD91 VA: 0x256AC90
	|-SharedVariable<LayerMask>.set_Value
	|
	|-RVA: 0x256B770 Offset: 0x256B871 VA: 0x256B770
	|-SharedVariable<Quaternion>.set_Value
	|
	|-RVA: 0x256C210 Offset: 0x256C311 VA: 0x256C210
	|-SharedVariable<Rect>.set_Value
	|
	|-RVA: 0x256CCB0 Offset: 0x256CDB1 VA: 0x256CCB0
	|-SharedVariable<Vector2>.set_Value
	|
	|-RVA: 0x256D700 Offset: 0x256D801 VA: 0x256D700
	|-SharedVariable<Vector2Int>.set_Value
	|
	|-RVA: 0x256E150 Offset: 0x256E251 VA: 0x256E150
	|-SharedVariable<Vector3>.set_Value
	|
	|-RVA: 0x256EC00 Offset: 0x256ED01 VA: 0x256EC00
	|-SharedVariable<Vector3Int>.set_Value
	|
	|-RVA: 0x256F690 Offset: 0x256F791 VA: 0x256F690
	|-SharedVariable<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25679C0 Offset: 0x2567AC1 VA: 0x25679C0
	|-SharedVariable<AIInput.Action>.GetValue
	|-SharedVariable<Alliance>.GetValue
	|-SharedVariable<AttackAttribute>.GetValue
	|-SharedVariable<EmotionType>.GetValue
	|-SharedVariable<FarmMonsterHutState>.GetValue
	|-SharedVariable<FarmMonsterState>.GetValue
	|-SharedVariable<FarmMonsterWorkState>.GetValue
	|-SharedVariable<ToolChargeLevel>.GetValue
	|-SharedVariable<EnemyBehaviorTreeState>.GetValue
	|-SharedVariable<MonsterActionBehaviorType>.GetValue
	|-SharedVariable<MonsterActionCategory>.GetValue
	|-SharedVariable<MovementBehaviorType>.GetValue
	|-SharedVariable<PartnerMovementOrderType>.GetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.GetValue
	|-SharedVariable<Int32Enum>.GetValue
	|
	|-RVA: 0x2568420 Offset: 0x2568521 VA: 0x2568420
	|-SharedVariable<AIInput>.GetValue
	|-SharedVariable<GenericVariable>.GetValue
	|-SharedVariable<NamedVariable>.GetValue
	|-SharedVariable<EnemyBehaviorController>.GetValue
	|-SharedVariable<MonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerNPCBehaviorController>.GetValue
	|-SharedVariable<List<CharacterBase>>.GetValue
	|-SharedVariable<List<GameObject>>.GetValue
	|-SharedVariable<List<Object>>.GetValue
	|-SharedVariable<List<Transform>>.GetValue
	|-SharedVariable<List<Vector3>>.GetValue
	|-SharedVariable<object>.GetValue
	|-SharedVariable<string>.GetValue
	|-SharedVariable<AnimationCurve>.GetValue
	|-SharedVariable<Behaviour>.GetValue
	|-SharedVariable<Collider>.GetValue
	|-SharedVariable<GameObject>.GetValue
	|-SharedVariable<Material>.GetValue
	|-SharedVariable<Object>.GetValue
	|-SharedVariable<Transform>.GetValue
	|
	|-RVA: 0x2566500 Offset: 0x2566601 VA: 0x2566500
	|-SharedVariable<bool>.GetValue
	|
	|-RVA: 0x2566F40 Offset: 0x2567041 VA: 0x2566F40
	|-SharedVariable<int>.GetValue
	|
	|-RVA: 0x2568E30 Offset: 0x2568F31 VA: 0x2568E30
	|-SharedVariable<float>.GetValue
	|
	|-RVA: 0x2569870 Offset: 0x2569971 VA: 0x2569870
	|-SharedVariable<uint>.GetValue
	|
	|-RVA: 0x256A2F0 Offset: 0x256A3F1 VA: 0x256A2F0
	|-SharedVariable<Color>.GetValue
	|
	|-RVA: 0x256ADB0 Offset: 0x256AEB1 VA: 0x256ADB0
	|-SharedVariable<LayerMask>.GetValue
	|
	|-RVA: 0x256B870 Offset: 0x256B971 VA: 0x256B870
	|-SharedVariable<Quaternion>.GetValue
	|
	|-RVA: 0x256C310 Offset: 0x256C411 VA: 0x256C310
	|-SharedVariable<Rect>.GetValue
	|
	|-RVA: 0x256CD90 Offset: 0x256CE91 VA: 0x256CD90
	|-SharedVariable<Vector2>.GetValue
	|
	|-RVA: 0x256D7D0 Offset: 0x256D8D1 VA: 0x256D7D0
	|-SharedVariable<Vector2Int>.GetValue
	|
	|-RVA: 0x256E250 Offset: 0x256E351 VA: 0x256E250
	|-SharedVariable<Vector3>.GetValue
	|
	|-RVA: 0x256ECF0 Offset: 0x256EDF1 VA: 0x256ECF0
	|-SharedVariable<Vector3Int>.GetValue
	|
	|-RVA: 0x256F790 Offset: 0x256F891 VA: 0x256F790
	|-SharedVariable<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567A30 Offset: 0x2567B31 VA: 0x2567A30
	|-SharedVariable<AIInput.Action>.SetValue
	|-SharedVariable<Alliance>.SetValue
	|-SharedVariable<AttackAttribute>.SetValue
	|-SharedVariable<EmotionType>.SetValue
	|-SharedVariable<FarmMonsterHutState>.SetValue
	|-SharedVariable<FarmMonsterState>.SetValue
	|-SharedVariable<FarmMonsterWorkState>.SetValue
	|-SharedVariable<ToolChargeLevel>.SetValue
	|-SharedVariable<EnemyBehaviorTreeState>.SetValue
	|-SharedVariable<MonsterActionBehaviorType>.SetValue
	|-SharedVariable<MonsterActionCategory>.SetValue
	|-SharedVariable<MovementBehaviorType>.SetValue
	|-SharedVariable<PartnerMovementOrderType>.SetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.SetValue
	|-SharedVariable<Int32Enum>.SetValue
	|
	|-RVA: 0x2568450 Offset: 0x2568551 VA: 0x2568450
	|-SharedVariable<AIInput>.SetValue
	|-SharedVariable<GenericVariable>.SetValue
	|-SharedVariable<NamedVariable>.SetValue
	|-SharedVariable<EnemyBehaviorController>.SetValue
	|-SharedVariable<MonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerNPCBehaviorController>.SetValue
	|-SharedVariable<List<CharacterBase>>.SetValue
	|-SharedVariable<List<GameObject>>.SetValue
	|-SharedVariable<List<Object>>.SetValue
	|-SharedVariable<List<Transform>>.SetValue
	|-SharedVariable<List<Vector3>>.SetValue
	|-SharedVariable<object>.SetValue
	|-SharedVariable<string>.SetValue
	|-SharedVariable<AnimationCurve>.SetValue
	|-SharedVariable<Behaviour>.SetValue
	|-SharedVariable<Collider>.SetValue
	|-SharedVariable<GameObject>.SetValue
	|-SharedVariable<Material>.SetValue
	|-SharedVariable<Object>.SetValue
	|-SharedVariable<Transform>.SetValue
	|
	|-RVA: 0x2566570 Offset: 0x2566671 VA: 0x2566570
	|-SharedVariable<bool>.SetValue
	|
	|-RVA: 0x2566FB0 Offset: 0x25670B1 VA: 0x2566FB0
	|-SharedVariable<int>.SetValue
	|
	|-RVA: 0x2568EA0 Offset: 0x2568FA1 VA: 0x2568EA0
	|-SharedVariable<float>.SetValue
	|
	|-RVA: 0x25698E0 Offset: 0x25699E1 VA: 0x25698E0
	|-SharedVariable<uint>.SetValue
	|
	|-RVA: 0x256A360 Offset: 0x256A461 VA: 0x256A360
	|-SharedVariable<Color>.SetValue
	|
	|-RVA: 0x256AE20 Offset: 0x256AF21 VA: 0x256AE20
	|-SharedVariable<LayerMask>.SetValue
	|
	|-RVA: 0x256B8E0 Offset: 0x256B9E1 VA: 0x256B8E0
	|-SharedVariable<Quaternion>.SetValue
	|
	|-RVA: 0x256C380 Offset: 0x256C481 VA: 0x256C380
	|-SharedVariable<Rect>.SetValue
	|
	|-RVA: 0x256CE00 Offset: 0x256CF01 VA: 0x256CE00
	|-SharedVariable<Vector2>.SetValue
	|
	|-RVA: 0x256D840 Offset: 0x256D941 VA: 0x256D840
	|-SharedVariable<Vector2Int>.SetValue
	|
	|-RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	|-SharedVariable<Vector3>.SetValue
	|
	|-RVA: 0x256ED60 Offset: 0x256EE61 VA: 0x256ED60
	|-SharedVariable<Vector3Int>.SetValue
	|
	|-RVA: 0x256F800 Offset: 0x256F901 VA: 0x256F800
	|-SharedVariable<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568550 Offset: 0x2568651 VA: 0x2568550
	|-SharedVariable<AIInput>.ToString
	|-SharedVariable<GenericVariable>.ToString
	|-SharedVariable<NamedVariable>.ToString
	|-SharedVariable<EnemyBehaviorController>.ToString
	|-SharedVariable<MonsterBehaviorController>.ToString
	|-SharedVariable<PartnerNPCBehaviorController>.ToString
	|-SharedVariable<List<CharacterBase>>.ToString
	|-SharedVariable<List<GameObject>>.ToString
	|-SharedVariable<List<Object>>.ToString
	|-SharedVariable<List<Transform>>.ToString
	|-SharedVariable<List<Vector3>>.ToString
	|-SharedVariable<object>.ToString
	|-SharedVariable<string>.ToString
	|-SharedVariable<AnimationCurve>.ToString
	|-SharedVariable<Behaviour>.ToString
	|-SharedVariable<Collider>.ToString
	|-SharedVariable<GameObject>.ToString
	|-SharedVariable<Material>.ToString
	|-SharedVariable<Object>.ToString
	|-SharedVariable<Transform>.ToString
	|
	|-RVA: 0x2567B30 Offset: 0x2567C31 VA: 0x2567B30
	|-SharedVariable<EnemyBehaviorTreeState>.ToString
	|-SharedVariable<MonsterActionCategory>.ToString
	|-SharedVariable<MovementBehaviorType>.ToString
	|-SharedVariable<Int32Enum>.ToString
	|
	|-RVA: 0x2566670 Offset: 0x2566771 VA: 0x2566670
	|-SharedVariable<bool>.ToString
	|
	|-RVA: 0x25670B0 Offset: 0x25671B1 VA: 0x25670B0
	|-SharedVariable<int>.ToString
	|
	|-RVA: 0x2568FA0 Offset: 0x25690A1 VA: 0x2568FA0
	|-SharedVariable<float>.ToString
	|
	|-RVA: 0x25699E0 Offset: 0x2569AE1 VA: 0x25699E0
	|-SharedVariable<uint>.ToString
	|
	|-RVA: 0x256A470 Offset: 0x256A571 VA: 0x256A470
	|-SharedVariable<Color>.ToString
	|
	|-RVA: 0x256AF20 Offset: 0x256B021 VA: 0x256AF20
	|-SharedVariable<LayerMask>.ToString
	|
	|-RVA: 0x256B9F0 Offset: 0x256BAF1 VA: 0x256B9F0
	|-SharedVariable<Quaternion>.ToString
	|
	|-RVA: 0x256C490 Offset: 0x256C591 VA: 0x256C490
	|-SharedVariable<Rect>.ToString
	|
	|-RVA: 0x256CF00 Offset: 0x256D001 VA: 0x256CF00
	|-SharedVariable<Vector2>.ToString
	|
	|-RVA: 0x256D940 Offset: 0x256DA41 VA: 0x256D940
	|-SharedVariable<Vector2Int>.ToString
	|
	|-RVA: 0x256E3D0 Offset: 0x256E4D1 VA: 0x256E3D0
	|-SharedVariable<Vector3>.ToString
	|
	|-RVA: 0x256EE70 Offset: 0x256EF71 VA: 0x256EE70
	|-SharedVariable<Vector3Int>.ToString
	|
	|-RVA: 0x256F910 Offset: 0x256FA11 VA: 0x256F910
	|-SharedVariable<Vector4>.ToString
	*/
}

public abstract class SharedVariable<T> : SharedVariable // TypeDefIndex: 4711
{
	// Fields
	private Func<T> mGetter; // 0x0
	private Action<T> mSetter; // 0x0
	[SerializeField] // RVA: 0x12D830 Offset: 0x12D931 VA: 0x12D830
	protected T mValue; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567150 Offset: 0x2567251 VA: 0x2567150
	|-SharedVariable<AIInput.Action>..ctor
	|-SharedVariable<Alliance>..ctor
	|-SharedVariable<AttackAttribute>..ctor
	|-SharedVariable<EmotionType>..ctor
	|-SharedVariable<FarmMonsterHutState>..ctor
	|-SharedVariable<FarmMonsterState>..ctor
	|-SharedVariable<FarmMonsterWorkState>..ctor
	|-SharedVariable<ToolChargeLevel>..ctor
	|-SharedVariable<EnemyBehaviorTreeState>..ctor
	|-SharedVariable<MonsterActionBehaviorType>..ctor
	|-SharedVariable<MonsterActionCategory>..ctor
	|-SharedVariable<MovementBehaviorType>..ctor
	|-SharedVariable<PartnerMovementOrderType>..ctor
	|-SharedVariable<PartnerNPCActionBehaviorType>..ctor
	|-SharedVariable<Int32Enum>..ctor
	|
	|-RVA: 0x2567C00 Offset: 0x2567D01 VA: 0x2567C00
	|-SharedVariable<AIInput>..ctor
	|-SharedVariable<GenericVariable>..ctor
	|-SharedVariable<NamedVariable>..ctor
	|-SharedVariable<EnemyBehaviorController>..ctor
	|-SharedVariable<MonsterBehaviorController>..ctor
	|-SharedVariable<PartnerMonsterBehaviorController>..ctor
	|-SharedVariable<PartnerNPCBehaviorController>..ctor
	|-SharedVariable<List<CharacterBase>>..ctor
	|-SharedVariable<List<GameObject>>..ctor
	|-SharedVariable<List<Object>>..ctor
	|-SharedVariable<List<Transform>>..ctor
	|-SharedVariable<List<Vector3>>..ctor
	|-SharedVariable<object>..ctor
	|-SharedVariable<string>..ctor
	|-SharedVariable<AnimationCurve>..ctor
	|-SharedVariable<Behaviour>..ctor
	|-SharedVariable<Collider>..ctor
	|-SharedVariable<GameObject>..ctor
	|-SharedVariable<Material>..ctor
	|-SharedVariable<Object>..ctor
	|-SharedVariable<Transform>..ctor
	|
	|-RVA: 0x2565CC0 Offset: 0x2565DC1 VA: 0x2565CC0
	|-SharedVariable<bool>..ctor
	|
	|-RVA: 0x2566710 Offset: 0x2566811 VA: 0x2566710
	|-SharedVariable<int>..ctor
	|
	|-RVA: 0x2568600 Offset: 0x2568701 VA: 0x2568600
	|-SharedVariable<float>..ctor
	|
	|-RVA: 0x2569040 Offset: 0x2569141 VA: 0x2569040
	|-SharedVariable<uint>..ctor
	|
	|-RVA: 0x2569A80 Offset: 0x2569B81 VA: 0x2569A80
	|-SharedVariable<Color>..ctor
	|
	|-RVA: 0x256A520 Offset: 0x256A621 VA: 0x256A520
	|-SharedVariable<LayerMask>..ctor
	|
	|-RVA: 0x256B000 Offset: 0x256B101 VA: 0x256B000
	|-SharedVariable<Quaternion>..ctor
	|
	|-RVA: 0x256BAA0 Offset: 0x256BBA1 VA: 0x256BAA0
	|-SharedVariable<Rect>..ctor
	|
	|-RVA: 0x256C540 Offset: 0x256C641 VA: 0x256C540
	|-SharedVariable<Vector2>..ctor
	|
	|-RVA: 0x256CFA0 Offset: 0x256D0A1 VA: 0x256CFA0
	|-SharedVariable<Vector2Int>..ctor
	|
	|-RVA: 0x256D9E0 Offset: 0x256DAE1 VA: 0x256D9E0
	|-SharedVariable<Vector3>..ctor
	|
	|-RVA: 0x256E480 Offset: 0x256E581 VA: 0x256E480
	|-SharedVariable<Vector3Int>..ctor
	|
	|-RVA: 0x256EF20 Offset: 0x256F021 VA: 0x256EF20
	|-SharedVariable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void InitializePropertyMapping(BehaviorSource behaviorSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567170 Offset: 0x2567271 VA: 0x2567170
	|-SharedVariable<AIInput.Action>.InitializePropertyMapping
	|-SharedVariable<Alliance>.InitializePropertyMapping
	|-SharedVariable<AttackAttribute>.InitializePropertyMapping
	|-SharedVariable<EmotionType>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterHutState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterWorkState>.InitializePropertyMapping
	|-SharedVariable<ToolChargeLevel>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorTreeState>.InitializePropertyMapping
	|-SharedVariable<MonsterActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<MonsterActionCategory>.InitializePropertyMapping
	|-SharedVariable<MovementBehaviorType>.InitializePropertyMapping
	|-SharedVariable<PartnerMovementOrderType>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<Int32Enum>.InitializePropertyMapping
	|
	|-RVA: 0x2567C20 Offset: 0x2567D21 VA: 0x2567C20
	|-SharedVariable<AIInput>.InitializePropertyMapping
	|-SharedVariable<GenericVariable>.InitializePropertyMapping
	|-SharedVariable<NamedVariable>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorController>.InitializePropertyMapping
	|-SharedVariable<MonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerMonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCBehaviorController>.InitializePropertyMapping
	|-SharedVariable<List<CharacterBase>>.InitializePropertyMapping
	|-SharedVariable<List<GameObject>>.InitializePropertyMapping
	|-SharedVariable<List<Object>>.InitializePropertyMapping
	|-SharedVariable<List<Transform>>.InitializePropertyMapping
	|-SharedVariable<List<Vector3>>.InitializePropertyMapping
	|-SharedVariable<object>.InitializePropertyMapping
	|-SharedVariable<string>.InitializePropertyMapping
	|-SharedVariable<AnimationCurve>.InitializePropertyMapping
	|-SharedVariable<Behaviour>.InitializePropertyMapping
	|-SharedVariable<Collider>.InitializePropertyMapping
	|-SharedVariable<GameObject>.InitializePropertyMapping
	|-SharedVariable<Material>.InitializePropertyMapping
	|-SharedVariable<Object>.InitializePropertyMapping
	|-SharedVariable<Transform>.InitializePropertyMapping
	|
	|-RVA: 0x2565CE0 Offset: 0x2565DE1 VA: 0x2565CE0
	|-SharedVariable<bool>.InitializePropertyMapping
	|
	|-RVA: 0x2566730 Offset: 0x2566831 VA: 0x2566730
	|-SharedVariable<int>.InitializePropertyMapping
	|
	|-RVA: 0x2568620 Offset: 0x2568721 VA: 0x2568620
	|-SharedVariable<float>.InitializePropertyMapping
	|
	|-RVA: 0x2569060 Offset: 0x2569161 VA: 0x2569060
	|-SharedVariable<uint>.InitializePropertyMapping
	|
	|-RVA: 0x2569AA0 Offset: 0x2569BA1 VA: 0x2569AA0
	|-SharedVariable<Color>.InitializePropertyMapping
	|
	|-RVA: 0x256A540 Offset: 0x256A641 VA: 0x256A540
	|-SharedVariable<LayerMask>.InitializePropertyMapping
	|
	|-RVA: 0x256B020 Offset: 0x256B121 VA: 0x256B020
	|-SharedVariable<Quaternion>.InitializePropertyMapping
	|
	|-RVA: 0x256BAC0 Offset: 0x256BBC1 VA: 0x256BAC0
	|-SharedVariable<Rect>.InitializePropertyMapping
	|
	|-RVA: 0x256C560 Offset: 0x256C661 VA: 0x256C560
	|-SharedVariable<Vector2>.InitializePropertyMapping
	|
	|-RVA: 0x256CFC0 Offset: 0x256D0C1 VA: 0x256CFC0
	|-SharedVariable<Vector2Int>.InitializePropertyMapping
	|
	|-RVA: 0x256DA00 Offset: 0x256DB01 VA: 0x256DA00
	|-SharedVariable<Vector3>.InitializePropertyMapping
	|
	|-RVA: 0x256E4A0 Offset: 0x256E5A1 VA: 0x256E4A0
	|-SharedVariable<Vector3Int>.InitializePropertyMapping
	|
	|-RVA: 0x256EF40 Offset: 0x256F041 VA: 0x256EF40
	|-SharedVariable<Vector4>.InitializePropertyMapping
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568330 Offset: 0x2568431 VA: 0x2568330
	|-SharedVariable<AIInput>.get_Value
	|-SharedVariable<EnemyBehaviorController>.get_Value
	|-SharedVariable<MonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerMonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerNPCBehaviorController>.get_Value
	|-SharedVariable<List<GameObject>>.get_Value
	|-SharedVariable<List<Object>>.get_Value
	|-SharedVariable<List<Transform>>.get_Value
	|-SharedVariable<List<Vector3>>.get_Value
	|-SharedVariable<string>.get_Value
	|-SharedVariable<Behaviour>.get_Value
	|-SharedVariable<Collider>.get_Value
	|-SharedVariable<GameObject>.get_Value
	|-SharedVariable<Material>.get_Value
	|-SharedVariable<Object>.get_Value
	|-SharedVariable<Transform>.get_Value
	|-SharedVariable<GenericVariable>.get_Value
	|-SharedVariable<NamedVariable>.get_Value
	|-SharedVariable<object>.get_Value
	|
	|-RVA: 0x2567880 Offset: 0x2567981 VA: 0x2567880
	|-SharedVariable<AttackAttribute>.get_Value
	|-SharedVariable<EmotionType>.get_Value
	|-SharedVariable<FarmMonsterHutState>.get_Value
	|-SharedVariable<FarmMonsterState>.get_Value
	|-SharedVariable<FarmMonsterWorkState>.get_Value
	|-SharedVariable<ToolChargeLevel>.get_Value
	|-SharedVariable<EnemyBehaviorTreeState>.get_Value
	|-SharedVariable<MonsterActionBehaviorType>.get_Value
	|-SharedVariable<MonsterActionCategory>.get_Value
	|-SharedVariable<MovementBehaviorType>.get_Value
	|-SharedVariable<PartnerMovementOrderType>.get_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.get_Value
	|-SharedVariable<Int32Enum>.get_Value
	|
	|-RVA: 0x25663F0 Offset: 0x25664F1 VA: 0x25663F0
	|-SharedVariable<bool>.get_Value
	|
	|-RVA: 0x2566E40 Offset: 0x2566F41 VA: 0x2566E40
	|-SharedVariable<int>.get_Value
	|
	|-RVA: 0x2568D30 Offset: 0x2568E31 VA: 0x2568D30
	|-SharedVariable<float>.get_Value
	|
	|-RVA: 0x256A1B0 Offset: 0x256A2B1 VA: 0x256A1B0
	|-SharedVariable<Color>.get_Value
	|
	|-RVA: 0x256B730 Offset: 0x256B831 VA: 0x256B730
	|-SharedVariable<Quaternion>.get_Value
	|
	|-RVA: 0x256C1D0 Offset: 0x256C2D1 VA: 0x256C1D0
	|-SharedVariable<Rect>.get_Value
	|
	|-RVA: 0x256CC70 Offset: 0x256CD71 VA: 0x256CC70
	|-SharedVariable<Vector2>.get_Value
	|
	|-RVA: 0x256E110 Offset: 0x256E211 VA: 0x256E110
	|-SharedVariable<Vector3>.get_Value
	|
	|-RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	|-SharedVariable<Vector4>.get_Value
	|
	|-RVA: 0x2569770 Offset: 0x2569871 VA: 0x2569770
	|-SharedVariable<uint>.get_Value
	|
	|-RVA: 0x256AC50 Offset: 0x256AD51 VA: 0x256AC50
	|-SharedVariable<LayerMask>.get_Value
	|
	|-RVA: 0x256D6D0 Offset: 0x256D7D1 VA: 0x256D6D0
	|-SharedVariable<Vector2Int>.get_Value
	|
	|-RVA: 0x256EBB0 Offset: 0x256ECB1 VA: 0x256EBB0
	|-SharedVariable<Vector3Int>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568360 Offset: 0x2568461 VA: 0x2568360
	|-SharedVariable<AIInput>.set_Value
	|-SharedVariable<EnemyBehaviorController>.set_Value
	|-SharedVariable<MonsterBehaviorController>.set_Value
	|-SharedVariable<PartnerNPCBehaviorController>.set_Value
	|-SharedVariable<List<CharacterBase>>.set_Value
	|-SharedVariable<List<GameObject>>.set_Value
	|-SharedVariable<List<Object>>.set_Value
	|-SharedVariable<List<Transform>>.set_Value
	|-SharedVariable<List<Vector3>>.set_Value
	|-SharedVariable<object>.set_Value
	|-SharedVariable<string>.set_Value
	|-SharedVariable<Behaviour>.set_Value
	|-SharedVariable<Collider>.set_Value
	|-SharedVariable<GameObject>.set_Value
	|-SharedVariable<Object>.set_Value
	|-SharedVariable<Transform>.set_Value
	|
	|-RVA: 0x25678B0 Offset: 0x25679B1 VA: 0x25678B0
	|-SharedVariable<AttackAttribute>.set_Value
	|-SharedVariable<EmotionType>.set_Value
	|-SharedVariable<FarmMonsterHutState>.set_Value
	|-SharedVariable<FarmMonsterState>.set_Value
	|-SharedVariable<FarmMonsterWorkState>.set_Value
	|-SharedVariable<ToolChargeLevel>.set_Value
	|-SharedVariable<EnemyBehaviorTreeState>.set_Value
	|-SharedVariable<MonsterActionBehaviorType>.set_Value
	|-SharedVariable<MonsterActionCategory>.set_Value
	|-SharedVariable<MovementBehaviorType>.set_Value
	|-SharedVariable<PartnerMovementOrderType>.set_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.set_Value
	|-SharedVariable<Int32Enum>.set_Value
	|
	|-RVA: 0x2566420 Offset: 0x2566521 VA: 0x2566420
	|-SharedVariable<bool>.set_Value
	|
	|-RVA: 0x2566E70 Offset: 0x2566F71 VA: 0x2566E70
	|-SharedVariable<int>.set_Value
	|
	|-RVA: 0x2568D60 Offset: 0x2568E61 VA: 0x2568D60
	|-SharedVariable<float>.set_Value
	|
	|-RVA: 0x25697A0 Offset: 0x25698A1 VA: 0x25697A0
	|-SharedVariable<uint>.set_Value
	|
	|-RVA: 0x256A1F0 Offset: 0x256A2F1 VA: 0x256A1F0
	|-SharedVariable<Color>.set_Value
	|
	|-RVA: 0x256AC90 Offset: 0x256AD91 VA: 0x256AC90
	|-SharedVariable<LayerMask>.set_Value
	|
	|-RVA: 0x256B770 Offset: 0x256B871 VA: 0x256B770
	|-SharedVariable<Quaternion>.set_Value
	|
	|-RVA: 0x256C210 Offset: 0x256C311 VA: 0x256C210
	|-SharedVariable<Rect>.set_Value
	|
	|-RVA: 0x256CCB0 Offset: 0x256CDB1 VA: 0x256CCB0
	|-SharedVariable<Vector2>.set_Value
	|
	|-RVA: 0x256D700 Offset: 0x256D801 VA: 0x256D700
	|-SharedVariable<Vector2Int>.set_Value
	|
	|-RVA: 0x256E150 Offset: 0x256E251 VA: 0x256E150
	|-SharedVariable<Vector3>.set_Value
	|
	|-RVA: 0x256EC00 Offset: 0x256ED01 VA: 0x256EC00
	|-SharedVariable<Vector3Int>.set_Value
	|
	|-RVA: 0x256F690 Offset: 0x256F791 VA: 0x256F690
	|-SharedVariable<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25679C0 Offset: 0x2567AC1 VA: 0x25679C0
	|-SharedVariable<AIInput.Action>.GetValue
	|-SharedVariable<Alliance>.GetValue
	|-SharedVariable<AttackAttribute>.GetValue
	|-SharedVariable<EmotionType>.GetValue
	|-SharedVariable<FarmMonsterHutState>.GetValue
	|-SharedVariable<FarmMonsterState>.GetValue
	|-SharedVariable<FarmMonsterWorkState>.GetValue
	|-SharedVariable<ToolChargeLevel>.GetValue
	|-SharedVariable<EnemyBehaviorTreeState>.GetValue
	|-SharedVariable<MonsterActionBehaviorType>.GetValue
	|-SharedVariable<MonsterActionCategory>.GetValue
	|-SharedVariable<MovementBehaviorType>.GetValue
	|-SharedVariable<PartnerMovementOrderType>.GetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.GetValue
	|-SharedVariable<Int32Enum>.GetValue
	|
	|-RVA: 0x2568420 Offset: 0x2568521 VA: 0x2568420
	|-SharedVariable<AIInput>.GetValue
	|-SharedVariable<GenericVariable>.GetValue
	|-SharedVariable<NamedVariable>.GetValue
	|-SharedVariable<EnemyBehaviorController>.GetValue
	|-SharedVariable<MonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerNPCBehaviorController>.GetValue
	|-SharedVariable<List<CharacterBase>>.GetValue
	|-SharedVariable<List<GameObject>>.GetValue
	|-SharedVariable<List<Object>>.GetValue
	|-SharedVariable<List<Transform>>.GetValue
	|-SharedVariable<List<Vector3>>.GetValue
	|-SharedVariable<object>.GetValue
	|-SharedVariable<string>.GetValue
	|-SharedVariable<AnimationCurve>.GetValue
	|-SharedVariable<Behaviour>.GetValue
	|-SharedVariable<Collider>.GetValue
	|-SharedVariable<GameObject>.GetValue
	|-SharedVariable<Material>.GetValue
	|-SharedVariable<Object>.GetValue
	|-SharedVariable<Transform>.GetValue
	|
	|-RVA: 0x2566500 Offset: 0x2566601 VA: 0x2566500
	|-SharedVariable<bool>.GetValue
	|
	|-RVA: 0x2566F40 Offset: 0x2567041 VA: 0x2566F40
	|-SharedVariable<int>.GetValue
	|
	|-RVA: 0x2568E30 Offset: 0x2568F31 VA: 0x2568E30
	|-SharedVariable<float>.GetValue
	|
	|-RVA: 0x2569870 Offset: 0x2569971 VA: 0x2569870
	|-SharedVariable<uint>.GetValue
	|
	|-RVA: 0x256A2F0 Offset: 0x256A3F1 VA: 0x256A2F0
	|-SharedVariable<Color>.GetValue
	|
	|-RVA: 0x256ADB0 Offset: 0x256AEB1 VA: 0x256ADB0
	|-SharedVariable<LayerMask>.GetValue
	|
	|-RVA: 0x256B870 Offset: 0x256B971 VA: 0x256B870
	|-SharedVariable<Quaternion>.GetValue
	|
	|-RVA: 0x256C310 Offset: 0x256C411 VA: 0x256C310
	|-SharedVariable<Rect>.GetValue
	|
	|-RVA: 0x256CD90 Offset: 0x256CE91 VA: 0x256CD90
	|-SharedVariable<Vector2>.GetValue
	|
	|-RVA: 0x256D7D0 Offset: 0x256D8D1 VA: 0x256D7D0
	|-SharedVariable<Vector2Int>.GetValue
	|
	|-RVA: 0x256E250 Offset: 0x256E351 VA: 0x256E250
	|-SharedVariable<Vector3>.GetValue
	|
	|-RVA: 0x256ECF0 Offset: 0x256EDF1 VA: 0x256ECF0
	|-SharedVariable<Vector3Int>.GetValue
	|
	|-RVA: 0x256F790 Offset: 0x256F891 VA: 0x256F790
	|-SharedVariable<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567A30 Offset: 0x2567B31 VA: 0x2567A30
	|-SharedVariable<AIInput.Action>.SetValue
	|-SharedVariable<Alliance>.SetValue
	|-SharedVariable<AttackAttribute>.SetValue
	|-SharedVariable<EmotionType>.SetValue
	|-SharedVariable<FarmMonsterHutState>.SetValue
	|-SharedVariable<FarmMonsterState>.SetValue
	|-SharedVariable<FarmMonsterWorkState>.SetValue
	|-SharedVariable<ToolChargeLevel>.SetValue
	|-SharedVariable<EnemyBehaviorTreeState>.SetValue
	|-SharedVariable<MonsterActionBehaviorType>.SetValue
	|-SharedVariable<MonsterActionCategory>.SetValue
	|-SharedVariable<MovementBehaviorType>.SetValue
	|-SharedVariable<PartnerMovementOrderType>.SetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.SetValue
	|-SharedVariable<Int32Enum>.SetValue
	|
	|-RVA: 0x2568450 Offset: 0x2568551 VA: 0x2568450
	|-SharedVariable<AIInput>.SetValue
	|-SharedVariable<GenericVariable>.SetValue
	|-SharedVariable<NamedVariable>.SetValue
	|-SharedVariable<EnemyBehaviorController>.SetValue
	|-SharedVariable<MonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerNPCBehaviorController>.SetValue
	|-SharedVariable<List<CharacterBase>>.SetValue
	|-SharedVariable<List<GameObject>>.SetValue
	|-SharedVariable<List<Object>>.SetValue
	|-SharedVariable<List<Transform>>.SetValue
	|-SharedVariable<List<Vector3>>.SetValue
	|-SharedVariable<object>.SetValue
	|-SharedVariable<string>.SetValue
	|-SharedVariable<AnimationCurve>.SetValue
	|-SharedVariable<Behaviour>.SetValue
	|-SharedVariable<Collider>.SetValue
	|-SharedVariable<GameObject>.SetValue
	|-SharedVariable<Material>.SetValue
	|-SharedVariable<Object>.SetValue
	|-SharedVariable<Transform>.SetValue
	|
	|-RVA: 0x2566570 Offset: 0x2566671 VA: 0x2566570
	|-SharedVariable<bool>.SetValue
	|
	|-RVA: 0x2566FB0 Offset: 0x25670B1 VA: 0x2566FB0
	|-SharedVariable<int>.SetValue
	|
	|-RVA: 0x2568EA0 Offset: 0x2568FA1 VA: 0x2568EA0
	|-SharedVariable<float>.SetValue
	|
	|-RVA: 0x25698E0 Offset: 0x25699E1 VA: 0x25698E0
	|-SharedVariable<uint>.SetValue
	|
	|-RVA: 0x256A360 Offset: 0x256A461 VA: 0x256A360
	|-SharedVariable<Color>.SetValue
	|
	|-RVA: 0x256AE20 Offset: 0x256AF21 VA: 0x256AE20
	|-SharedVariable<LayerMask>.SetValue
	|
	|-RVA: 0x256B8E0 Offset: 0x256B9E1 VA: 0x256B8E0
	|-SharedVariable<Quaternion>.SetValue
	|
	|-RVA: 0x256C380 Offset: 0x256C481 VA: 0x256C380
	|-SharedVariable<Rect>.SetValue
	|
	|-RVA: 0x256CE00 Offset: 0x256CF01 VA: 0x256CE00
	|-SharedVariable<Vector2>.SetValue
	|
	|-RVA: 0x256D840 Offset: 0x256D941 VA: 0x256D840
	|-SharedVariable<Vector2Int>.SetValue
	|
	|-RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	|-SharedVariable<Vector3>.SetValue
	|
	|-RVA: 0x256ED60 Offset: 0x256EE61 VA: 0x256ED60
	|-SharedVariable<Vector3Int>.SetValue
	|
	|-RVA: 0x256F800 Offset: 0x256F901 VA: 0x256F800
	|-SharedVariable<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568550 Offset: 0x2568651 VA: 0x2568550
	|-SharedVariable<AIInput>.ToString
	|-SharedVariable<GenericVariable>.ToString
	|-SharedVariable<NamedVariable>.ToString
	|-SharedVariable<EnemyBehaviorController>.ToString
	|-SharedVariable<MonsterBehaviorController>.ToString
	|-SharedVariable<PartnerNPCBehaviorController>.ToString
	|-SharedVariable<List<CharacterBase>>.ToString
	|-SharedVariable<List<GameObject>>.ToString
	|-SharedVariable<List<Object>>.ToString
	|-SharedVariable<List<Transform>>.ToString
	|-SharedVariable<List<Vector3>>.ToString
	|-SharedVariable<object>.ToString
	|-SharedVariable<string>.ToString
	|-SharedVariable<AnimationCurve>.ToString
	|-SharedVariable<Behaviour>.ToString
	|-SharedVariable<Collider>.ToString
	|-SharedVariable<GameObject>.ToString
	|-SharedVariable<Material>.ToString
	|-SharedVariable<Object>.ToString
	|-SharedVariable<Transform>.ToString
	|
	|-RVA: 0x2567B30 Offset: 0x2567C31 VA: 0x2567B30
	|-SharedVariable<EnemyBehaviorTreeState>.ToString
	|-SharedVariable<MonsterActionCategory>.ToString
	|-SharedVariable<MovementBehaviorType>.ToString
	|-SharedVariable<Int32Enum>.ToString
	|
	|-RVA: 0x2566670 Offset: 0x2566771 VA: 0x2566670
	|-SharedVariable<bool>.ToString
	|
	|-RVA: 0x25670B0 Offset: 0x25671B1 VA: 0x25670B0
	|-SharedVariable<int>.ToString
	|
	|-RVA: 0x2568FA0 Offset: 0x25690A1 VA: 0x2568FA0
	|-SharedVariable<float>.ToString
	|
	|-RVA: 0x25699E0 Offset: 0x2569AE1 VA: 0x25699E0
	|-SharedVariable<uint>.ToString
	|
	|-RVA: 0x256A470 Offset: 0x256A571 VA: 0x256A470
	|-SharedVariable<Color>.ToString
	|
	|-RVA: 0x256AF20 Offset: 0x256B021 VA: 0x256AF20
	|-SharedVariable<LayerMask>.ToString
	|
	|-RVA: 0x256B9F0 Offset: 0x256BAF1 VA: 0x256B9F0
	|-SharedVariable<Quaternion>.ToString
	|
	|-RVA: 0x256C490 Offset: 0x256C591 VA: 0x256C490
	|-SharedVariable<Rect>.ToString
	|
	|-RVA: 0x256CF00 Offset: 0x256D001 VA: 0x256CF00
	|-SharedVariable<Vector2>.ToString
	|
	|-RVA: 0x256D940 Offset: 0x256DA41 VA: 0x256D940
	|-SharedVariable<Vector2Int>.ToString
	|
	|-RVA: 0x256E3D0 Offset: 0x256E4D1 VA: 0x256E3D0
	|-SharedVariable<Vector3>.ToString
	|
	|-RVA: 0x256EE70 Offset: 0x256EF71 VA: 0x256EE70
	|-SharedVariable<Vector3Int>.ToString
	|
	|-RVA: 0x256F910 Offset: 0x256FA11 VA: 0x256F910
	|-SharedVariable<Vector4>.ToString
	*/
}

public abstract class SharedVariable<T> : SharedVariable // TypeDefIndex: 4711
{
	// Fields
	private Func<T> mGetter; // 0x0
	private Action<T> mSetter; // 0x0
	[SerializeField] // RVA: 0x12D830 Offset: 0x12D931 VA: 0x12D830
	protected T mValue; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567150 Offset: 0x2567251 VA: 0x2567150
	|-SharedVariable<AIInput.Action>..ctor
	|-SharedVariable<Alliance>..ctor
	|-SharedVariable<AttackAttribute>..ctor
	|-SharedVariable<EmotionType>..ctor
	|-SharedVariable<FarmMonsterHutState>..ctor
	|-SharedVariable<FarmMonsterState>..ctor
	|-SharedVariable<FarmMonsterWorkState>..ctor
	|-SharedVariable<ToolChargeLevel>..ctor
	|-SharedVariable<EnemyBehaviorTreeState>..ctor
	|-SharedVariable<MonsterActionBehaviorType>..ctor
	|-SharedVariable<MonsterActionCategory>..ctor
	|-SharedVariable<MovementBehaviorType>..ctor
	|-SharedVariable<PartnerMovementOrderType>..ctor
	|-SharedVariable<PartnerNPCActionBehaviorType>..ctor
	|-SharedVariable<Int32Enum>..ctor
	|
	|-RVA: 0x2567C00 Offset: 0x2567D01 VA: 0x2567C00
	|-SharedVariable<AIInput>..ctor
	|-SharedVariable<GenericVariable>..ctor
	|-SharedVariable<NamedVariable>..ctor
	|-SharedVariable<EnemyBehaviorController>..ctor
	|-SharedVariable<MonsterBehaviorController>..ctor
	|-SharedVariable<PartnerMonsterBehaviorController>..ctor
	|-SharedVariable<PartnerNPCBehaviorController>..ctor
	|-SharedVariable<List<CharacterBase>>..ctor
	|-SharedVariable<List<GameObject>>..ctor
	|-SharedVariable<List<Object>>..ctor
	|-SharedVariable<List<Transform>>..ctor
	|-SharedVariable<List<Vector3>>..ctor
	|-SharedVariable<object>..ctor
	|-SharedVariable<string>..ctor
	|-SharedVariable<AnimationCurve>..ctor
	|-SharedVariable<Behaviour>..ctor
	|-SharedVariable<Collider>..ctor
	|-SharedVariable<GameObject>..ctor
	|-SharedVariable<Material>..ctor
	|-SharedVariable<Object>..ctor
	|-SharedVariable<Transform>..ctor
	|
	|-RVA: 0x2565CC0 Offset: 0x2565DC1 VA: 0x2565CC0
	|-SharedVariable<bool>..ctor
	|
	|-RVA: 0x2566710 Offset: 0x2566811 VA: 0x2566710
	|-SharedVariable<int>..ctor
	|
	|-RVA: 0x2568600 Offset: 0x2568701 VA: 0x2568600
	|-SharedVariable<float>..ctor
	|
	|-RVA: 0x2569040 Offset: 0x2569141 VA: 0x2569040
	|-SharedVariable<uint>..ctor
	|
	|-RVA: 0x2569A80 Offset: 0x2569B81 VA: 0x2569A80
	|-SharedVariable<Color>..ctor
	|
	|-RVA: 0x256A520 Offset: 0x256A621 VA: 0x256A520
	|-SharedVariable<LayerMask>..ctor
	|
	|-RVA: 0x256B000 Offset: 0x256B101 VA: 0x256B000
	|-SharedVariable<Quaternion>..ctor
	|
	|-RVA: 0x256BAA0 Offset: 0x256BBA1 VA: 0x256BAA0
	|-SharedVariable<Rect>..ctor
	|
	|-RVA: 0x256C540 Offset: 0x256C641 VA: 0x256C540
	|-SharedVariable<Vector2>..ctor
	|
	|-RVA: 0x256CFA0 Offset: 0x256D0A1 VA: 0x256CFA0
	|-SharedVariable<Vector2Int>..ctor
	|
	|-RVA: 0x256D9E0 Offset: 0x256DAE1 VA: 0x256D9E0
	|-SharedVariable<Vector3>..ctor
	|
	|-RVA: 0x256E480 Offset: 0x256E581 VA: 0x256E480
	|-SharedVariable<Vector3Int>..ctor
	|
	|-RVA: 0x256EF20 Offset: 0x256F021 VA: 0x256EF20
	|-SharedVariable<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void InitializePropertyMapping(BehaviorSource behaviorSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567170 Offset: 0x2567271 VA: 0x2567170
	|-SharedVariable<AIInput.Action>.InitializePropertyMapping
	|-SharedVariable<Alliance>.InitializePropertyMapping
	|-SharedVariable<AttackAttribute>.InitializePropertyMapping
	|-SharedVariable<EmotionType>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterHutState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterState>.InitializePropertyMapping
	|-SharedVariable<FarmMonsterWorkState>.InitializePropertyMapping
	|-SharedVariable<ToolChargeLevel>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorTreeState>.InitializePropertyMapping
	|-SharedVariable<MonsterActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<MonsterActionCategory>.InitializePropertyMapping
	|-SharedVariable<MovementBehaviorType>.InitializePropertyMapping
	|-SharedVariable<PartnerMovementOrderType>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCActionBehaviorType>.InitializePropertyMapping
	|-SharedVariable<Int32Enum>.InitializePropertyMapping
	|
	|-RVA: 0x2567C20 Offset: 0x2567D21 VA: 0x2567C20
	|-SharedVariable<AIInput>.InitializePropertyMapping
	|-SharedVariable<GenericVariable>.InitializePropertyMapping
	|-SharedVariable<NamedVariable>.InitializePropertyMapping
	|-SharedVariable<EnemyBehaviorController>.InitializePropertyMapping
	|-SharedVariable<MonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerMonsterBehaviorController>.InitializePropertyMapping
	|-SharedVariable<PartnerNPCBehaviorController>.InitializePropertyMapping
	|-SharedVariable<List<CharacterBase>>.InitializePropertyMapping
	|-SharedVariable<List<GameObject>>.InitializePropertyMapping
	|-SharedVariable<List<Object>>.InitializePropertyMapping
	|-SharedVariable<List<Transform>>.InitializePropertyMapping
	|-SharedVariable<List<Vector3>>.InitializePropertyMapping
	|-SharedVariable<object>.InitializePropertyMapping
	|-SharedVariable<string>.InitializePropertyMapping
	|-SharedVariable<AnimationCurve>.InitializePropertyMapping
	|-SharedVariable<Behaviour>.InitializePropertyMapping
	|-SharedVariable<Collider>.InitializePropertyMapping
	|-SharedVariable<GameObject>.InitializePropertyMapping
	|-SharedVariable<Material>.InitializePropertyMapping
	|-SharedVariable<Object>.InitializePropertyMapping
	|-SharedVariable<Transform>.InitializePropertyMapping
	|
	|-RVA: 0x2565CE0 Offset: 0x2565DE1 VA: 0x2565CE0
	|-SharedVariable<bool>.InitializePropertyMapping
	|
	|-RVA: 0x2566730 Offset: 0x2566831 VA: 0x2566730
	|-SharedVariable<int>.InitializePropertyMapping
	|
	|-RVA: 0x2568620 Offset: 0x2568721 VA: 0x2568620
	|-SharedVariable<float>.InitializePropertyMapping
	|
	|-RVA: 0x2569060 Offset: 0x2569161 VA: 0x2569060
	|-SharedVariable<uint>.InitializePropertyMapping
	|
	|-RVA: 0x2569AA0 Offset: 0x2569BA1 VA: 0x2569AA0
	|-SharedVariable<Color>.InitializePropertyMapping
	|
	|-RVA: 0x256A540 Offset: 0x256A641 VA: 0x256A540
	|-SharedVariable<LayerMask>.InitializePropertyMapping
	|
	|-RVA: 0x256B020 Offset: 0x256B121 VA: 0x256B020
	|-SharedVariable<Quaternion>.InitializePropertyMapping
	|
	|-RVA: 0x256BAC0 Offset: 0x256BBC1 VA: 0x256BAC0
	|-SharedVariable<Rect>.InitializePropertyMapping
	|
	|-RVA: 0x256C560 Offset: 0x256C661 VA: 0x256C560
	|-SharedVariable<Vector2>.InitializePropertyMapping
	|
	|-RVA: 0x256CFC0 Offset: 0x256D0C1 VA: 0x256CFC0
	|-SharedVariable<Vector2Int>.InitializePropertyMapping
	|
	|-RVA: 0x256DA00 Offset: 0x256DB01 VA: 0x256DA00
	|-SharedVariable<Vector3>.InitializePropertyMapping
	|
	|-RVA: 0x256E4A0 Offset: 0x256E5A1 VA: 0x256E4A0
	|-SharedVariable<Vector3Int>.InitializePropertyMapping
	|
	|-RVA: 0x256EF40 Offset: 0x256F041 VA: 0x256EF40
	|-SharedVariable<Vector4>.InitializePropertyMapping
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568330 Offset: 0x2568431 VA: 0x2568330
	|-SharedVariable<AIInput>.get_Value
	|-SharedVariable<EnemyBehaviorController>.get_Value
	|-SharedVariable<MonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerMonsterBehaviorController>.get_Value
	|-SharedVariable<PartnerNPCBehaviorController>.get_Value
	|-SharedVariable<List<GameObject>>.get_Value
	|-SharedVariable<List<Object>>.get_Value
	|-SharedVariable<List<Transform>>.get_Value
	|-SharedVariable<List<Vector3>>.get_Value
	|-SharedVariable<string>.get_Value
	|-SharedVariable<Behaviour>.get_Value
	|-SharedVariable<Collider>.get_Value
	|-SharedVariable<GameObject>.get_Value
	|-SharedVariable<Material>.get_Value
	|-SharedVariable<Object>.get_Value
	|-SharedVariable<Transform>.get_Value
	|-SharedVariable<GenericVariable>.get_Value
	|-SharedVariable<NamedVariable>.get_Value
	|-SharedVariable<object>.get_Value
	|
	|-RVA: 0x2567880 Offset: 0x2567981 VA: 0x2567880
	|-SharedVariable<AttackAttribute>.get_Value
	|-SharedVariable<EmotionType>.get_Value
	|-SharedVariable<FarmMonsterHutState>.get_Value
	|-SharedVariable<FarmMonsterState>.get_Value
	|-SharedVariable<FarmMonsterWorkState>.get_Value
	|-SharedVariable<ToolChargeLevel>.get_Value
	|-SharedVariable<EnemyBehaviorTreeState>.get_Value
	|-SharedVariable<MonsterActionBehaviorType>.get_Value
	|-SharedVariable<MonsterActionCategory>.get_Value
	|-SharedVariable<MovementBehaviorType>.get_Value
	|-SharedVariable<PartnerMovementOrderType>.get_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.get_Value
	|-SharedVariable<Int32Enum>.get_Value
	|
	|-RVA: 0x25663F0 Offset: 0x25664F1 VA: 0x25663F0
	|-SharedVariable<bool>.get_Value
	|
	|-RVA: 0x2566E40 Offset: 0x2566F41 VA: 0x2566E40
	|-SharedVariable<int>.get_Value
	|
	|-RVA: 0x2568D30 Offset: 0x2568E31 VA: 0x2568D30
	|-SharedVariable<float>.get_Value
	|
	|-RVA: 0x256A1B0 Offset: 0x256A2B1 VA: 0x256A1B0
	|-SharedVariable<Color>.get_Value
	|
	|-RVA: 0x256B730 Offset: 0x256B831 VA: 0x256B730
	|-SharedVariable<Quaternion>.get_Value
	|
	|-RVA: 0x256C1D0 Offset: 0x256C2D1 VA: 0x256C1D0
	|-SharedVariable<Rect>.get_Value
	|
	|-RVA: 0x256CC70 Offset: 0x256CD71 VA: 0x256CC70
	|-SharedVariable<Vector2>.get_Value
	|
	|-RVA: 0x256E110 Offset: 0x256E211 VA: 0x256E110
	|-SharedVariable<Vector3>.get_Value
	|
	|-RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	|-SharedVariable<Vector4>.get_Value
	|
	|-RVA: 0x2569770 Offset: 0x2569871 VA: 0x2569770
	|-SharedVariable<uint>.get_Value
	|
	|-RVA: 0x256AC50 Offset: 0x256AD51 VA: 0x256AC50
	|-SharedVariable<LayerMask>.get_Value
	|
	|-RVA: 0x256D6D0 Offset: 0x256D7D1 VA: 0x256D6D0
	|-SharedVariable<Vector2Int>.get_Value
	|
	|-RVA: 0x256EBB0 Offset: 0x256ECB1 VA: 0x256EBB0
	|-SharedVariable<Vector3Int>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568360 Offset: 0x2568461 VA: 0x2568360
	|-SharedVariable<AIInput>.set_Value
	|-SharedVariable<EnemyBehaviorController>.set_Value
	|-SharedVariable<MonsterBehaviorController>.set_Value
	|-SharedVariable<PartnerNPCBehaviorController>.set_Value
	|-SharedVariable<List<CharacterBase>>.set_Value
	|-SharedVariable<List<GameObject>>.set_Value
	|-SharedVariable<List<Object>>.set_Value
	|-SharedVariable<List<Transform>>.set_Value
	|-SharedVariable<List<Vector3>>.set_Value
	|-SharedVariable<object>.set_Value
	|-SharedVariable<string>.set_Value
	|-SharedVariable<Behaviour>.set_Value
	|-SharedVariable<Collider>.set_Value
	|-SharedVariable<GameObject>.set_Value
	|-SharedVariable<Object>.set_Value
	|-SharedVariable<Transform>.set_Value
	|
	|-RVA: 0x25678B0 Offset: 0x25679B1 VA: 0x25678B0
	|-SharedVariable<AttackAttribute>.set_Value
	|-SharedVariable<EmotionType>.set_Value
	|-SharedVariable<FarmMonsterHutState>.set_Value
	|-SharedVariable<FarmMonsterState>.set_Value
	|-SharedVariable<FarmMonsterWorkState>.set_Value
	|-SharedVariable<ToolChargeLevel>.set_Value
	|-SharedVariable<EnemyBehaviorTreeState>.set_Value
	|-SharedVariable<MonsterActionBehaviorType>.set_Value
	|-SharedVariable<MonsterActionCategory>.set_Value
	|-SharedVariable<MovementBehaviorType>.set_Value
	|-SharedVariable<PartnerMovementOrderType>.set_Value
	|-SharedVariable<PartnerNPCActionBehaviorType>.set_Value
	|-SharedVariable<Int32Enum>.set_Value
	|
	|-RVA: 0x2566420 Offset: 0x2566521 VA: 0x2566420
	|-SharedVariable<bool>.set_Value
	|
	|-RVA: 0x2566E70 Offset: 0x2566F71 VA: 0x2566E70
	|-SharedVariable<int>.set_Value
	|
	|-RVA: 0x2568D60 Offset: 0x2568E61 VA: 0x2568D60
	|-SharedVariable<float>.set_Value
	|
	|-RVA: 0x25697A0 Offset: 0x25698A1 VA: 0x25697A0
	|-SharedVariable<uint>.set_Value
	|
	|-RVA: 0x256A1F0 Offset: 0x256A2F1 VA: 0x256A1F0
	|-SharedVariable<Color>.set_Value
	|
	|-RVA: 0x256AC90 Offset: 0x256AD91 VA: 0x256AC90
	|-SharedVariable<LayerMask>.set_Value
	|
	|-RVA: 0x256B770 Offset: 0x256B871 VA: 0x256B770
	|-SharedVariable<Quaternion>.set_Value
	|
	|-RVA: 0x256C210 Offset: 0x256C311 VA: 0x256C210
	|-SharedVariable<Rect>.set_Value
	|
	|-RVA: 0x256CCB0 Offset: 0x256CDB1 VA: 0x256CCB0
	|-SharedVariable<Vector2>.set_Value
	|
	|-RVA: 0x256D700 Offset: 0x256D801 VA: 0x256D700
	|-SharedVariable<Vector2Int>.set_Value
	|
	|-RVA: 0x256E150 Offset: 0x256E251 VA: 0x256E150
	|-SharedVariable<Vector3>.set_Value
	|
	|-RVA: 0x256EC00 Offset: 0x256ED01 VA: 0x256EC00
	|-SharedVariable<Vector3Int>.set_Value
	|
	|-RVA: 0x256F690 Offset: 0x256F791 VA: 0x256F690
	|-SharedVariable<Vector4>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25679C0 Offset: 0x2567AC1 VA: 0x25679C0
	|-SharedVariable<AIInput.Action>.GetValue
	|-SharedVariable<Alliance>.GetValue
	|-SharedVariable<AttackAttribute>.GetValue
	|-SharedVariable<EmotionType>.GetValue
	|-SharedVariable<FarmMonsterHutState>.GetValue
	|-SharedVariable<FarmMonsterState>.GetValue
	|-SharedVariable<FarmMonsterWorkState>.GetValue
	|-SharedVariable<ToolChargeLevel>.GetValue
	|-SharedVariable<EnemyBehaviorTreeState>.GetValue
	|-SharedVariable<MonsterActionBehaviorType>.GetValue
	|-SharedVariable<MonsterActionCategory>.GetValue
	|-SharedVariable<MovementBehaviorType>.GetValue
	|-SharedVariable<PartnerMovementOrderType>.GetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.GetValue
	|-SharedVariable<Int32Enum>.GetValue
	|
	|-RVA: 0x2568420 Offset: 0x2568521 VA: 0x2568420
	|-SharedVariable<AIInput>.GetValue
	|-SharedVariable<GenericVariable>.GetValue
	|-SharedVariable<NamedVariable>.GetValue
	|-SharedVariable<EnemyBehaviorController>.GetValue
	|-SharedVariable<MonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.GetValue
	|-SharedVariable<PartnerNPCBehaviorController>.GetValue
	|-SharedVariable<List<CharacterBase>>.GetValue
	|-SharedVariable<List<GameObject>>.GetValue
	|-SharedVariable<List<Object>>.GetValue
	|-SharedVariable<List<Transform>>.GetValue
	|-SharedVariable<List<Vector3>>.GetValue
	|-SharedVariable<object>.GetValue
	|-SharedVariable<string>.GetValue
	|-SharedVariable<AnimationCurve>.GetValue
	|-SharedVariable<Behaviour>.GetValue
	|-SharedVariable<Collider>.GetValue
	|-SharedVariable<GameObject>.GetValue
	|-SharedVariable<Material>.GetValue
	|-SharedVariable<Object>.GetValue
	|-SharedVariable<Transform>.GetValue
	|
	|-RVA: 0x2566500 Offset: 0x2566601 VA: 0x2566500
	|-SharedVariable<bool>.GetValue
	|
	|-RVA: 0x2566F40 Offset: 0x2567041 VA: 0x2566F40
	|-SharedVariable<int>.GetValue
	|
	|-RVA: 0x2568E30 Offset: 0x2568F31 VA: 0x2568E30
	|-SharedVariable<float>.GetValue
	|
	|-RVA: 0x2569870 Offset: 0x2569971 VA: 0x2569870
	|-SharedVariable<uint>.GetValue
	|
	|-RVA: 0x256A2F0 Offset: 0x256A3F1 VA: 0x256A2F0
	|-SharedVariable<Color>.GetValue
	|
	|-RVA: 0x256ADB0 Offset: 0x256AEB1 VA: 0x256ADB0
	|-SharedVariable<LayerMask>.GetValue
	|
	|-RVA: 0x256B870 Offset: 0x256B971 VA: 0x256B870
	|-SharedVariable<Quaternion>.GetValue
	|
	|-RVA: 0x256C310 Offset: 0x256C411 VA: 0x256C310
	|-SharedVariable<Rect>.GetValue
	|
	|-RVA: 0x256CD90 Offset: 0x256CE91 VA: 0x256CD90
	|-SharedVariable<Vector2>.GetValue
	|
	|-RVA: 0x256D7D0 Offset: 0x256D8D1 VA: 0x256D7D0
	|-SharedVariable<Vector2Int>.GetValue
	|
	|-RVA: 0x256E250 Offset: 0x256E351 VA: 0x256E250
	|-SharedVariable<Vector3>.GetValue
	|
	|-RVA: 0x256ECF0 Offset: 0x256EDF1 VA: 0x256ECF0
	|-SharedVariable<Vector3Int>.GetValue
	|
	|-RVA: 0x256F790 Offset: 0x256F891 VA: 0x256F790
	|-SharedVariable<Vector4>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void SetValue(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2567A30 Offset: 0x2567B31 VA: 0x2567A30
	|-SharedVariable<AIInput.Action>.SetValue
	|-SharedVariable<Alliance>.SetValue
	|-SharedVariable<AttackAttribute>.SetValue
	|-SharedVariable<EmotionType>.SetValue
	|-SharedVariable<FarmMonsterHutState>.SetValue
	|-SharedVariable<FarmMonsterState>.SetValue
	|-SharedVariable<FarmMonsterWorkState>.SetValue
	|-SharedVariable<ToolChargeLevel>.SetValue
	|-SharedVariable<EnemyBehaviorTreeState>.SetValue
	|-SharedVariable<MonsterActionBehaviorType>.SetValue
	|-SharedVariable<MonsterActionCategory>.SetValue
	|-SharedVariable<MovementBehaviorType>.SetValue
	|-SharedVariable<PartnerMovementOrderType>.SetValue
	|-SharedVariable<PartnerNPCActionBehaviorType>.SetValue
	|-SharedVariable<Int32Enum>.SetValue
	|
	|-RVA: 0x2568450 Offset: 0x2568551 VA: 0x2568450
	|-SharedVariable<AIInput>.SetValue
	|-SharedVariable<GenericVariable>.SetValue
	|-SharedVariable<NamedVariable>.SetValue
	|-SharedVariable<EnemyBehaviorController>.SetValue
	|-SharedVariable<MonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerMonsterBehaviorController>.SetValue
	|-SharedVariable<PartnerNPCBehaviorController>.SetValue
	|-SharedVariable<List<CharacterBase>>.SetValue
	|-SharedVariable<List<GameObject>>.SetValue
	|-SharedVariable<List<Object>>.SetValue
	|-SharedVariable<List<Transform>>.SetValue
	|-SharedVariable<List<Vector3>>.SetValue
	|-SharedVariable<object>.SetValue
	|-SharedVariable<string>.SetValue
	|-SharedVariable<AnimationCurve>.SetValue
	|-SharedVariable<Behaviour>.SetValue
	|-SharedVariable<Collider>.SetValue
	|-SharedVariable<GameObject>.SetValue
	|-SharedVariable<Material>.SetValue
	|-SharedVariable<Object>.SetValue
	|-SharedVariable<Transform>.SetValue
	|
	|-RVA: 0x2566570 Offset: 0x2566671 VA: 0x2566570
	|-SharedVariable<bool>.SetValue
	|
	|-RVA: 0x2566FB0 Offset: 0x25670B1 VA: 0x2566FB0
	|-SharedVariable<int>.SetValue
	|
	|-RVA: 0x2568EA0 Offset: 0x2568FA1 VA: 0x2568EA0
	|-SharedVariable<float>.SetValue
	|
	|-RVA: 0x25698E0 Offset: 0x25699E1 VA: 0x25698E0
	|-SharedVariable<uint>.SetValue
	|
	|-RVA: 0x256A360 Offset: 0x256A461 VA: 0x256A360
	|-SharedVariable<Color>.SetValue
	|
	|-RVA: 0x256AE20 Offset: 0x256AF21 VA: 0x256AE20
	|-SharedVariable<LayerMask>.SetValue
	|
	|-RVA: 0x256B8E0 Offset: 0x256B9E1 VA: 0x256B8E0
	|-SharedVariable<Quaternion>.SetValue
	|
	|-RVA: 0x256C380 Offset: 0x256C481 VA: 0x256C380
	|-SharedVariable<Rect>.SetValue
	|
	|-RVA: 0x256CE00 Offset: 0x256CF01 VA: 0x256CE00
	|-SharedVariable<Vector2>.SetValue
	|
	|-RVA: 0x256D840 Offset: 0x256D941 VA: 0x256D840
	|-SharedVariable<Vector2Int>.SetValue
	|
	|-RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	|-SharedVariable<Vector3>.SetValue
	|
	|-RVA: 0x256ED60 Offset: 0x256EE61 VA: 0x256ED60
	|-SharedVariable<Vector3Int>.SetValue
	|
	|-RVA: 0x256F800 Offset: 0x256F901 VA: 0x256F800
	|-SharedVariable<Vector4>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2568550 Offset: 0x2568651 VA: 0x2568550
	|-SharedVariable<AIInput>.ToString
	|-SharedVariable<GenericVariable>.ToString
	|-SharedVariable<NamedVariable>.ToString
	|-SharedVariable<EnemyBehaviorController>.ToString
	|-SharedVariable<MonsterBehaviorController>.ToString
	|-SharedVariable<PartnerNPCBehaviorController>.ToString
	|-SharedVariable<List<CharacterBase>>.ToString
	|-SharedVariable<List<GameObject>>.ToString
	|-SharedVariable<List<Object>>.ToString
	|-SharedVariable<List<Transform>>.ToString
	|-SharedVariable<List<Vector3>>.ToString
	|-SharedVariable<object>.ToString
	|-SharedVariable<string>.ToString
	|-SharedVariable<AnimationCurve>.ToString
	|-SharedVariable<Behaviour>.ToString
	|-SharedVariable<Collider>.ToString
	|-SharedVariable<GameObject>.ToString
	|-SharedVariable<Material>.ToString
	|-SharedVariable<Object>.ToString
	|-SharedVariable<Transform>.ToString
	|
	|-RVA: 0x2567B30 Offset: 0x2567C31 VA: 0x2567B30
	|-SharedVariable<EnemyBehaviorTreeState>.ToString
	|-SharedVariable<MonsterActionCategory>.ToString
	|-SharedVariable<MovementBehaviorType>.ToString
	|-SharedVariable<Int32Enum>.ToString
	|
	|-RVA: 0x2566670 Offset: 0x2566771 VA: 0x2566670
	|-SharedVariable<bool>.ToString
	|
	|-RVA: 0x25670B0 Offset: 0x25671B1 VA: 0x25670B0
	|-SharedVariable<int>.ToString
	|
	|-RVA: 0x2568FA0 Offset: 0x25690A1 VA: 0x2568FA0
	|-SharedVariable<float>.ToString
	|
	|-RVA: 0x25699E0 Offset: 0x2569AE1 VA: 0x25699E0
	|-SharedVariable<uint>.ToString
	|
	|-RVA: 0x256A470 Offset: 0x256A571 VA: 0x256A470
	|-SharedVariable<Color>.ToString
	|
	|-RVA: 0x256AF20 Offset: 0x256B021 VA: 0x256AF20
	|-SharedVariable<LayerMask>.ToString
	|
	|-RVA: 0x256B9F0 Offset: 0x256BAF1 VA: 0x256B9F0
	|-SharedVariable<Quaternion>.ToString
	|
	|-RVA: 0x256C490 Offset: 0x256C591 VA: 0x256C490
	|-SharedVariable<Rect>.ToString
	|
	|-RVA: 0x256CF00 Offset: 0x256D001 VA: 0x256CF00
	|-SharedVariable<Vector2>.ToString
	|
	|-RVA: 0x256D940 Offset: 0x256DA41 VA: 0x256D940
	|-SharedVariable<Vector2Int>.ToString
	|
	|-RVA: 0x256E3D0 Offset: 0x256E4D1 VA: 0x256E3D0
	|-SharedVariable<Vector3>.ToString
	|
	|-RVA: 0x256EE70 Offset: 0x256EF71 VA: 0x256EE70
	|-SharedVariable<Vector3Int>.ToString
	|
	|-RVA: 0x256F910 Offset: 0x256FA11 VA: 0x256F910
	|-SharedVariable<Vector4>.ToString
	*/
}

