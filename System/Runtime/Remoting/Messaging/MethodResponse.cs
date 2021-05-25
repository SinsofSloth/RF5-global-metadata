[ComVisibleAttribute] // RVA: 0xB1370 Offset: 0xB1471 VA: 0xB1370
[CLSCompliantAttribute] // RVA: 0xB1370 Offset: 0xB1471 VA: 0xB1370
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 1223
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x173FE00 Offset: 0x173FF01 VA: 0x173FE00
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x1753250 Offset: 0x1753351 VA: 0x1753250
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x1741100 Offset: 0x1741201 VA: 0x1741100
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x17533A0 Offset: 0x17534A1 VA: 0x17533A0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17585F0 Offset: 0x17586F1 VA: 0x17585F0
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x17589D0 Offset: 0x1758AD1 VA: 0x17589D0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x17589F0 Offset: 0x1758AF1 VA: 0x17589F0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x1758A00 Offset: 0x1758B01 VA: 0x1758A00 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x1758A10 Offset: 0x1758B11 VA: 0x1758A10 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1758AA0 Offset: 0x1758BA1 VA: 0x1758AA0 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x1758BE0 Offset: 0x1758CE1 VA: 0x1758BE0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1758DE0 Offset: 0x1758EE1 VA: 0x1758DE0 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1758F20 Offset: 0x1759021 VA: 0x1758F20 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x1753440 Offset: 0x1753541 VA: 0x1753440 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1759140 Offset: 0x1759241 VA: 0x1759140 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x1758CE0 Offset: 0x1758DE1 VA: 0x1758CE0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x1759150 Offset: 0x1759251 VA: 0x1759150 Slot: 14
	public string get_Uri() { }

	// RVA: 0x1759250 Offset: 0x1759351 VA: 0x1759250
	public void set_Uri(string value) { }

	// RVA: 0x1759260 Offset: 0x1759361 VA: 0x1759260 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x1759270 Offset: 0x1759371 VA: 0x1759270 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1759280 Offset: 0x1759381 VA: 0x1759280 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x17592C0 Offset: 0x17593C1 VA: 0x17592C0 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17596A0 Offset: 0x17597A1 VA: 0x17596A0 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17596B0 Offset: 0x17597B1 VA: 0x17596B0 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

