[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 1209
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x1740B60 Offset: 0x1740C61 VA: 0x1740B60
	public void .ctor() { }

	// RVA: 0x1753750 Offset: 0x1753851 VA: 0x1753750 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x1753760 Offset: 0x1753861 VA: 0x1753760 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x1753770 Offset: 0x1753871 VA: 0x1753770 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x1753780 Offset: 0x1753881 VA: 0x1753780 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x17537D0 Offset: 0x17538D1 VA: 0x17537D0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x17537E0 Offset: 0x17538E1 VA: 0x17537E0 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17537F0 Offset: 0x17538F1 VA: 0x17537F0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x1753840 Offset: 0x1753941 VA: 0x1753840 Slot: 11
	public string get_Uri() { }

	// RVA: 0x1753850 Offset: 0x1753951 VA: 0x1753850 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x1753860 Offset: 0x1753961 VA: 0x1753860 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}

