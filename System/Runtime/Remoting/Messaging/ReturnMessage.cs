[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

[ComVisibleAttribute] // RVA: 0xB1410 Offset: 0xB1511 VA: 0xB1410
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 1231
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

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
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x175B0E0 Offset: 0x175B1E1 VA: 0x175B0E0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x173FC70 Offset: 0x173FD71 VA: 0x173FC70
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x175B2C0 Offset: 0x175B3C1 VA: 0x175B2C0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x175B2E0 Offset: 0x175B3E1 VA: 0x175B2E0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x175B2F0 Offset: 0x175B3F1 VA: 0x175B2F0 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x175B380 Offset: 0x175B481 VA: 0x175B380 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x175B390 Offset: 0x175B491 VA: 0x175B390 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x175B410 Offset: 0x175B511 VA: 0x175B410 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x175B570 Offset: 0x175B671 VA: 0x175B570 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x175B610 Offset: 0x175B711 VA: 0x175B610 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x175B6A0 Offset: 0x175B7A1 VA: 0x175B6A0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x175B6B0 Offset: 0x175B7B1 VA: 0x175B6B0
	public void set_Uri(string value) { }

	// RVA: 0x175B6C0 Offset: 0x175B7C1 VA: 0x175B6C0 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x175B6D0 Offset: 0x175B7D1 VA: 0x175B6D0 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x175B6E0 Offset: 0x175B7E1 VA: 0x175B6E0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x175B720 Offset: 0x175B821 VA: 0x175B720 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x175B730 Offset: 0x175B831 VA: 0x175B730 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x175B810 Offset: 0x175B911 VA: 0x175B810 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x175B820 Offset: 0x175B921 VA: 0x175B820 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x175B830 Offset: 0x175B931 VA: 0x175B830 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

