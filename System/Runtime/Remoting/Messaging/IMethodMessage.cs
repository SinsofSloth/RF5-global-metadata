[ComVisibleAttribute] // RVA: 0xB12B0 Offset: 0xB13B1 VA: 0xB12B0
public interface IMethodMessage : IMessage // TypeDefIndex: 1217
{
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum) { }
}

