[CLSCompliantAttribute] // RVA: 0xB12F0 Offset: 0xB13F1 VA: 0xB12F0
[ComVisibleAttribute] // RVA: 0xB12F0 Offset: 0xB13F1 VA: 0xB12F0
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1219
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x1750EE0 Offset: 0x1750FE1 VA: 0x1750EE0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1757050 Offset: 0x1757151 VA: 0x1757050
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x1750EC0 Offset: 0x1750FC1 VA: 0x1750EC0
	internal void .ctor() { }

	// RVA: 0x17572A0 Offset: 0x17573A1 VA: 0x17572A0
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x17515C0 Offset: 0x17516C1 VA: 0x17515C0 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x1751AD0 Offset: 0x1751BD1 VA: 0x1751AD0 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1757680 Offset: 0x1757781 VA: 0x1757680 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x17576A0 Offset: 0x17577A1 VA: 0x17576A0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x17576B0 Offset: 0x17577B1 VA: 0x17576B0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1757740 Offset: 0x1757841 VA: 0x1757740 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1757EF0 Offset: 0x1757FF1 VA: 0x1757EF0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x1757F50 Offset: 0x1758051 VA: 0x1757F50 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1751EF0 Offset: 0x1751FF1 VA: 0x1751EF0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17580B0 Offset: 0x17581B1 VA: 0x17580B0 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x17581D0 Offset: 0x17582D1 VA: 0x17581D0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x1758250 Offset: 0x1758351 VA: 0x1758250 Slot: 11
	public string get_Uri() { }

	// RVA: 0x1758260 Offset: 0x1758361 VA: 0x1758260
	public void set_Uri(string value) { }

	// RVA: 0x1758270 Offset: 0x1758371 VA: 0x1758270 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x1758280 Offset: 0x1758381 VA: 0x1758280 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1758290 Offset: 0x1758391 VA: 0x1758290 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x17582D0 Offset: 0x17583D1 VA: 0x17582D0 Slot: 23
	public virtual void Init() { }

	// RVA: 0x1757780 Offset: 0x1757881 VA: 0x1757780
	public void ResolveMethod() { }

	// RVA: 0x17582E0 Offset: 0x17583E1 VA: 0x17582E0
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x1758520 Offset: 0x1758621 VA: 0x1758520
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x17585D0 Offset: 0x17586D1 VA: 0x17585D0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17585E0 Offset: 0x17586E1 VA: 0x17585E0 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x17584A0 Offset: 0x17585A1 VA: 0x17584A0
	private Type[] get_GenericArguments() { }
}

