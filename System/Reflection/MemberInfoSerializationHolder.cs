[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 547
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x19690C0 Offset: 0x19691C1 VA: 0x19690C0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x19690D0 Offset: 0x19691D1 VA: 0x19690D0
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x1969360 Offset: 0x1969461 VA: 0x1969360
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1969630 Offset: 0x1969731 VA: 0x1969630 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19696B0 Offset: 0x19697B1 VA: 0x19696B0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

