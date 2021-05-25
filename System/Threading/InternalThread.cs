internal sealed class InternalThread : CriticalFinalizerObject // TypeDefIndex: 831
{
	// Fields
	private int lock_thread_id; // 0x10
	private IntPtr handle; // 0x18
	private IntPtr native_handle; // 0x20
	private IntPtr unused3; // 0x28
	private IntPtr name; // 0x30
	private int name_len; // 0x38
	private ThreadState state; // 0x3C
	private object abort_exc; // 0x40
	private int abort_state_handle; // 0x48
	internal long thread_id; // 0x50
	private IntPtr debugger_thread; // 0x58
	private UIntPtr static_data; // 0x60
	private IntPtr runtime_thread_info; // 0x68
	private object current_appcontext; // 0x70
	private object root_domain_thread; // 0x78
	internal byte[] _serialized_principal; // 0x80
	internal int _serialized_principal_version; // 0x88
	private IntPtr appdomain_refs; // 0x90
	private int interruption_requested; // 0x98
	private IntPtr synch_cs; // 0xA0
	internal bool threadpool_thread; // 0xA8
	private bool thread_interrupt_requested; // 0xA9
	internal int stack_size; // 0xAC
	internal byte apartment_state; // 0xB0
	internal int critical_region_level; // 0xB4
	internal int managed_id; // 0xB8
	private int small_id; // 0xBC
	private IntPtr manage_callback; // 0xC0
	private IntPtr unused4; // 0xC8
	private IntPtr flags; // 0xD0
	private IntPtr thread_pinning_ref; // 0xD8
	private IntPtr abort_protected_block_count; // 0xE0
	private int priority; // 0xE8
	private IntPtr owned_mutex; // 0xF0
	private IntPtr suspended_event; // 0xF8
	private int self_suspended; // 0x100
	private IntPtr unused1; // 0x108
	private IntPtr unused2; // 0x110
	private IntPtr last; // 0x118

	// Methods

	// RVA: 0x1A0F830 Offset: 0x1A0F931 VA: 0x1A0F830
	private void Thread_free_internal() { }

	[ReliabilityContractAttribute] // RVA: 0xB9020 Offset: 0xB9121 VA: 0xB9020
	// RVA: 0x1A0F840 Offset: 0x1A0F941 VA: 0x1A0F840 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A0F8B0 Offset: 0x1A0F9B1 VA: 0x1A0F8B0
	public void .ctor() { }
}

