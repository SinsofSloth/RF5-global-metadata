public sealed class ActionCommandTable.DataTableToCommand : MulticastDelegate // TypeDefIndex: 6216
{
	// Methods

	// RVA: 0x1E782E0 Offset: 0x1E783E1 VA: 0x1E782E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E689A0 Offset: 0x1E68AA1 VA: 0x1E689A0 Slot: 13
	public virtual ActionCommandBase Invoke(ActionCommandDataTable dataTable, ActionScriptControllerBase commandBase) { }

	// RVA: 0x1E7CCB0 Offset: 0x1E7CDB1 VA: 0x1E7CCB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ActionCommandDataTable dataTable, ActionScriptControllerBase commandBase, AsyncCallback callback, object object) { }

	// RVA: 0x1E7CD50 Offset: 0x1E7CE51 VA: 0x1E7CD50 Slot: 15
	public virtual ActionCommandBase EndInvoke(IAsyncResult result) { }
}

