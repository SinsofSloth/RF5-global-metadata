[DefaultMemberAttribute] // RVA: 0x145EF0 Offset: 0x145FF1 VA: 0x145EF0
public class Register<T1, T2> // TypeDefIndex: 6726
{
	// Fields
	private Dictionary<T1, T2> m_registed; // 0x0

	// Properties
	public T2 Item { get; }
	public Dictionary.KeyCollection<T1, T2> Keys { get; }
	public Dictionary.ValueCollection<T1, T2> Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool Regist(T1 key, T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2E50 Offset: 0x2CA2F51 VA: 0x2CA2E50
	|-Register<ActorController, ActorVoiceController>.Regist
	|-Register<Character, ActionSpeedController>.Regist
	|-Register<Character, AvoidController>.Regist
	|-Register<Character, BattleModeController>.Regist
	|-Register<Character, BitController>.Regist
	|-Register<Character, FootSteps>.Regist
	|-Register<Character, GrantAttributeController>.Regist
	|-Register<Character, LazyController>.Regist
	|-Register<Character, RestraintController>.Regist
	|-Register<Character, SuperArmorController>.Regist
	|-Register<Character, SpringManager>.Regist
	|-Register<Character, YawnController>.Regist
	|-Register<CharacterBase, EmotionController>.Regist
	|-Register<CharacterBase, EscapeController>.Regist
	|-Register<CharacterBase, FishingStateController>.Regist
	|-Register<CharacterBase, MagicController>.Regist
	|-Register<CharacterBase, PersonalMotionController>.Regist
	|-Register<CharacterBase, SlowStateController>.Regist
	|-Register<CharacterBase, SoulController>.Regist
	|-Register<CharacterBase, ThrottleController>.Regist
	|-Register<object, object>.Regist
	|
	|-RVA: 0x2CA2BD0 Offset: 0x2CA2CD1 VA: 0x2CA2BD0
	|-Register<ActorID, GrappleController>.Regist
	|-Register<ActorID, HandCuffsController>.Regist
	|-Register<ActorID, MobTravelerController>.Regist
	|-Register<Int32Enum, object>.Regist
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2EE0 Offset: 0x2CA2FE1 VA: 0x2CA2EE0
	|-Register<ActorController, ActorVoiceController>.Remove
	|-Register<Character, ActionSpeedController>.Remove
	|-Register<Character, AvoidController>.Remove
	|-Register<Character, BattleModeController>.Remove
	|-Register<Character, BitController>.Remove
	|-Register<Character, FootSteps>.Remove
	|-Register<Character, GrantAttributeController>.Remove
	|-Register<Character, LazyController>.Remove
	|-Register<Character, RestraintController>.Remove
	|-Register<Character, SuperArmorController>.Remove
	|-Register<Character, SpringManager>.Remove
	|-Register<Character, YawnController>.Remove
	|-Register<CharacterBase, EmotionController>.Remove
	|-Register<CharacterBase, EscapeController>.Remove
	|-Register<CharacterBase, FishingStateController>.Remove
	|-Register<CharacterBase, MagicController>.Remove
	|-Register<CharacterBase, PersonalMotionController>.Remove
	|-Register<CharacterBase, SlowStateController>.Remove
	|-Register<CharacterBase, SoulController>.Remove
	|-Register<CharacterBase, ThrottleController>.Remove
	|-Register<object, object>.Remove
	|
	|-RVA: 0x2CA2C60 Offset: 0x2CA2D61 VA: 0x2CA2C60
	|-Register<ActorID, GrappleController>.Remove
	|-Register<ActorID, HandCuffsController>.Remove
	|-Register<ActorID, MobTravelerController>.Remove
	|-Register<Int32Enum, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Get(T1 key, out T2 value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2CF0 Offset: 0x2CA2DF1 VA: 0x2CA2CF0
	|-Register<ActorID, GrappleController>.Get
	|-Register<Int32Enum, object>.Get
	|
	|-RVA: 0x2CA2F70 Offset: 0x2CA3071 VA: 0x2CA2F70
	|-Register<object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item(T1 key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2FA0 Offset: 0x2CA30A1 VA: 0x2CA2FA0
	|-Register<ActorController, ActorVoiceController>.get_Item
	|-Register<Character, ActionSpeedController>.get_Item
	|-Register<Character, AvoidController>.get_Item
	|-Register<Character, BattleModeController>.get_Item
	|-Register<Character, BitController>.get_Item
	|-Register<Character, FootSteps>.get_Item
	|-Register<Character, GrantAttributeController>.get_Item
	|-Register<Character, LazyController>.get_Item
	|-Register<Character, RestraintController>.get_Item
	|-Register<Character, SuperArmorController>.get_Item
	|-Register<Character, SpringManager>.get_Item
	|-Register<Character, YawnController>.get_Item
	|-Register<CharacterBase, EmotionController>.get_Item
	|-Register<CharacterBase, EscapeController>.get_Item
	|-Register<CharacterBase, FishingStateController>.get_Item
	|-Register<CharacterBase, MagicController>.get_Item
	|-Register<CharacterBase, PersonalMotionController>.get_Item
	|-Register<CharacterBase, SlowStateController>.get_Item
	|-Register<CharacterBase, SoulController>.get_Item
	|-Register<CharacterBase, ThrottleController>.get_Item
	|-Register<object, object>.get_Item
	|
	|-RVA: 0x2CA2D20 Offset: 0x2CA2E21 VA: 0x2CA2D20
	|-Register<ActorID, HandCuffsController>.get_Item
	|-Register<ActorID, MobTravelerController>.get_Item
	|-Register<Int32Enum, object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<T1, T2> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA2FE0 Offset: 0x2CA30E1 VA: 0x2CA2FE0
	|-Register<Character, AvoidController>.get_Keys
	|-Register<Character, YawnController>.get_Keys
	|-Register<CharacterBase, MagicController>.get_Keys
	|-Register<CharacterBase, ThrottleController>.get_Keys
	|-Register<object, object>.get_Keys
	|
	|-RVA: 0x2CA2D60 Offset: 0x2CA2E61 VA: 0x2CA2D60
	|-Register<ActorID, GrappleController>.get_Keys
	|-Register<ActorID, HandCuffsController>.get_Keys
	|-Register<ActorID, MobTravelerController>.get_Keys
	|-Register<Int32Enum, object>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<T1, T2> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3010 Offset: 0x2CA3111 VA: 0x2CA3010
	|-Register<Character, ActionSpeedController>.get_Values
	|-Register<Character, AvoidController>.get_Values
	|-Register<Character, BitController>.get_Values
	|-Register<Character, GrantAttributeController>.get_Values
	|-Register<Character, LazyController>.get_Values
	|-Register<Character, RestraintController>.get_Values
	|-Register<Character, SuperArmorController>.get_Values
	|-Register<Character, SpringManager>.get_Values
	|-Register<Character, YawnController>.get_Values
	|-Register<CharacterBase, EmotionController>.get_Values
	|-Register<CharacterBase, EscapeController>.get_Values
	|-Register<CharacterBase, MagicController>.get_Values
	|-Register<CharacterBase, SlowStateController>.get_Values
	|-Register<CharacterBase, SoulController>.get_Values
	|-Register<CharacterBase, ThrottleController>.get_Values
	|-Register<object, object>.get_Values
	|
	|-RVA: 0x2CA2D90 Offset: 0x2CA2E91 VA: 0x2CA2D90
	|-Register<ActorID, GrappleController>.get_Values
	|-Register<ActorID, HandCuffsController>.get_Values
	|-Register<ActorID, MobTravelerController>.get_Values
	|-Register<Int32Enum, object>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3040 Offset: 0x2CA3141 VA: 0x2CA3040
	|-Register<ActorController, ActorVoiceController>..ctor
	|-Register<Character, ActionSpeedController>..ctor
	|-Register<Character, AvoidController>..ctor
	|-Register<Character, BattleModeController>..ctor
	|-Register<Character, BitController>..ctor
	|-Register<Character, FootSteps>..ctor
	|-Register<Character, GrantAttributeController>..ctor
	|-Register<Character, LazyController>..ctor
	|-Register<Character, RestraintController>..ctor
	|-Register<Character, SuperArmorController>..ctor
	|-Register<Character, SpringManager>..ctor
	|-Register<Character, YawnController>..ctor
	|-Register<CharacterBase, EmotionController>..ctor
	|-Register<CharacterBase, EscapeController>..ctor
	|-Register<CharacterBase, FishingStateController>..ctor
	|-Register<CharacterBase, MagicController>..ctor
	|-Register<CharacterBase, PersonalMotionController>..ctor
	|-Register<CharacterBase, SlowStateController>..ctor
	|-Register<CharacterBase, SoulController>..ctor
	|-Register<CharacterBase, ThrottleController>..ctor
	|-Register<object, object>..ctor
	|
	|-RVA: 0x2CA2DC0 Offset: 0x2CA2EC1 VA: 0x2CA2DC0
	|-Register<ActorID, GrappleController>..ctor
	|-Register<ActorID, HandCuffsController>..ctor
	|-Register<ActorID, MobTravelerController>..ctor
	|-Register<Int32Enum, object>..ctor
	*/
}

