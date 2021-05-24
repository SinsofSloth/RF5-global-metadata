[ComVisibleAttribute] // RVA: 0xB12D0 Offset: 0xB13D1 VA: 0xB12D0
public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 1218
{
	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue() { }
}

