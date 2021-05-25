internal static class TaskToApm // TypeDefIndex: 880
{
	// Methods

	// RVA: 0x1588280 Offset: 0x1588381 VA: 0x1588280
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x1588570 Offset: 0x1588671 VA: 0x1588570
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2268420 Offset: 0x2268521 VA: 0x2268420
	|-TaskToApm.End<int>
	|
	|-RVA: 0x22684E0 Offset: 0x22685E1 VA: 0x22684E0
	|-TaskToApm.End<object>
	*/

	// RVA: 0x1588470 Offset: 0x1588571 VA: 0x1588470
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}

