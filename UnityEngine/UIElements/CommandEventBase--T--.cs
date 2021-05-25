public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent // TypeDefIndex: 4152
{
	// Fields
	private string m_CommandName; // 0x0

	// Properties
	protected string commandName { set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void set_commandName(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADB20 Offset: 0x2AADC21 VA: 0x2AADB20
	|-CommandEventBase<object>.set_commandName
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADB30 Offset: 0x2AADC31 VA: 0x2AADB30
	|-CommandEventBase<object>.Init
	|-CommandEventBase<ExecuteCommandEvent>.Init
	|-CommandEventBase<ValidateCommandEvent>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADB80 Offset: 0x2AADC81 VA: 0x2AADB80
	|-CommandEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(Event systemEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADBB0 Offset: 0x2AADCB1 VA: 0x2AADBB0
	|-CommandEventBase<object>.GetPooled
	|-CommandEventBase<ExecuteCommandEvent>.GetPooled
	|-CommandEventBase<ValidateCommandEvent>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AADD40 Offset: 0x2AADE41 VA: 0x2AADD40
	|-CommandEventBase<object>..ctor
	|-CommandEventBase<ExecuteCommandEvent>..ctor
	|-CommandEventBase<ValidateCommandEvent>..ctor
	*/
}

