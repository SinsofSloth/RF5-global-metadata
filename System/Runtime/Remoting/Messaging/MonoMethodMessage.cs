[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 1225
{
	// Fields
	private MonoMethod method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Type[] methodSignature; // 0x68
	private Identity identity; // 0x70
	internal static string CallContextKey; // 0x0
	internal static string UriKey; // 0x8

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x17599E0 Offset: 0x1759AE1 VA: 0x17599E0
	internal void InitMessage(MonoMethod method, object[] out_args) { }

	// RVA: 0x1759D70 Offset: 0x1759E71 VA: 0x1759D70
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x1759E50 Offset: 0x1759F51 VA: 0x1759E50
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x1759FB0 Offset: 0x175A0B1 VA: 0x1759FB0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x175A090 Offset: 0x175A191 VA: 0x175A090
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x175A130 Offset: 0x175A231 VA: 0x175A130 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x175A230 Offset: 0x175A331 VA: 0x175A230 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x175A3D0 Offset: 0x175A4D1 VA: 0x175A3D0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x175A3E0 Offset: 0x175A4E1 VA: 0x175A3E0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175A3F0 Offset: 0x175A4F1 VA: 0x175A3F0
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x175A400 Offset: 0x175A501 VA: 0x175A400 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x175A410 Offset: 0x175A511 VA: 0x175A410 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x175A4A0 Offset: 0x175A5A1 VA: 0x175A4A0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x175A5F0 Offset: 0x175A6F1 VA: 0x175A5F0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x175A690 Offset: 0x175A791 VA: 0x175A690 Slot: 19
	public string get_Uri() { }

	// RVA: 0x175A6A0 Offset: 0x175A7A1 VA: 0x175A6A0 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x175A6B0 Offset: 0x175A7B1 VA: 0x175A6B0 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x175A6F0 Offset: 0x175A7F1 VA: 0x175A6F0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x175A700 Offset: 0x175A801 VA: 0x175A700 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x175A790 Offset: 0x175A891 VA: 0x175A790 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x175A960 Offset: 0x175AA61 VA: 0x175A960 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x175A970 Offset: 0x175AA71 VA: 0x175A970 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175A980 Offset: 0x175AA81 VA: 0x175A980 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x175A990 Offset: 0x175AA91 VA: 0x175A990
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x175A310 Offset: 0x175A411 VA: 0x175A310
	internal CallType get_CallType() { }

	// RVA: 0x175A9A0 Offset: 0x175AAA1 VA: 0x175A9A0
	public bool NeedsOutProcessing(out int outCount) { }

	// RVA: 0x175AA50 Offset: 0x175AB51 VA: 0x175AA50
	private static void .cctor() { }
}

