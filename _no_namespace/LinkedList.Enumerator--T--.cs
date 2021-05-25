[Serializable]
public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 2075
{
	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309660 Offset: 0x309761 VA: 0x309660
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x309730 Offset: 0x309831 VA: 0x309730
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x309810 Offset: 0x309911 VA: 0x309810
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x34F3E0 Offset: 0x34F4E1 VA: 0x34F3E0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3096B0 Offset: 0x3097B1 VA: 0x3096B0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x309790 Offset: 0x309891 VA: 0x309790
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>..ctor
	|
	|-RVA: 0x309860 Offset: 0x309961 VA: 0x309860
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x34F440 Offset: 0x34F541 VA: 0x34F440
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309870 Offset: 0x309971 VA: 0x309870
	|-LinkedList.Enumerator<FieldOnGroundItemInfo>.get_Current
	|-LinkedList.Enumerator<BGMController>.get_Current
	|-LinkedList.Enumerator<SEController>.get_Current
	|-LinkedList.Enumerator<VoiceController>.get_Current
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.get_Current
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x3096C0 Offset: 0x3097C1 VA: 0x3096C0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.get_Current
	|
	|-RVA: 0x3097A0 Offset: 0x3098A1 VA: 0x3097A0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.get_Current
	|
	|-RVA: 0x34F450 Offset: 0x34F551 VA: 0x34F450
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3096D0 Offset: 0x3097D1 VA: 0x3096D0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3097B0 Offset: 0x3098B1 VA: 0x3097B0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x309880 Offset: 0x309981 VA: 0x309880
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x34F470 Offset: 0x34F571 VA: 0x34F470
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309890 Offset: 0x309991 VA: 0x309890
	|-LinkedList.Enumerator<FieldOnGroundItemInfo>.MoveNext
	|-LinkedList.Enumerator<BGMController>.MoveNext
	|-LinkedList.Enumerator<SEController>.MoveNext
	|-LinkedList.Enumerator<VoiceController>.MoveNext
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.MoveNext
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x3096E0 Offset: 0x3097E1 VA: 0x3096E0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.MoveNext
	|
	|-RVA: 0x3097C0 Offset: 0x3098C1 VA: 0x3097C0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.MoveNext
	|
	|-RVA: 0x34F480 Offset: 0x34F581 VA: 0x34F480
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3096F0 Offset: 0x3097F1 VA: 0x3096F0
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3097D0 Offset: 0x3098D1 VA: 0x3097D0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3098A0 Offset: 0x3099A1 VA: 0x3098A0
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x34F490 Offset: 0x34F591 VA: 0x34F490
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3098B0 Offset: 0x3099B1 VA: 0x3098B0
	|-LinkedList.Enumerator<FieldOnGroundItemInfo>.Dispose
	|-LinkedList.Enumerator<BGMController>.Dispose
	|-LinkedList.Enumerator<SEController>.Dispose
	|-LinkedList.Enumerator<VoiceController>.Dispose
	|-LinkedList.Enumerator<WebConnectionGroup.ConnectionState>.Dispose
	|-LinkedList.Enumerator<object>.Dispose
	|
	|-RVA: 0x309700 Offset: 0x309801 VA: 0x309700
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.Dispose
	|
	|-RVA: 0x3097E0 Offset: 0x3098E1 VA: 0x3097E0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.Dispose
	|
	|-RVA: 0x34F4A0 Offset: 0x34F5A1 VA: 0x34F4A0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309710 Offset: 0x309811 VA: 0x309710
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x3097F0 Offset: 0x3098F1 VA: 0x3097F0
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x3098C0 Offset: 0x3099C1 VA: 0x3098C0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x34F4B0 Offset: 0x34F5B1 VA: 0x34F4B0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x309720 Offset: 0x309821 VA: 0x309720
	|-LinkedList.Enumerator<SimpleAnimationPlayable.QueuedState>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x309800 Offset: 0x309901 VA: 0x309800
	|-LinkedList.Enumerator<SkillLevelUpEffectController.LevelUpInfo>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x3098D0 Offset: 0x3099D1 VA: 0x3098D0
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x34F4C0 Offset: 0x34F5C1 VA: 0x34F4C0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/
}

