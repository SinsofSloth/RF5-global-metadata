[DebuggerTypeProxyAttribute] // RVA: 0xBC5A0 Offset: 0xBC6A1 VA: 0xBC5A0
[DebuggerDisplayAttribute] // RVA: 0xBC5A0 Offset: 0xBC6A1 VA: 0xBC5A0
[Serializable]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 2074
{
	// Fields
	internal LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const string VersionName = "Version";
	private const string CountName = "Count";
	private const string ValuesName = "Data";

	// Properties
	public int Count { get; }
	public LinkedListNode<T> First { get; }
	public LinkedListNode<T> Last { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4170 Offset: 0x25E4271 VA: 0x25E4170
	|-LinkedList<FieldOnGroundItemInfo>..ctor
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>..ctor
	|-LinkedList<BGMController>..ctor
	|-LinkedList<SEController>..ctor
	|-LinkedList<VoiceController>..ctor
	|-LinkedList<Action>..ctor
	|-LinkedList<WebConnectionGroup.ConnectionState>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<CachedCodeEntry>..ctor
	|-LinkedList<WeakReference>..ctor
	|
	|-RVA: 0x25E1410 Offset: 0x25E1511 VA: 0x25E1410
	|-LinkedList<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x25E2AB0 Offset: 0x25E2BB1 VA: 0x25E2AB0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x25E57A0 Offset: 0x25E58A1 VA: 0x25E57A0
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1430 Offset: 0x25E1531 VA: 0x25E1430
	|-LinkedList<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x25E2AD0 Offset: 0x25E2BD1 VA: 0x25E2AD0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x25E4190 Offset: 0x25E4291 VA: 0x25E4190
	|-LinkedList<object>..ctor
	|
	|-RVA: 0x25E57C0 Offset: 0x25E58C1 VA: 0x25E57C0
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E41D0 Offset: 0x25E42D1 VA: 0x25E41D0
	|-LinkedList<FieldOnGroundItemInfo>.get_Count
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>.get_Count
	|-LinkedList<SEController>.get_Count
	|-LinkedList<WebConnectionGroup.ConnectionState>.get_Count
	|-LinkedList<object>.get_Count
	|-LinkedList<CachedCodeEntry>.get_Count
	|
	|-RVA: 0x25E1470 Offset: 0x25E1571 VA: 0x25E1470
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_Count
	|
	|-RVA: 0x25E2B10 Offset: 0x25E2C11 VA: 0x25E2B10
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.get_Count
	|
	|-RVA: 0x25E5800 Offset: 0x25E5901 VA: 0x25E5800
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Count
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E41E0 Offset: 0x25E42E1 VA: 0x25E41E0
	|-LinkedList<FieldOnGroundItemInfo>.get_First
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>.get_First
	|-LinkedList<SEController>.get_First
	|-LinkedList<Action>.get_First
	|-LinkedList<WebConnectionGroup.ConnectionState>.get_First
	|-LinkedList<object>.get_First
	|-LinkedList<CachedCodeEntry>.get_First
	|
	|-RVA: 0x25E1480 Offset: 0x25E1581 VA: 0x25E1480
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_First
	|
	|-RVA: 0x25E2B20 Offset: 0x25E2C21 VA: 0x25E2B20
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.get_First
	|
	|-RVA: 0x25E5810 Offset: 0x25E5911 VA: 0x25E5810
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_First
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E5820 Offset: 0x25E5921 VA: 0x25E5820
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Last
	|
	|-RVA: 0x25E1490 Offset: 0x25E1591 VA: 0x25E1490
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.get_Last
	|
	|-RVA: 0x25E2B30 Offset: 0x25E2C31 VA: 0x25E2B30
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.get_Last
	|
	|-RVA: 0x25E41F0 Offset: 0x25E42F1 VA: 0x25E41F0
	|-LinkedList<WebConnectionGroup.ConnectionState>.get_Last
	|-LinkedList<object>.get_Last
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E14B0 Offset: 0x25E15B1 VA: 0x25E14B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x25E2B50 Offset: 0x25E2C51 VA: 0x25E2B50
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x25E4210 Offset: 0x25E4311 VA: 0x25E4210
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x25E5840 Offset: 0x25E5941 VA: 0x25E5840
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E14C0 Offset: 0x25E15C1 VA: 0x25E14C0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x25E2B60 Offset: 0x25E2C61 VA: 0x25E2B60
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x25E4220 Offset: 0x25E4321 VA: 0x25E4220
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x25E5850 Offset: 0x25E5951 VA: 0x25E5850
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E14F0 Offset: 0x25E15F1 VA: 0x25E14F0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddBefore
	|
	|-RVA: 0x25E2B90 Offset: 0x25E2C91 VA: 0x25E2B90
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.AddBefore
	|
	|-RVA: 0x25E4250 Offset: 0x25E4351 VA: 0x25E4250
	|-LinkedList<object>.AddBefore
	|
	|-RVA: 0x25E58B0 Offset: 0x25E59B1 VA: 0x25E58B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddBefore
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddFirst(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E15C0 Offset: 0x25E16C1 VA: 0x25E15C0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddFirst
	|
	|-RVA: 0x25E2C60 Offset: 0x25E2D61 VA: 0x25E2C60
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.AddFirst
	|
	|-RVA: 0x25E4320 Offset: 0x25E4421 VA: 0x25E4320
	|-LinkedList<WebConnectionGroup.ConnectionState>.AddFirst
	|-LinkedList<object>.AddFirst
	|-LinkedList<CachedCodeEntry>.AddFirst
	|
	|-RVA: 0x25E5980 Offset: 0x25E5A81 VA: 0x25E5980
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public void AddFirst(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E16A0 Offset: 0x25E17A1 VA: 0x25E16A0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddFirst
	|
	|-RVA: 0x25E2D40 Offset: 0x25E2E41 VA: 0x25E2D40
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.AddFirst
	|
	|-RVA: 0x25E43F0 Offset: 0x25E44F1 VA: 0x25E43F0
	|-LinkedList<object>.AddFirst
	|-LinkedList<CachedCodeEntry>.AddFirst
	|
	|-RVA: 0x25E5A70 Offset: 0x25E5B71 VA: 0x25E5A70
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E44A0 Offset: 0x25E45A1 VA: 0x25E44A0
	|-LinkedList<FieldOnGroundItemInfo>.AddLast
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>.AddLast
	|-LinkedList<BGMController>.AddLast
	|-LinkedList<SEController>.AddLast
	|-LinkedList<VoiceController>.AddLast
	|-LinkedList<Action>.AddLast
	|-LinkedList<object>.AddLast
	|-LinkedList<WeakReference>.AddLast
	|
	|-RVA: 0x25E1750 Offset: 0x25E1851 VA: 0x25E1750
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddLast
	|
	|-RVA: 0x25E2DF0 Offset: 0x25E2EF1 VA: 0x25E2DF0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.AddLast
	|
	|-RVA: 0x25E5B20 Offset: 0x25E5C21 VA: 0x25E5B20
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddLast(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4550 Offset: 0x25E4651 VA: 0x25E4550
	|-LinkedList<FieldOnGroundItemInfo>.AddLast
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x25E1810 Offset: 0x25E1911 VA: 0x25E1810
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.AddLast
	|
	|-RVA: 0x25E2EB0 Offset: 0x25E2FB1 VA: 0x25E2EB0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.AddLast
	|
	|-RVA: 0x25E5C00 Offset: 0x25E5D01 VA: 0x25E5C00
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E45F0 Offset: 0x25E46F1 VA: 0x25E45F0
	|-LinkedList<FieldOnGroundItemInfo>.Clear
	|-LinkedList<object>.Clear
	|
	|-RVA: 0x25E18B0 Offset: 0x25E19B1 VA: 0x25E18B0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Clear
	|
	|-RVA: 0x25E2F50 Offset: 0x25E3051 VA: 0x25E2F50
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.Clear
	|
	|-RVA: 0x25E5CA0 Offset: 0x25E5DA1 VA: 0x25E5CA0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1950 Offset: 0x25E1A51 VA: 0x25E1950
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Contains
	|
	|-RVA: 0x25E2FF0 Offset: 0x25E30F1 VA: 0x25E2FF0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.Contains
	|
	|-RVA: 0x25E4690 Offset: 0x25E4791 VA: 0x25E4690
	|-LinkedList<object>.Contains
	|
	|-RVA: 0x25E5D40 Offset: 0x25E5E41 VA: 0x25E5D40
	|-LinkedList<DelayedActionManager.DelegateInfo>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1990 Offset: 0x25E1A91 VA: 0x25E1990
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.CopyTo
	|
	|-RVA: 0x25E3030 Offset: 0x25E3131 VA: 0x25E3030
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.CopyTo
	|
	|-RVA: 0x25E46D0 Offset: 0x25E47D1 VA: 0x25E46D0
	|-LinkedList<object>.CopyTo
	|
	|-RVA: 0x25E5DB0 Offset: 0x25E5EB1 VA: 0x25E5DB0
	|-LinkedList<DelayedActionManager.DelegateInfo>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Find(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1BA0 Offset: 0x25E1CA1 VA: 0x25E1BA0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Find
	|
	|-RVA: 0x25E3240 Offset: 0x25E3341 VA: 0x25E3240
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.Find
	|
	|-RVA: 0x25E48D0 Offset: 0x25E49D1 VA: 0x25E48D0
	|-LinkedList<object>.Find
	|
	|-RVA: 0x25E5FE0 Offset: 0x25E60E1 VA: 0x25E5FE0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Find
	*/

	// RVA: -1 Offset: -1
	public LinkedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4980 Offset: 0x25E4A81 VA: 0x25E4980
	|-LinkedList<FieldOnGroundItemInfo>.GetEnumerator
	|-LinkedList<BGMController>.GetEnumerator
	|-LinkedList<SEController>.GetEnumerator
	|-LinkedList<VoiceController>.GetEnumerator
	|-LinkedList<WebConnectionGroup.ConnectionState>.GetEnumerator
	|-LinkedList<object>.GetEnumerator
	|
	|-RVA: 0x25E1C40 Offset: 0x25E1D41 VA: 0x25E1C40
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.GetEnumerator
	|
	|-RVA: 0x25E32E0 Offset: 0x25E33E1 VA: 0x25E32E0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.GetEnumerator
	|
	|-RVA: 0x25E60C0 Offset: 0x25E61C1 VA: 0x25E60C0
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1CB0 Offset: 0x25E1DB1 VA: 0x25E1CB0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x25E3340 Offset: 0x25E3441 VA: 0x25E3340
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x25E49E0 Offset: 0x25E4AE1 VA: 0x25E49E0
	|-LinkedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x25E6160 Offset: 0x25E6261 VA: 0x25E6160
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4A70 Offset: 0x25E4B71 VA: 0x25E4A70
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>.Remove
	|-LinkedList<SEController>.Remove
	|-LinkedList<WebConnectionGroup.ConnectionState>.Remove
	|-LinkedList<object>.Remove
	|
	|-RVA: 0x25E1D40 Offset: 0x25E1E41 VA: 0x25E1D40
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Remove
	|
	|-RVA: 0x25E33D0 Offset: 0x25E34D1 VA: 0x25E33D0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.Remove
	|
	|-RVA: 0x25E61F0 Offset: 0x25E62F1 VA: 0x25E61F0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4AD0 Offset: 0x25E4BD1 VA: 0x25E4AD0
	|-LinkedList<FieldOnGroundItemInfo>.Remove
	|-LinkedList<Action>.Remove
	|-LinkedList<WebConnectionGroup.ConnectionState>.Remove
	|-LinkedList<object>.Remove
	|-LinkedList<CachedCodeEntry>.Remove
	|
	|-RVA: 0x25E1DA0 Offset: 0x25E1EA1 VA: 0x25E1DA0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.Remove
	|
	|-RVA: 0x25E3440 Offset: 0x25E3541 VA: 0x25E3440
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.Remove
	|
	|-RVA: 0x25E6280 Offset: 0x25E6381 VA: 0x25E6280
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E4B30 Offset: 0x25E4C31 VA: 0x25E4B30
	|-LinkedList<FieldOnGroundItemInfo>.RemoveFirst
	|-LinkedList<PartnerManager.LeaveHandCuffsParam>.RemoveFirst
	|-LinkedList<SEController>.RemoveFirst
	|-LinkedList<object>.RemoveFirst
	|
	|-RVA: 0x25E1E00 Offset: 0x25E1F01 VA: 0x25E1E00
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.RemoveFirst
	|
	|-RVA: 0x25E34A0 Offset: 0x25E35A1 VA: 0x25E34A0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.RemoveFirst
	|
	|-RVA: 0x25E62E0 Offset: 0x25E63E1 VA: 0x25E62E0
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveFirst
	*/

	// RVA: -1 Offset: -1
	public void RemoveLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1EB0 Offset: 0x25E1FB1 VA: 0x25E1EB0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.RemoveLast
	|
	|-RVA: 0x25E3550 Offset: 0x25E3651 VA: 0x25E3550
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.RemoveLast
	|
	|-RVA: 0x25E4BE0 Offset: 0x25E4CE1 VA: 0x25E4BE0
	|-LinkedList<object>.RemoveLast
	|-LinkedList<CachedCodeEntry>.RemoveLast
	|
	|-RVA: 0x25E6390 Offset: 0x25E6491 VA: 0x25E6390
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveLast
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E1F60 Offset: 0x25E2061 VA: 0x25E1F60
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.GetObjectData
	|
	|-RVA: 0x25E3600 Offset: 0x25E3701 VA: 0x25E3600
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.GetObjectData
	|
	|-RVA: 0x25E4C90 Offset: 0x25E4D91 VA: 0x25E4C90
	|-LinkedList<object>.GetObjectData
	|
	|-RVA: 0x25E6440 Offset: 0x25E6541 VA: 0x25E6440
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E20F0 Offset: 0x25E21F1 VA: 0x25E20F0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.OnDeserialization
	|
	|-RVA: 0x25E3790 Offset: 0x25E3891 VA: 0x25E3790
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.OnDeserialization
	|
	|-RVA: 0x25E4E20 Offset: 0x25E4F21 VA: 0x25E4E20
	|-LinkedList<object>.OnDeserialization
	|
	|-RVA: 0x25E65D0 Offset: 0x25E66D1 VA: 0x25E65D0
	|-LinkedList<DelayedActionManager.DelegateInfo>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E2310 Offset: 0x25E2411 VA: 0x25E2310
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalInsertNodeBefore
	|
	|-RVA: 0x25E39C0 Offset: 0x25E3AC1 VA: 0x25E39C0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.InternalInsertNodeBefore
	|
	|-RVA: 0x25E5040 Offset: 0x25E5141 VA: 0x25E5040
	|-LinkedList<object>.InternalInsertNodeBefore
	|
	|-RVA: 0x25E6800 Offset: 0x25E6901 VA: 0x25E6800
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeBefore
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E23A0 Offset: 0x25E24A1 VA: 0x25E23A0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x25E3A50 Offset: 0x25E3B51 VA: 0x25E3A50
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x25E50D0 Offset: 0x25E51D1 VA: 0x25E50D0
	|-LinkedList<object>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x25E6890 Offset: 0x25E6991 VA: 0x25E6890
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeToEmptyList
	*/

	// RVA: -1 Offset: -1
	internal void InternalRemoveNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E2410 Offset: 0x25E2511 VA: 0x25E2410
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.InternalRemoveNode
	|
	|-RVA: 0x25E3AC0 Offset: 0x25E3BC1 VA: 0x25E3AC0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.InternalRemoveNode
	|
	|-RVA: 0x25E5140 Offset: 0x25E5241 VA: 0x25E5140
	|-LinkedList<object>.InternalRemoveNode
	|
	|-RVA: 0x25E6900 Offset: 0x25E6A01 VA: 0x25E6900
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalRemoveNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNewNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E24D0 Offset: 0x25E25D1 VA: 0x25E24D0
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.ValidateNewNode
	|
	|-RVA: 0x25E3B80 Offset: 0x25E3C81 VA: 0x25E3B80
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.ValidateNewNode
	|
	|-RVA: 0x25E5200 Offset: 0x25E5301 VA: 0x25E5200
	|-LinkedList<object>.ValidateNewNode
	|
	|-RVA: 0x25E69C0 Offset: 0x25E6AC1 VA: 0x25E69C0
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNewNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E2590 Offset: 0x25E2691 VA: 0x25E2590
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.ValidateNode
	|
	|-RVA: 0x25E3C40 Offset: 0x25E3D41 VA: 0x25E3C40
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.ValidateNode
	|
	|-RVA: 0x25E52C0 Offset: 0x25E53C1 VA: 0x25E52C0
	|-LinkedList<object>.ValidateNode
	|
	|-RVA: 0x25E6A80 Offset: 0x25E6B81 VA: 0x25E6A80
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNode
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E2660 Offset: 0x25E2761 VA: 0x25E2660
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x25E3D10 Offset: 0x25E3E11 VA: 0x25E3D10
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x25E5390 Offset: 0x25E5491 VA: 0x25E5390
	|-LinkedList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x25E6B50 Offset: 0x25E6C51 VA: 0x25E6B50
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25E2A20 Offset: 0x25E2B21 VA: 0x25E2A20
	|-LinkedList<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x25E40E0 Offset: 0x25E41E1 VA: 0x25E40E0
	|-LinkedList<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x25E5710 Offset: 0x25E5811 VA: 0x25E5710
	|-LinkedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x25E6F20 Offset: 0x25E7021 VA: 0x25E6F20
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	*/
}

