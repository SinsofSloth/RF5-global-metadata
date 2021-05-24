internal struct RuntimeClassHandle // TypeDefIndex: 4
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x11240 Offset: 0x11341 VA: 0x11240
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x11250 Offset: 0x11351 VA: 0x11250
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x11280 Offset: 0x11381 VA: 0x11280
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x11290 Offset: 0x11391 VA: 0x11290 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x112A0 Offset: 0x113A1 VA: 0x112A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x193FE30 Offset: 0x193FF31 VA: 0x193FE30
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x112E0 Offset: 0x113E1 VA: 0x112E0
	internal RuntimeTypeHandle GetTypeHandle() { }
}

