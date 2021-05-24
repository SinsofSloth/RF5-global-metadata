private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 1924
{
	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x16DF2E0 Offset: 0x16DF3E1 VA: 0x16DF2E0
	internal void .ctor() { }

	// RVA: 0x16DF320 Offset: 0x16DF421 VA: 0x16DF320
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x16DF330 Offset: 0x16DF431 VA: 0x16DF330
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x16DF340 Offset: 0x16DF441 VA: 0x16DF340
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x16DF350 Offset: 0x16DF451 VA: 0x16DF350
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x16DF360 Offset: 0x16DF461 VA: 0x16DF360 Slot: 5
	internal override bool Cancel() { }
}

